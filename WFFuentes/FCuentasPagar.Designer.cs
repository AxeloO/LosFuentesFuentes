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
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGCuentasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // bConsulta
            // 
            this.bConsulta.BackColor = System.Drawing.Color.Teal;
            this.bConsulta.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsulta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bConsulta.Location = new System.Drawing.Point(390, 230);
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
            this.bEliminar.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bEliminar.Location = new System.Drawing.Point(390, 174);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(100, 36);
            this.bEliminar.TabIndex = 31;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = false;
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.Teal;
            this.bAgregar.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bAgregar.Location = new System.Drawing.Point(390, 110);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(100, 33);
            this.bAgregar.TabIndex = 30;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre del proveedor";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(161, 96);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(162, 20);
            this.txtNombreProveedor.TabIndex = 28;
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Location = new System.Drawing.Point(161, 285);
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new System.Drawing.Size(162, 20);
            this.txtMontoPagar.TabIndex = 24;
            // 
            // txtProductoAdquirido
            // 
            this.txtProductoAdquirido.Location = new System.Drawing.Point(161, 237);
            this.txtProductoAdquirido.Name = "txtProductoAdquirido";
            this.txtProductoAdquirido.Size = new System.Drawing.Size(162, 20);
            this.txtProductoAdquirido.TabIndex = 23;
            // 
            // txtFechaAdquisicion
            // 
            this.txtFechaAdquisicion.Location = new System.Drawing.Point(161, 187);
            this.txtFechaAdquisicion.Name = "txtFechaAdquisicion";
            this.txtFechaAdquisicion.Size = new System.Drawing.Size(162, 20);
            this.txtFechaAdquisicion.TabIndex = 22;
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(161, 143);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(80, 20);
            this.txtNoFactura.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Monto a pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Producto Adquirido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha de adquisición";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "No. Factura";
            // 
            // dGCuentasPagar
            // 
            this.dGCuentasPagar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGCuentasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGCuentasPagar.Location = new System.Drawing.Point(540, 96);
            this.dGCuentasPagar.Name = "dGCuentasPagar";
            this.dGCuentasPagar.Size = new System.Drawing.Size(506, 182);
            this.dGCuentasPagar.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(131, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 27);
            this.label5.TabIndex = 35;
            this.label5.Text = "Nuevo Registro";
            // 
            // bRegresar
            // 
            this.bRegresar.BackColor = System.Drawing.Color.Teal;
            this.bRegresar.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bRegresar.Location = new System.Drawing.Point(947, 301);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(80, 30);
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
            this.label7.Location = new System.Drawing.Point(667, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 27);
            this.label7.TabIndex = 37;
            this.label7.Text = "Lista cuentas por pagar";
            // 
            // FCuentasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1058, 353);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Label label7;
    }
}