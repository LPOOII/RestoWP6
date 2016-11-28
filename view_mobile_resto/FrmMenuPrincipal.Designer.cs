namespace view_mobile_resto
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuItemPedidos = new System.Windows.Forms.MenuItem();
            this.menuItemAcercaDe = new System.Windows.Forms.MenuItem();
            this.pictureFondo = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.menuItemPedidos);
            this.mainMenu.MenuItems.Add(this.menuItemAcercaDe);
            // 
            // menuItemPedidos
            // 
            this.menuItemPedidos.Text = "Pedidos";
            this.menuItemPedidos.Click += new System.EventHandler(this.menuItemPedidos_Click);
            // 
            // menuItemAcercaDe
            // 
            this.menuItemAcercaDe.Text = "Acerca de";
            this.menuItemAcercaDe.Click += new System.EventHandler(this.menuItemAcercaDe_Click);
            // 
            // pictureFondo
            // 
            this.pictureFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureFondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureFondo.Image")));
            this.pictureFondo.Location = new System.Drawing.Point(0, 0);
            this.pictureFondo.Name = "pictureFondo";
            this.pictureFondo.Size = new System.Drawing.Size(240, 268);
            this.pictureFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pictureFondo);
            this.Menu = this.mainMenu;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Esperanto Resto ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemPedidos;
        private System.Windows.Forms.MenuItem menuItemAcercaDe;
        private System.Windows.Forms.PictureBox pictureFondo;
    }
}