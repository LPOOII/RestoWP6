namespace view_mobile_resto
{
    partial class FrmItemDetalle
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelUMed = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelDescrip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(0, 0);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(240, 186);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Descrip";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "U. Med.";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Precio";
            // 
            // labelPrecio
            // 
            this.labelPrecio.Location = new System.Drawing.Point(128, 256);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(100, 20);
            this.labelPrecio.Text = "$";
            this.labelPrecio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelUMed
            // 
            this.labelUMed.Location = new System.Drawing.Point(128, 236);
            this.labelUMed.Name = "labelUMed";
            this.labelUMed.Size = new System.Drawing.Size(100, 20);
            this.labelUMed.Text = "label6";
            this.labelUMed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCategoria
            // 
            this.labelCategoria.Location = new System.Drawing.Point(128, 216);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(100, 20);
            this.labelCategoria.Text = "label7";
            this.labelCategoria.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDescrip
            // 
            this.labelDescrip.Location = new System.Drawing.Point(128, 196);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(100, 20);
            this.labelDescrip.Text = "label8";
            this.labelDescrip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmItemDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelUMed);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelDescrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbArticulo);
            this.Name = "FrmItemDetalle";
            this.Text = "Articulo #";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelUMed;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelDescrip;
    }
}