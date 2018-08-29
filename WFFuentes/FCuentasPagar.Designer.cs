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
            this.bConsulta = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dGCuentasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // bConsulta
            // 
            this.bConsulta.Location = new System.Drawing.Point(390, 230);
            this.bConsulta.Name = "bConsulta";
            this.bConsulta.Size = new System.Drawing.Size(100, 33);
            this.bConsulta.TabIndex = 33;
            this.bConsulta.Text = "Consultar";
            this.bConsulta.UseVisualStyleBackColor = true;
            this.bConsulta.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(390, 174);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 36);
            this.bEliminar.TabIndex = 31;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(390, 113);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 33);
            this.bAgregar.TabIndex = 30;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre del proveedor";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(150, 96);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(162, 20);
            this.txtNombreProveedor.TabIndex = 28;
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Location = new System.Drawing.Point(150, 285);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new System.Drawing.Size(162, 20);
            this.txtMontoPagar.TabIndex = 24;
            // 
            // txtProductoAdquirido
            // 
            this.txtProductoAdquirido.Location = new System.Drawing.Point(150, 237);
            this.txtProductoAdquirido.Name = "txtProductoAdquirido";
            this.txtProductoAdquirido.Size = new System.Drawing.Size(162, 20);
            this.txtProductoAdquirido.TabIndex = 23;
            // 
            // txtFechaAdquisicion
            // 
            this.txtFechaAdquisicion.Location = new System.Drawing.Point(150, 187);
            this.txtFechaAdquisicion.Name = "txtFechaAdquisicion";
            this.txtFechaAdquisicion.Size = new System.Drawing.Size(162, 20);
            this.txtFechaAdquisicion.TabIndex = 22;
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(150, 143);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(80, 20);
            this.txtNoFactura.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Monto a pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Producto Adquirido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha de adquisición";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "No. Factura";
            // 
            // dGCuentasPagar
            // 
            this.dGCuentasPagar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGCuentasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGCuentasPagar.Location = new System.Drawing.Point(546, 36);
            this.dGCuentasPagar.Name = "dGCuentasPagar";
            this.dGCuentasPagar.Size = new System.Drawing.Size(367, 313);
            this.dGCuentasPagar.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(131, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nuevo Registro";
            // 
            // bRegresar
            // 
            this.bRegresar.Location = new System.Drawing.Point(817, 376);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(80, 30);
            this.bRegresar.TabIndex = 36;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = true;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // FCuentasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 430);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGCuentasPagar);
            this.Controls.Add(this.bConsulta);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.txtMontoPagar);
            this.Controls.Add(this.txtProductoAdquirido);
            this.Controls.Add(this.txtFechaAdquisicion);
            this.Controls.Add(this.txtNoFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCuentasPagar";
            this.Text = "FCuentasPagar";
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
        private System.Windows.Forms.TextBox txtMontoPagar;
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
    }
}