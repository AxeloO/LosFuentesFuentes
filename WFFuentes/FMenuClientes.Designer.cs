namespace WFFuentes
{
    partial class FMenuClientes
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
            this.MenuPrincipal = new System.Windows.Forms.Panel();
            this.bClientes = new System.Windows.Forms.Button();
            this.bCompras = new System.Windows.Forms.Button();
            this.bProductos = new System.Windows.Forms.Button();
            this.bUsuarios = new System.Windows.Forms.Button();
            this.bProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSalir = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.BackColor = System.Drawing.Color.Teal;
            this.MenuPrincipal.Controls.Add(this.bClientes);
            this.MenuPrincipal.Controls.Add(this.bCompras);
            this.MenuPrincipal.Controls.Add(this.bProductos);
            this.MenuPrincipal.Controls.Add(this.bUsuarios);
            this.MenuPrincipal.Controls.Add(this.bProveedor);
            this.MenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(163, 620);
            this.MenuPrincipal.TabIndex = 6;
            this.MenuPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipal_MouseDown);
            // 
            // bClientes
            // 
            this.bClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bClientes.FlatAppearance.BorderSize = 0;
            this.bClientes.ForeColor = System.Drawing.Color.Transparent;
            this.bClientes.Image = global::WFFuentes.Properties.Resources.clientes11;
            this.bClientes.Location = new System.Drawing.Point(31, 19);
            this.bClientes.Name = "bClientes";
            this.bClientes.Size = new System.Drawing.Size(103, 92);
            this.bClientes.TabIndex = 6;
            this.bClientes.UseVisualStyleBackColor = true;
            this.bClientes.Click += new System.EventHandler(this.bClientes_Click);
            // 
            // bCompras
            // 
            this.bCompras.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bCompras.Image = global::WFFuentes.Properties.Resources.icono_compras_sl_11;
            this.bCompras.Location = new System.Drawing.Point(31, 490);
            this.bCompras.Name = "bCompras";
            this.bCompras.Size = new System.Drawing.Size(103, 92);
            this.bCompras.TabIndex = 9;
            this.bCompras.UseVisualStyleBackColor = true;
            this.bCompras.Click += new System.EventHandler(this.bCompras_Click);
            // 
            // bProductos
            // 
            this.bProductos.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bProductos.Image = global::WFFuentes.Properties.Resources.Icono_producto2;
            this.bProductos.Location = new System.Drawing.Point(31, 366);
            this.bProductos.Name = "bProductos";
            this.bProductos.Size = new System.Drawing.Size(103, 92);
            this.bProductos.TabIndex = 8;
            this.bProductos.Text = "Productos";
            this.bProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bProductos.UseVisualStyleBackColor = true;
            this.bProductos.Click += new System.EventHandler(this.bProductos_Click);
            // 
            // bUsuarios
            // 
            this.bUsuarios.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bUsuarios.Image = global::WFFuentes.Properties.Resources.usuario1;
            this.bUsuarios.Location = new System.Drawing.Point(31, 252);
            this.bUsuarios.Name = "bUsuarios";
            this.bUsuarios.Size = new System.Drawing.Size(103, 86);
            this.bUsuarios.TabIndex = 7;
            this.bUsuarios.Text = "Usuarios";
            this.bUsuarios.UseVisualStyleBackColor = true;
            this.bUsuarios.Click += new System.EventHandler(this.bUsuarios_Click);
            // 
            // bProveedor
            // 
            this.bProveedor.FlatAppearance.BorderSize = 0;
            this.bProveedor.Image = global::WFFuentes.Properties.Resources.proveedor2;
            this.bProveedor.Location = new System.Drawing.Point(31, 134);
            this.bProveedor.Name = "bProveedor";
            this.bProveedor.Size = new System.Drawing.Size(103, 92);
            this.bProveedor.TabIndex = 4;
            this.bProveedor.UseVisualStyleBackColor = true;
            this.bProveedor.Click += new System.EventHandler(this.bProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(128, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Los Fuentes Fuentes S. P. R. de R. L. ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bSalir);
            this.panel1.Controls.Add(this.pLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(163, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 620);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(573, 566);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 5;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // pLogo
            // 
            this.pLogo.Image = global::WFFuentes.Properties.Resources.LosFuentes;
            this.pLogo.InitialImage = global::WFFuentes.Properties.Resources.LosFuentes;
            this.pLogo.Location = new System.Drawing.Point(49, 134);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(603, 394);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pLogo.TabIndex = 2;
            this.pLogo.TabStop = false;
            this.pLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // FMenuClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(876, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMenuClientes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMenuClientes_MouseDown);
            this.MenuPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.Button bProveedor;
        private System.Windows.Forms.Panel MenuPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bProductos;
        private System.Windows.Forms.Button bUsuarios;
        private System.Windows.Forms.Button bClientes;
        private System.Windows.Forms.Button bCompras;
        private System.Windows.Forms.Button bSalir;
    }
}