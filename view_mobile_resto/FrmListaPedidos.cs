using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using view_mobile_resto.Controller;

namespace view_mobile_resto
{
    public partial class FrmListaPedidos : Form
    {
        public FrmListaPedidos()
        {
            InitializeComponent();
            dataGridPedidos.DataSource = TrabajarPedido.lista_pedidos();
        }
    }
}