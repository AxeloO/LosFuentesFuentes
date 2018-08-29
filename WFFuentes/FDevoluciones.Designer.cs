namespace WFFuentes
{
    partial class FDevoluciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFolioNota = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCausaDevolucion = new System.Windows.Forms.TextBox();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bConsulta = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bRegresar = new System.Windows.Forms.Button();
            this.dGDevoluciones = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio Nota de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Causa de Devolución";
            // 
            // txtFolioNota
            // 
            this.txtFolioNota.Location = new System.Drawing.Point(222, 103);
            this.txtFolioNota.Name = "txtFolioNota";
            this.txtFolioNota.Size = new System.Drawing.Size(76, 20);
            this.txtFolioNota.TabIndex = 4;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(222, 159);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(237, 20);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(222, 212);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtCausaDevolucion
            // 
            this.txtCausaDevolucion.Location = new System.Drawing.Point(222, 273);
            this.txtCausaDevolucion.Name = "txtCausaDevolucion";
            this.txtCausaDevolucion.Size = new System.Drawing.Size(237, 20);
            this.txtCausaDevolucion.TabIndex = 7;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(529, 128);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(119, 23);
            this.bAgregar.TabIndex = 8;
            this.bAgregar.Text = "Generar Devolución";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bConsulta
            // 
            this.bConsulta.Location = new System.Drawing.Point(529, 179);
            this.bConsulta.Name = "bConsulta";
            this.bConsulta.Size = new System.Drawing.Size(75, 23);
            this.bConsulta.TabIndex = 9;
            this.bConsulta.Text = "Consultar";
            this.bConsulta.UseVisualStyleBackColor = true;
            this.bConsulta.Click += new System.EventHandler(this.bConsulta_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(529, 227);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 10;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bRegresar
            // 
            this.bRegresar.Location = new System.Drawing.Point(895, 402);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(75, 23);
            this.bRegresar.TabIndex = 11;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = true;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // dGDevoluciones
            // 
            this.dGDevoluciones.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGDevoluciones.Location = new System.Drawing.Point(692, 33);
            this.dGDevoluciones.Name = "dGDevoluciones";
            this.dGDevoluciones.Size = new System.Drawing.Size(309, 349);
            this.dGDevoluciones.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(256, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Registro de Devoluciones";
            // 
            // FDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1033, 449);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGDevoluciones);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bConsulta);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.txtCausaDevolucion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtFolioNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDevoluciones";
            this.Text = "FDevoluciones";
            this.Load += new System.EventHandler(this.FDevoluciones_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FDevoluciones_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dGDevoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolioNota;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCausaDevolucion;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bConsulta;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.DataGridView dGDevoluciones;
        private System.Windows.Forms.Label label5;
    }
}