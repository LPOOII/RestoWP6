namespace view_mobile_resto
{
    partial class FrmCategoriaDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoriaDetalle));
            this.pbCategoria = new System.Windows.Forms.PictureBox();
            this.labelDescrip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbCategoria
            // 
            this.pbCategoria.Image = ((System.Drawing.Image)(resources.GetObject("pbCategoria.Image")));
            this.pbCategoria.Location = new System.Drawing.Point(0, 8);
            this.pbCategoria.Name = "pbCategoria";
            this.pbCategoria.Size = new System.Drawing.Size(240, 207);
            this.pbCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // labelDescrip
            // 
            this.labelDescrip.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.labelDescrip.Location = new System.Drawing.Point(21, 232);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(195, 32);
            this.labelDescrip.Text = "label1";
            this.labelDescrip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmCategoriaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.labelDescrip);
            this.Controls.Add(this.pbCategoria);
            this.Name = "FrmCategoriaDetalle";
            this.Text = "Categoria #";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCategoria;
        private System.Windows.Forms.Label labelDescrip;
    }
}