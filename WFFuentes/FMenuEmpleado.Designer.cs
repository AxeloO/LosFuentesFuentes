namespace WFFuentes
{
    partial class FMenuEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenuEmpleado));
            this.pMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.bConsultaCliente = new System.Windows.Forms.Button();
            this.bDevolucion = new System.Windows.Forms.Button();
            this.bConsultaAlmacen = new System.Windows.Forms.Button();
            this.bVentas = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pMenu.Controls.Add(this.bConsultaCliente);
            this.pMenu.Controls.Add(this.bDevolucion);
            this.pMenu.Controls.Add(this.bConsultaAlmacen);
            this.pMenu.Controls.Add(this.bVentas);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(200, 539);
            this.pMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(334, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Los Fuentes Fuentes S. P. R. de R. L. ";
            // 
            // pLogo
            // 
            this.pLogo.Image = global::WFFuentes.Properties.Resources.LosFuentes;
            this.pLogo.InitialImage = global::WFFuentes.Properties.Resources.LosFuentes;
            this.pLogo.Location = new System.Drawing.Point(275, 91);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(614, 394);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pLogo.TabIndex = 6;
            this.pLogo.TabStop = false;
         
            // 
            // bConsultaCliente
            // 
            this.bConsultaCliente.BackgroundImage = global::WFFuentes.Properties.Resources.depositphotos_131533544_stock_photo_clients_group_icon_white_square;
            this.bConsultaCliente.FlatAppearance.BorderSize = 0;
            this.bConsultaCliente.Image = global::WFFuentes.Properties.Resources.depositphotos_131533544_stock_photo_clients_group_icon_white_square;
            this.bConsultaCliente.Location = new System.Drawing.Point(40, 397);
            this.bConsultaCliente.Name = "bConsultaCliente";
            this.bConsultaCliente.Size = new System.Drawing.Size(100, 104);
            this.bConsultaCliente.TabIndex = 3;
            this.bConsultaCliente.UseVisualStyleBackColor = true;
            this.bConsultaCliente.Click += new System.EventHandler(this.bConsultaCliente_Click);
            // 
            // bDevolucion
            // 
            this.bDevolucion.FlatAppearance.BorderSize = 0;
            this.bDevolucion.Image = global::WFFuentes.Properties.Resources.devolucion;
            this.bDevolucion.Location = new System.Drawing.Point(40, 287);
            this.bDevolucion.Name = "bDevolucion";
            this.bDevolucion.Size = new System.Drawing.Size(100, 87);
            this.bDevolucion.TabIndex = 2;
            this.bDevolucion.UseVisualStyleBackColor = true;
            this.bDevolucion.Click += new System.EventHandler(this.bDevolucion_Click);
            // 
            // bConsultaAlmacen
            // 
            this.bConsultaAlmacen.BackgroundImage = global::WFFuentes.Properties.Resources.images;
            this.bConsultaAlmacen.FlatAppearance.BorderSize = 0;
            this.bConsultaAlmacen.Image = global::WFFuentes.Properties.Resources.images;
            this.bConsultaAlmacen.Location = new System.Drawing.Point(40, 162);
            this.bConsultaAlmacen.Name = "bConsultaAlmacen";
            this.bConsultaAlmacen.Size = new System.Drawing.Size(100, 87);
            this.bConsultaAlmacen.TabIndex = 1;
            this.bConsultaAlmacen.UseVisualStyleBackColor = true;
            this.bConsultaAlmacen.Click += new System.EventHandler(this.bConsultaAlmacen_Click);
            // 
            // bVentas
            // 
            this.bVentas.FlatAppearance.BorderSize = 0;
            this.bVentas.Image = ((System.Drawing.Image)(resources.GetObject("bVentas.Image")));
            this.bVentas.Location = new System.Drawing.Point(40, 38);
            this.bVentas.Name = "bVentas";
            this.bVentas.Size = new System.Drawing.Size(100, 87);
            this.bVentas.TabIndex = 0;
            this.bVentas.UseVisualStyleBackColor = true;
            this.bVentas.Click += new System.EventHandler(this.bVentas_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(833, 504);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 7;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // FMenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 539);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMenuEmpleado";
            this.Text = "FMenuEmpleado";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMenuEmpleado_MouseDown);
            this.pMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button bVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bConsultaCliente;
        private System.Windows.Forms.Button bDevolucion;
        private System.Windows.Forms.Button bConsultaAlmacen;
        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.Button bSalir;
    }
}