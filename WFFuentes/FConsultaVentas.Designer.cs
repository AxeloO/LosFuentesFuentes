namespace WFFuentes
{
    partial class FConsultaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsultaVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.dgVentas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaI = new System.Windows.Forms.TextBox();
            this.txtFechaF = new System.Windows.Forms.TextBox();
            this.bRegresar = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.bImprimir = new System.Windows.Forms.Button();
            this.btVistaPrevia = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(458, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(669, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consultar Ventas por Fecha Inicio o Fecha Final, la primera tendra prioridad de b" +
    "usqueda";
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.Teal;
            this.bBuscar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bBuscar.Location = new System.Drawing.Point(740, 128);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(86, 30);
            this.bBuscar.TabIndex = 3;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // dgVentas
            // 
            this.dgVentas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVentas.Location = new System.Drawing.Point(79, 171);
            this.dgVentas.Name = "dgVentas";
            this.dgVentas.Size = new System.Drawing.Size(996, 190);
            this.dgVentas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha final";
            // 
            // txtFechaI
            // 
            this.txtFechaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaI.Location = new System.Drawing.Point(368, 132);
            this.txtFechaI.Name = "txtFechaI";
            this.txtFechaI.Size = new System.Drawing.Size(106, 22);
            this.txtFechaI.TabIndex = 7;
            // 
            // txtFechaF
            // 
            this.txtFechaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaF.Location = new System.Drawing.Point(604, 132);
            this.txtFechaF.Name = "txtFechaF";
            this.txtFechaF.Size = new System.Drawing.Size(92, 22);
            this.txtFechaF.TabIndex = 8;
            // 
            // bRegresar
            // 
            this.bRegresar.BackColor = System.Drawing.Color.Teal;
            this.bRegresar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bRegresar.Location = new System.Drawing.Point(1011, 397);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(102, 30);
            this.bRegresar.TabIndex = 9;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = false;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.BackColor = System.Drawing.Color.Teal;
            this.bActualizar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bActualizar.Location = new System.Drawing.Point(875, 397);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(101, 30);
            this.bActualizar.TabIndex = 10;
            this.bActualizar.Text = "Mostrar";
            this.bActualizar.UseVisualStyleBackColor = false;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bImprimir
            // 
            this.bImprimir.BackColor = System.Drawing.Color.Teal;
            this.bImprimir.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bImprimir.Location = new System.Drawing.Point(744, 396);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(102, 31);
            this.bImprimir.TabIndex = 51;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = false;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // btVistaPrevia
            // 
            this.btVistaPrevia.BackColor = System.Drawing.Color.Teal;
            this.btVistaPrevia.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVistaPrevia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btVistaPrevia.Location = new System.Drawing.Point(591, 396);
            this.btVistaPrevia.Name = "btVistaPrevia";
            this.btVistaPrevia.Size = new System.Drawing.Size(121, 31);
            this.btVistaPrevia.TabIndex = 52;
            this.btVistaPrevia.Text = "Vista Previa";
            this.btVistaPrevia.UseVisualStyleBackColor = false;
            this.btVistaPrevia.Click += new System.EventHandler(this.btVistaPrevia_Click);
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
            // FConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1154, 469);
            this.Controls.Add(this.btVistaPrevia);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.txtFechaF);
            this.Controls.Add(this.txtFechaI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgVentas);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FConsultaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FConsultaVentas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.DataGridView dgVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaI;
        private System.Windows.Forms.TextBox txtFechaF;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.Button btVistaPrevia;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}