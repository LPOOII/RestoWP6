using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using view_mobile_resto.Clases;
using view_mobile_resto.Controller;

namespace view_mobile_resto
{
    public partial class FrmAgregarItems : Form
    {
        private int idPedido;

        public FrmAgregarItems()
        {
            InitializeComponent();
        }
        public FrmAgregarItems(String id_categoria, int id_pedido)
        {
            InitializeComponent();
            List<Articulo> list = TrabajarArticulo.buscar_articulo(Convert.ToInt32(id_categoria));
            listArticulos.DataSource = list;
            listArticulos.DisplayMember = "ArtDes";
            listArticulos.ValueMember = "ArtId";
            idPedido = id_pedido;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Articulo artSelected = TrabajarArticulo.traer_articulo(Convert.ToInt32(listArticulos.SelectedValue));
            ItemPedido item = new ItemPedido();
            item.Pedido = idPedido;
            item.Art = artSelected.ArtId;
            item.Precio = artSelected.Precio;
            item.Cant = Convert.ToInt32(txtCantidad.Text);
            item.Importe = artSelected.Precio * Convert.ToInt32(txtCantidad.Text);
            TrabajarItemPedido.agregar_item_pedido(item);
            this.Close();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            ArticuloUtil art = TrabajarArticulo.traer_articulo_util(Convert.ToInt32(listArticulos.SelectedValue));
            FrmItemDetalle det = new FrmItemDetalle(art);
            det.Show();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
       
    }
}