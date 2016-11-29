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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.menuItemPedidos);
            this.mainMenu.MenuItems.Add(this.menuItemAcercaDe);
            // 
            // menuItemPedidos
            // 
            this.menuItemPedidos.MenuItems.Add(this.menuItem1);
            this.menuItemPedidos.MenuItems.Add(this.menuItem2);
            this.menuItemPedidos.Text = "Pedidos";
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
            // menuItem1
            // 
            this.menuItem1.Text = "Pedidos";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Mesas";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
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
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}