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
            this.bSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRegistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoRegistroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoRegistroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorPagarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(468, 430);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(77, 25);
            this.bSalir.TabIndex = 0;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(597, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 28);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFFuentes.Properties.Resources.LosFuentes;
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.cuentasPorPagarToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.registroToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroToolStripMenuItem.Image = global::WFFuentes.Properties.Resources.im5;
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarRegistroToolStripMenuItem,
            this.eliminarRegistroToolStripMenuItem,
            this.modificarRegistroToolStripMenuItem});
            this.clientesToolStripMenuItem.Image = global::WFFuentes.Properties.Resources.usuario;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarRegistroToolStripMenuItem
            // 
            this.agregarRegistroToolStripMenuItem.Image = global::WFFuentes.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.agregarRegistroToolStripMenuItem.Name = "agregarRegistroToolStripMenuItem";
            this.agregarRegistroToolStripMenuItem.Size = new System.Drawing.Size(239, 28);
            this.agregarRegistroToolStripMenuItem.Text = "Agregar Registro";
            this.agregarRegistroToolStripMenuItem.Click += new System.EventHandler(this.agregarRegistroToolStripMenuItem_Click);
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Image = global::WFFuentes.Properties.Resources.delete_delete_deleteusers_delete_male_user_maleclient_2348;
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(239, 28);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            this.eliminarRegistroToolStripMenuItem.Click += new System.EventHandler(this.eliminarRegistroToolStripMenuItem_Click);
            // 
            // modificarRegistroToolStripMenuItem
            // 
            this.modificarRegistroToolStripMenuItem.Image = global::WFFuentes.Properties.Resources.if_Edit_Male_User_49585;
            this.modificarRegistroToolStripMenuItem.Name = "modificarRegistroToolStripMenuItem";
            this.modificarRegistroToolStripMenuItem.Size = new System.Drawing.Size(239, 28);
            this.modificarRegistroToolStripMenuItem.Text = "Modificar Registro";
            this.modificarRegistroToolStripMenuItem.Click += new System.EventHandler(this.modificarRegistroToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoRegistroToolStripMenuItem,
            this.consultarRegistroToolStripMenuItem,
            this.modificarRegistroToolStripMenuItem1});
            this.proveedoresToolStripMenuItem.Image = global::WFFuentes.Properties.Resources.proveedores_icono_png_3;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // agregarNuevoRegistroToolStripMenuItem
            // 
            this.agregarNuevoRegistroToolStripMenuItem.Name = "agregarNuevoRegistroToolStripMenuItem";
            this.agregarNuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.agregarNuevoRegistroToolStripMenuItem.Text = "Agregar nuevo registro";
            // 
            // consultarRegistroToolStripMenuItem
            // 
            this.consultarRegistroToolStripMenuItem.Name = "consultarRegistroToolStripMenuItem";
            this.consultarRegistroToolStripMenuItem.Size = new System.Drawing.Size(278, 28);
            this.consultarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            // 
            // modificarRegistroToolStripMenuItem1
            // 
            this.modificarRegistroToolStripMenuItem1.Name = "modificarRegistroToolStripMenuItem1";
            this.modificarRegistroToolStripMenuItem1.Size = new System.Drawing.Size(278, 28);
            this.modificarRegistroToolStripMenuItem1.Text = "Modificar Registro";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoRegistroToolStripMenuItem1});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarNuevoRegistroToolStripMenuItem1
            // 
            this.agregarNuevoRegistroToolStripMenuItem1.Name = "agregarNuevoRegistroToolStripMenuItem1";
            this.agregarNuevoRegistroToolStripMenuItem1.Size = new System.Drawing.Size(283, 28);
            this.agregarNuevoRegistroToolStripMenuItem1.Text = "Agregar Nuevo Registro";
            // 
            // cuentasPorPagarToolStripMenuItem
            // 
            this.cuentasPorPagarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoRegistroToolStripMenuItem2});
            this.cuentasPorPagarToolStripMenuItem.Name = "cuentasPorPagarToolStripMenuItem";
            this.cuentasPorPagarToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.cuentasPorPagarToolStripMenuItem.Text = "Cuentas por pagar";
            // 
            // agregarNuevoRegistroToolStripMenuItem2
            // 
            this.agregarNuevoRegistroToolStripMenuItem2.Name = "agregarNuevoRegistroToolStripMenuItem2";
            this.agregarNuevoRegistroToolStripMenuItem2.Size = new System.Drawing.Size(283, 28);
            this.agregarNuevoRegistroToolStripMenuItem2.Text = "Agregar Nuevo Registro";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeToolStripMenuItem,
            this.listaDeProveedoresToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.cuentasPorPagarToolStripMenuItem1});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Image = global::WFFuentes.Properties.Resources.icono_de_la_búsqueda_355819;
            this.consultasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(120, 28);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listaDeToolStripMenuItem
            // 
            this.listaDeToolStripMenuItem.Name = "listaDeToolStripMenuItem";
            this.listaDeToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.listaDeToolStripMenuItem.Text = "Lista de Clientes";
            // 
            // listaDeProveedoresToolStripMenuItem
            // 
            this.listaDeProveedoresToolStripMenuItem.Name = "listaDeProveedoresToolStripMenuItem";
            this.listaDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.listaDeProveedoresToolStripMenuItem.Text = "Lista de Proveedores";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.inventarioToolStripMenuItem.Text = "Productos en Almacen ";
            // 
            // cuentasPorPagarToolStripMenuItem1
            // 
            this.cuentasPorPagarToolStripMenuItem1.Name = "cuentasPorPagarToolStripMenuItem1";
            this.cuentasPorPagarToolStripMenuItem1.Size = new System.Drawing.Size(275, 28);
            this.cuentasPorPagarToolStripMenuItem1.Text = "Cuentas por Pagar";
            // 
            // FMenuClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(597, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenuClientes";
            this.Text = "FMenuClientes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FMenuClientes_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoRegistroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoRegistroToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorPagarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroToolStripMenuItem1;
    }
}