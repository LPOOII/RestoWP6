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
    public partial class FrmPedido : Form
    {
        private List<ItemPedido> listPedidos = new List<ItemPedido>();
        private int PedidoId;
        private Pedido pedidoMesa;

        public FrmPedido()
        {
            InitializeComponent();
        }

        public FrmPedido(int me)
        {
            InitializeComponent();
            labelFecha.Text = DateTime.Now.ToString();
            labelMesa.Text = Convert.ToString(me);            
            dgItemPedidos.DataSource = listPedidos;
            PedidoId = TrabajarPedido.iniciar_pedido(me);
            this.Text = "Pedido #" + PedidoId;
            TrabajarMesas.cambiar_estado_mesa(me, 2);
        }

        public FrmPedido(Pedido pedido)
        {
            InitializeComponent();
            pedidoMesa = pedido;
            labelFecha.Text = pedido.Fecha.ToString() ;
            labelMesa.Text = Convert.ToString(pedido.Mesa);
            txtComensalesPedido.Text = Convert.ToString(pedido.Comensales);
            dgItemPedidos.DataSource = listPedidos;
            PedidoId = pedido.Id;
            this.Text += Convert.ToString(PedidoId);
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            FrmCategorias cat = new FrmCategorias(PedidoId);
            cat.Show();
        }

        private void FrmPedido_GotFocus(object sender, EventArgs e)
        {
            dgItemPedidos.DataSource = TrabajarItemPedido.traer_items_por_pedido(PedidoId);
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {            
            if (txtComensalesPedido.Text.Equals(""))
            {
                MessageBox.Show("Indica la cantidad de comensales.");
            }
            else {
                TrabajarMesas.cambiar_estado_mesa(Convert.ToInt32(labelMesa.Text), 1);
                TrabajarPedido.actualizar_pedido(PedidoId, Convert.ToInt32(txtComensalesPedido.Text), false);
                this.Close();
            }            
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            Pedido p = TrabajarPedido.traer_pedido(Convert.ToInt32(labelMesa.Text));
            FrmFacturacion frmFacturacion = new FrmFacturacion(p);
            frmFacturacion.Show();
            this.Close();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            int rowIndex = dgItemPedidos.CurrentCell.RowNumber;
            object obj = dgItemPedidos[rowIndex, 0];
            if ((obj != null) && (obj != DBNull.Value))
            {
                TrabajarItemPedido.eliminar_item(Convert.ToInt32(obj));
                dgItemPedidos.DataSource = TrabajarItemPedido.traer_items_por_pedido(PedidoId);                
            }            
        }

        
    }
}