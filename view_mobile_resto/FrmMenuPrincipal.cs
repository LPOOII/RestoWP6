using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace view_mobile_resto
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuItemAcercaDe_Click(object sender, EventArgs e)
        {
            FrmAcerca oAcerca = new FrmAcerca();
            oAcerca.ShowDialog();
        }

        private void menuItemPedidos_Click(object sender, EventArgs e)
        {
            FrmMesasEstados oMesasEstados = new FrmMesasEstados();
            oMesasEstados.Show();
        }
    }
}