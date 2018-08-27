namespace WFFuentes
{
    partial class FCuentasPagar
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
            this.bActualizar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvVerLista = new System.Windows.Forms.ListView();
            this.idproveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Monto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
            this.txtProductoAdquirido = new System.Windows.Forms.TextBox();
            this.txtFechaAdquisicion = new System.Windows.Forms.TextBox();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(707, 439);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(81, 33);
            this.bActualizar.TabIndex = 33;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(574, 283);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 32;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(615, 164);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 36);
            this.bEliminar.TabIndex = 31;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(615, 103);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 33);
            this.bAgregar.TabIndex = 30;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre del proveedor";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(196, 43);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(162, 20);
            this.txtNombreProveedor.TabIndex = 28;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(215, 285);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(321, 20);
            this.txtBusqueda.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Busqueda por proveedor";
            // 
            // lvVerLista
            // 
            this.lvVerLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idproveedor,
            this.proveedor,
            this.FechaEntrada,
            this.producto,
            this.Monto});
            this.lvVerLista.Location = new System.Drawing.Point(61, 326);
            this.lvVerLista.Name = "lvVerLista";
            this.lvVerLista.Size = new System.Drawing.Size(703, 97);
            this.lvVerLista.TabIndex = 25;
            this.lvVerLista.UseCompatibleStateImageBehavior = false;
            this.lvVerLista.View = System.Windows.Forms.View.Details;
            // 
            // idproveedor
            // 
            this.idproveedor.Text = "IdProveedor";
            this.idproveedor.Width = 76;
            // 
            // proveedor
            // 
            this.proveedor.Text = "Nombre del Proveedor";
            this.proveedor.Width = 142;
            // 
            // FechaEntrada
            // 
            this.FechaEntrada.Text = "Fecha de aquisición";
            this.FechaEntrada.Width = 119;
            // 
            // producto
            // 
            this.producto.Text = "Producto Adquirido";
            this.producto.Width = 175;
            // 
            // Monto
            // 
            this.Monto.Text = "Monto total a pagar";
            this.Monto.Width = 117;
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Location = new System.Drawing.Point(196, 232);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new System.Drawing.Size(162, 20);
            this.txtMontoPagar.TabIndex = 24;
            // 
            // txtProductoAdquirido
            // 
            this.txtProductoAdquirido.Location = new System.Drawing.Point(196, 184);
            this.txtProductoAdquirido.Name = "txtProductoAdquirido";
            this.txtProductoAdquirido.Size = new System.Drawing.Size(162, 20);
            this.txtProductoAdquirido.TabIndex = 23;
            // 
            // txtFechaAdquisicion
            // 
            this.txtFechaAdquisicion.Location = new System.Drawing.Point(196, 134);
            this.txtFechaAdquisicion.Name = "txtFechaAdquisicion";
            this.txtFechaAdquisicion.Size = new System.Drawing.Size(162, 20);
            this.txtFechaAdquisicion.TabIndex = 22;
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(196, 90);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(80, 20);
            this.txtNoFactura.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Monto a pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Producto Adquirido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha de adquisición";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "No. Factura";
            // 
            // FCuentasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(826, 484);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvVerLista);
            this.Controls.Add(this.txtMontoPagar);
            this.Controls.Add(this.txtProductoAdquirido);
            this.Controls.Add(this.txtFechaAdquisicion);
            this.Controls.Add(this.txtNoFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FCuentasPagar";
            this.Text = "FCuentasPagar";
            this.Load += new System.EventHandler(this.FCuentasPagar_Load);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvVerLista;
        private System.Windows.Forms.ColumnHeader idproveedor;
        private System.Windows.Forms.ColumnHeader proveedor;
        private System.Windows.Forms.ColumnHeader FechaEntrada;
        private System.Windows.Forms.ColumnHeader producto;
        private System.Windows.Forms.ColumnHeader Monto;
        private System.Windows.Forms.TextBox txtMontoPagar;
        private System.Windows.Forms.TextBox txtProductoAdquirido;
        private System.Windows.Forms.TextBox txtFechaAdquisicion;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}