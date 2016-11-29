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
    public partial class FrmItemDetalle : Form
    {
        public FrmItemDetalle()
        {
            InitializeComponent();
        }

        public FrmItemDetalle(ArticuloUtil art)
        {
            InitializeComponent();
            pbArticulo.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(art.Art_imagen);
            this.Text += art.Art_id;
            labelDescrip.Text = art.Art_descrip;
            labelCategoria.Text = art.Cat_descrip;
            labelUMed.Text = art.Um_descrip;
            labelPrecio.Text += art.Art_precio.ToString();
        }
    }
}