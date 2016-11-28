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
    public partial class FrmFacturacion : Form
    {
        private Pedido pedido;

        public FrmFacturacion()
        {
            InitializeComponent();
        }

        public FrmFacturacion(Pedido p)
        {
            InitializeComponent();
            labelTotal.Text += TrabajarItemPedido.calcular_facturacion(p.Id).ToString();
            labelMesa.Text = p.Mesa.ToString();
            labelFecha.Text = p.Fecha.ToString();
            labelComensales.Text = p.Comensales.ToString();
            pedido = p;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!pedido.Comensales.Equals(0))
            {
                TrabajarPedido.actualizar_pedido(pedido.Id, pedido.Comensales, true);
                TrabajarMesas.cambiar_estado_mesa(3, pedido.Mesa);
                this.Close();
            }
            else {
                MessageBox.Show("La cantidad de comensales debe ser superior a 0");
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}