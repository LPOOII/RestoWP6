using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using view_mobile_resto.Clases;

namespace view_mobile_resto
{
    public partial class FrmCategoriaDetalle : Form
    {
        public FrmCategoriaDetalle()
        {
            InitializeComponent();            
        }

        public FrmCategoriaDetalle(Categoria cat)
        {
            InitializeComponent();
            pbCategoria.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(cat.Img);
            labelDescrip.Text = cat.Des;
            this.Text += cat.Id;
        }
    }
}