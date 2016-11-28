namespace view_mobile_resto
{
    partial class FrmMesasEstados
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
            this.btnMesa1 = new System.Windows.Forms.Button();
            this.btnMesa2 = new System.Windows.Forms.Button();
            this.btnMesa3 = new System.Windows.Forms.Button();
            this.btnMesa6 = new System.Windows.Forms.Button();
            this.btnMesa5 = new System.Windows.Forms.Button();
            this.btnMesa4 = new System.Windows.Forms.Button();
            this.btnMesa9 = new System.Windows.Forms.Button();
            this.btnMesa8 = new System.Windows.Forms.Button();
            this.btnMesa7 = new System.Windows.Forms.Button();
            this.btnMesa10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMesa1
            // 
            this.btnMesa1.Location = new System.Drawing.Point(9, 27);
            this.btnMesa1.Name = "btnMesa1";
            this.btnMesa1.Size = new System.Drawing.Size(70, 56);
            this.btnMesa1.TabIndex = 0;
            this.btnMesa1.Text = "Mesa 1";
            this.btnMesa1.Click += new System.EventHandler(this.hacer_pedido);
            // 
            // btnMesa2
            // 
            this.btnMesa2.Location = new System.Drawing.Point(85, 27);
            this.btnMesa2.Name = "btnMesa2";
            this.btnMesa2.Size = new System.Drawing.Size(70, 56);
            this.btnMesa2.TabIndex = 1;
            this.btnMesa2.Text = "Mesa 2";
            this.btnMesa2.Click += new System.EventHandler(this.hacer_pedido);
            // 
            // btnMesa3
            // 
            this.btnMesa3.Location = new System.Drawing.Point(162, 27);
            this.btnMesa3.Name = "btnMesa3";
            this.btnMesa3.Size = new System.Drawing.Size(70, 56);
            this.btnMesa3.TabIndex = 2;
            this.btnMesa3.Text = "Mesa 3";
            this.btnMesa3.Click += new System.EventHandler(this.hacer_pedido);
            // 
            // btnMesa6
            // 
            this.btnMesa6.Location = new System.Drawing.Point(162, 90);
            this.btnMesa6.Name = "btnMesa6";
            this.btnMesa6.Size = new System.Drawing.Size(70, 56);
            this.btnMesa6.TabIndex = 5;
            this.btnMesa6.Text = "Mesa 6";
            this.btnMesa6.Click += new System.EventHandler(this.hacer_pedido);
            // 
            // btnMesa5
            // 
            this.btnMesa5.Location = new System.Drawing.Point(85, 90);
            this.btnMesa5.Name = "btnMesa5";
            this.btnMesa5.Size = new System.Drawing.Size(70, 56);
            this.btnMesa5.TabIndex = 4;
            this.btnMesa5.Text = "Mesa 5";
            this.btnMesa5.Click += new System.EventHandler(this.hacer_pedido);
            // 
            // btnMesa4
            // 
            this.btnMesa4.Location = new System.Drawing.Point(9, 90);
            this.btnMesa4.Name = "btnMesa4";
            this.btnMesa4.Size = new System.Drawing.Size(70, 56);
            this.btnMesa4.TabIndex = 3;
            this.btnMesa4.Text = "Mesa 4";
            this.btnMesa4.Click += new System.EventHandler(this.hacer_pedido);
            // 
            // btnMesa9
            // 
            this.btnMesa9.Location = new System.Drawing.Point(161, 154);
            this.btnMesa9.Name = "btnMesa9";
            this.btnMesa9.Size = new System.Drawing.Size(70, 56);
            this.btnMesa9.TabIndex = 8;
            this.btnMesa9.Text = "Mesa 9";
            this.btnMesa9.Click += new System.EventHandler(this.hacer_pedido);
            // 
            // btnMesa8
            // 
            this.btnMesa8.Location = new System.Drawing.Point(84, 154);
            this.btnMesa8.Name = "btnMesa8";
            this.btnMesa8.Size = new System.Drawing.Size(70, 56);
            this.btnMesa8.TabIndex = 7;
            this.btnMesa8.Text = "Mesa 8";
            this.btnMesa8.Click += new System.EventHandler(this.hacer_pedido);
            // 
            // btnMesa7
            // 
            this.btnMesa7.Location = new System.Drawing.Point(8, 154);
            this.btnMesa7.Name = "btnMesa7";
            this.btnMesa7.Size = new System.Drawing.Size(70, 56);
            this.btnMesa7.TabIndex = 6;
            this.btnMesa7.Text = "Mesa 7";
            this.btnMesa7.Click += new System.EventHandler(this.hacer_pedido);
            // 
            // btnMesa10
            // 
            this.btnMesa10.Location = new System.Drawing.Point(70, 216);
            this.btnMesa10.Name = "btnMesa10";
            this.btnMesa10.Size = new System.Drawing.Size(101, 31);
            this.btnMesa10.TabIndex = 9;
            this.btnMesa10.Text = "Delivery";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Seleccione Mesa";
            // 
            // FrmMesasEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMesa10);
            this.Controls.Add(this.btnMesa9);
            this.Controls.Add(this.btnMesa8);
            this.Controls.Add(this.btnMesa7);
            this.Controls.Add(this.btnMesa6);
            this.Controls.Add(this.btnMesa5);
            this.Controls.Add(this.btnMesa4);
            this.Controls.Add(this.btnMesa3);
            this.Controls.Add(this.btnMesa2);
            this.Controls.Add(this.btnMesa1);
            this.Name = "FrmMesasEstados";
            this.Text = "Estados de Mesa";
            this.GotFocus += new System.EventHandler(this.FrmMesasEstados_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesa1;
        private System.Windows.Forms.Button btnMesa2;
        private System.Windows.Forms.Button btnMesa3;
        private System.Windows.Forms.Button btnMesa6;
        private System.Windows.Forms.Button btnMesa5;
        private System.Windows.Forms.Button btnMesa4;
        private System.Windows.Forms.Button btnMesa9;
        private System.Windows.Forms.Button btnMesa8;
        private System.Windows.Forms.Button btnMesa7;
        private System.Windows.Forms.Button btnMesa10;
        private System.Windows.Forms.Label label1;
    }
}