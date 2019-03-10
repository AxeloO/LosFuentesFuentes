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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCuentasPagar));
            this.bConsulta = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProductoAdquirido = new System.Windows.Forms.TextBox();
            this.txtFechaAdquisicion = new System.Windows.Forms.TextBox();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGCuentasPagar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.bRegresar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bModificar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.bImprimir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btVistaPrevia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGCuentasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // bConsulta
            // 
            this.bConsulta.BackColor = System.Drawing.Color.Teal;
            this.bConsulta.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsulta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bConsulta.Location = new System.Drawing.Point(1186, 714);
            this.bConsulta.Name = "bConsulta";
            this.bConsulta.Size = new System.Drawing.Size(100, 33);
            this.bConsulta.TabIndex = 33;
            this.bConsulta.Text = "Consultar";
            this.bConsulta.UseVisualStyleBackColor = false;
            this.bConsulta.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.Teal;
            this.bEliminar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bEliminar.Location = new System.Drawing.Point(478, 358);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 36);
            this.bEliminar.TabIndex = 31;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.Teal;
            this.bAgregar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bAgregar.Location = new System.Drawing.Point(478, 232);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 39);
            this.bAgregar.TabIndex = 30;
            this.bAgregar.Text = "Guardar";
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre del proveedor:";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(247, 184);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(162, 22);
            this.txtNombreProveedor.TabIndex = 28;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(247, 373);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(80, 22);
            this.txtCantidad.TabIndex = 24;
            // 
            // txtProductoAdquirido
            // 
            this.txtProductoAdquirido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoAdquirido.Location = new System.Drawing.Point(247, 325);
            this.txtProductoAdquirido.Name = "txtProductoAdquirido";
            this.txtProductoAdquirido.Size = new System.Drawing.Size(162, 22);
            this.txtProductoAdquirido.TabIndex = 23;
            // 
            // txtFechaAdquisicion
            // 
            this.txtFechaAdquisicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAdquisicion.Location = new System.Drawing.Point(247, 275);
            this.txtFechaAdquisicion.Name = "txtFechaAdquisicion";
            this.txtFechaAdquisicion.Size = new System.Drawing.Size(162, 22);
            this.txtFechaAdquisicion.TabIndex = 22;
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoFactura.Location = new System.Drawing.Point(247, 231);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(80, 22);
            this.txtNoFactura.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Monto a pagar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Producto Adquirido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha de adquisición:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "No. Factura:";
            // 
            // dGCuentasPagar
            // 
            this.dGCuentasPagar.AllowUserToAddRows = false;
            this.dGCuentasPagar.AllowUserToDeleteRows = false;
            this.dGCuentasPagar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGCuentasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGCuentasPagar.Location = new System.Drawing.Point(605, 169);
            this.dGCuentasPagar.Name = "dGCuentasPagar";
            this.dGCuentasPagar.ReadOnly = true;
            this.dGCuentasPagar.Size = new System.Drawing.Size(806, 517);
            this.dGCuentasPagar.TabIndex = 34;
            this.dGCuentasPagar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGCuentasPagar_CellClick);
            this.dGCuentasPagar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGCuentasPagar_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(178, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 27);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nuevo Registro";
            // 
            // bRegresar
            // 
            this.bRegresar.BackColor = System.Drawing.Color.Teal;
            this.bRegresar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bRegresar.Location = new System.Drawing.Point(1307, 714);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(100, 33);
            this.bRegresar.TabIndex = 36;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = false;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(871, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 27);
            this.label7.TabIndex = 37;
            this.label7.Text = "Lista cuentas por pagar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(141, 142);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(61, 22);
            this.txtID.TabIndex = 39;
            // 
            // bModificar
            // 
            this.bModificar.BackColor = System.Drawing.Color.Teal;
            this.bModificar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bModificar.Location = new System.Drawing.Point(478, 297);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(100, 38);
            this.bModificar.TabIndex = 40;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.Teal;
            this.bBuscar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bBuscar.Location = new System.Drawing.Point(1174, 123);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(89, 32);
            this.bBuscar.TabIndex = 41;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(664, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "Búsqueda por nombre:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(839, 129);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(307, 22);
            this.txtBusqueda.TabIndex = 43;
            // 
            // bImprimir
            // 
            this.bImprimir.BackColor = System.Drawing.Color.Teal;
            this.bImprimir.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bImprimir.Location = new System.Drawing.Point(1059, 714);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(102, 31);
            this.bImprimir.TabIndex = 51;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = false;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 23);
            this.label10.TabIndex = 52;
            this.label10.Text = "Cantidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(37, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 23);
            this.label11.TabIndex = 53;
            this.label11.Text = "Status de Factura:";
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPagar.Location = new System.Drawing.Point(247, 419);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new System.Drawing.Size(162, 22);
            this.txtMontoPagar.TabIndex = 54;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(247, 463);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(162, 22);
            this.txtStatus.TabIndex = 55;
            // 
            // bLimpiar
            // 
            this.bLimpiar.BackColor = System.Drawing.Color.Teal;
            this.bLimpiar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bLimpiar.Location = new System.Drawing.Point(478, 416);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(100, 36);
            this.bLimpiar.TabIndex = 56;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = false;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btVistaPrevia
            // 
            this.btVistaPrevia.BackColor = System.Drawing.Color.Teal;
            this.btVistaPrevia.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVistaPrevia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btVistaPrevia.Location = new System.Drawing.Point(920, 714);
            this.btVistaPrevia.Name = "btVistaPrevia";
            this.btVistaPrevia.Size = new System.Drawing.Size(110, 31);
            this.btVistaPrevia.TabIndex = 57;
            this.btVistaPrevia.Text = "Vista Previa";
            this.btVistaPrevia.UseVisualStyleBackColor = false;
            this.btVistaPrevia.Click += new System.EventHandler(this.btVistaPrevia_Click);
            // 
            // FCuentasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1444, 782);
            this.Controls.Add(this.btVistaPrevia);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtMontoPagar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGCuentasPagar);
            this.Controls.Add(this.bConsulta);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProductoAdquirido);
            this.Controls.Add(this.txtFechaAdquisicion);
            this.Controls.Add(this.txtNoFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FCuentasPagar";
            this.Load += new System.EventHandler(this.FCuentasPagar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FCuentasPagar_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dGCuentasPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConsulta;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProductoAdquirido;
        private System.Windows.Forms.TextBox txtFechaAdquisicion;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGCuentasPagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMontoPagar;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button bLimpiar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btVistaPrevia;
    }
}