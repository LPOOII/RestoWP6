namespace view_mobile_resto
{
    partial class FrmPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtComensalesPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelMesa = new System.Windows.Forms.Label();
            this.dgItemPedidos = new System.Windows.Forms.DataGrid();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Comensales";
            // 
            // txtComensalesPedido
            // 
            this.txtComensalesPedido.Location = new System.Drawing.Point(108, 62);
            this.txtComensalesPedido.Name = "txtComensalesPedido";
            this.txtComensalesPedido.Size = new System.Drawing.Size(100, 21);
            this.txtComensalesPedido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Fecha";
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(4, 35);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(100, 20);
            this.lbl.Text = "Mesa";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem4);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.Text = "Items";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Agregar";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Quitar";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.MenuItems.Add(this.menuItem5);
            this.menuItem4.MenuItems.Add(this.menuItem6);
            this.menuItem4.Text = "Pedido";
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Confirmar";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Facturar";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.Location = new System.Drawing.Point(89, 3);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(138, 20);
            this.labelFecha.Text = "?";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMesa
            // 
            this.labelMesa.Location = new System.Drawing.Point(108, 33);
            this.labelMesa.Name = "labelMesa";
            this.labelMesa.Size = new System.Drawing.Size(100, 20);
            this.labelMesa.Text = "?";
            this.labelMesa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgItemPedidos
            // 
            this.dgItemPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgItemPedidos.Location = new System.Drawing.Point(0, 113);
            this.dgItemPedidos.Name = "dgItemPedidos";
            this.dgItemPedidos.Size = new System.Drawing.Size(240, 148);
            this.dgItemPedidos.TabIndex = 10;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dgItemPedidos);
            this.Controls.Add(this.labelMesa);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComensalesPedido);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "FrmPedido";
            this.Text = "Pedido #";
            this.GotFocus += new System.EventHandler(this.FrmPedido_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComensalesPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelMesa;
        private System.Windows.Forms.DataGrid dgItemPedidos;
    }
}