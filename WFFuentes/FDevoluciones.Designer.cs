﻿namespace WFFuentes
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
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.bImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(77, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio Nota de Venta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(77, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(77, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(77, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Causa de Devolución:";
            // 
            // txtFolioNota
            // 
            this.txtFolioNota.Location = new System.Drawing.Point(243, 160);
            this.txtFolioNota.Name = "txtFolioNota";
            this.txtFolioNota.Size = new System.Drawing.Size(76, 20);
            this.txtFolioNota.TabIndex = 4;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(243, 205);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(237, 20);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(240, 252);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtCausaDevolucion
            // 
            this.txtCausaDevolucion.Location = new System.Drawing.Point(240, 291);
            this.txtCausaDevolucion.Name = "txtCausaDevolucion";
            this.txtCausaDevolucion.Size = new System.Drawing.Size(237, 20);
            this.txtCausaDevolucion.TabIndex = 7;
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.Teal;
            this.bAgregar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bAgregar.Location = new System.Drawing.Point(528, 148);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(87, 30);
            this.bAgregar.TabIndex = 8;
            this.bAgregar.Text = "Guardar";
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bConsulta
            // 
            this.bConsulta.BackColor = System.Drawing.Color.Teal;
            this.bConsulta.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsulta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bConsulta.Location = new System.Drawing.Point(1025, 353);
            this.bConsulta.Name = "bConsulta";
            this.bConsulta.Size = new System.Drawing.Size(87, 31);
            this.bConsulta.TabIndex = 9;
            this.bConsulta.Text = "Mostrar";
            this.bConsulta.UseVisualStyleBackColor = false;
            this.bConsulta.Click += new System.EventHandler(this.bConsulta_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.BackColor = System.Drawing.Color.Teal;
            this.bLimpiar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bLimpiar.Location = new System.Drawing.Point(528, 205);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(87, 29);
            this.bLimpiar.TabIndex = 10;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = false;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bRegresar
            // 
            this.bRegresar.BackColor = System.Drawing.Color.Teal;
            this.bRegresar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bRegresar.Location = new System.Drawing.Point(1139, 351);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(85, 35);
            this.bRegresar.TabIndex = 11;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = false;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // dGDevoluciones
            // 
            this.dGDevoluciones.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGDevoluciones.Location = new System.Drawing.Point(702, 125);
            this.dGDevoluciones.Name = "dGDevoluciones";
            this.dGDevoluciones.Size = new System.Drawing.Size(583, 210);
            this.dGDevoluciones.TabIndex = 12;
            this.dGDevoluciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGDevoluciones_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(179, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Registro de Devoluciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(881, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lista de Devoluciones";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ID.Location = new System.Drawing.Point(77, 120);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(36, 23);
            this.ID.TabIndex = 15;
            this.ID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 120);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(58, 20);
            this.txtID.TabIndex = 16;
            // 
            // bImprimir
            // 
            this.bImprimir.BackColor = System.Drawing.Color.Teal;
            this.bImprimir.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bImprimir.Location = new System.Drawing.Point(898, 352);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(102, 31);
            this.bImprimir.TabIndex = 51;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = false;
            // 
            // FDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1330, 440);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button bImprimir;
    }
}