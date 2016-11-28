using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using view_mobile_resto.Controller;
using view_mobile_resto.Clases;

namespace view_mobile_resto
{
    public partial class FrmCategorias : Form
    {
        private int idPedido;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        public FrmCategorias(int id_pedido)
        {
            InitializeComponent();
            List<Categoria> lista = TrabajarCategoria.lista_categoria();
            listCategoria.DataSource = lista;
            listCategoria.DisplayMember = "Des";
            listCategoria.ValueMember = "Id";
            idPedido = id_pedido;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            FrmAgregarItems items = new FrmAgregarItems(listCategoria.SelectedValue.ToString(), idPedido);
            this.Close();
            items.Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            Categoria categoria = TrabajarCategoria.traer_categoria(Convert.ToInt32(listCategoria.SelectedValue));
            FrmCategoriaDetalle det = new FrmCategoriaDetalle(categoria);
            det.Show();
        }

    }
}