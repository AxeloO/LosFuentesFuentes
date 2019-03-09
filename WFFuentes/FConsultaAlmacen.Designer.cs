namespace WFFuentes
{
    partial class FConsultaAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsultaAlmacen));
            this.bImprimir = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.txtBusquedaProducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgInventario = new System.Windows.Forms.DataGridView();
            this.bRegresar = new System.Windows.Forms.Button();
            this.bVistaprevia = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // bImprimir
            // 
            this.bImprimir.BackColor = System.Drawing.Color.Teal;
            this.bImprimir.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bImprimir.Location = new System.Drawing.Point(648, 699);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(90, 34);
            this.bImprimir.TabIndex = 61;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = false;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.BackColor = System.Drawing.Color.Teal;
            this.bActualizar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActualizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bActualizar.Location = new System.Drawing.Point(761, 699);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(91, 34);
            this.bActualizar.TabIndex = 60;
            this.bActualizar.Text = "Mostrar";
            this.bActualizar.UseVisualStyleBackColor = false;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // txtBusquedaProducto
            // 
            this.txtBusquedaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaProducto.Location = new System.Drawing.Point(279, 110);
            this.txtBusquedaProducto.Name = "txtBusquedaProducto";
            this.txtBusquedaProducto.Size = new System.Drawing.Size(433, 22);
            this.txtBusquedaProducto.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(90, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 23);
            this.label11.TabIndex = 58;
            this.label11.Text = "Búsqueda por nombre:";
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.Teal;
            this.bBuscar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bBuscar.Location = new System.Drawing.Point(759, 102);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(97, 37);
            this.bBuscar.TabIndex = 57;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 62;
            this.label1.Text = "Producto en almacen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgInventario
            // 
            this.dgInventario.AllowUserToAddRows = false;
            this.dgInventario.AllowUserToDeleteRows = false;
            this.dgInventario.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventario.Location = new System.Drawing.Point(37, 162);
            this.dgInventario.Name = "dgInventario";
            this.dgInventario.ReadOnly = true;
            this.dgInventario.Size = new System.Drawing.Size(957, 506);
            this.dgInventario.TabIndex = 63;
            // 
            // bRegresar
            // 
            this.bRegresar.BackColor = System.Drawing.Color.Teal;
            this.bRegresar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bRegresar.Location = new System.Drawing.Point(873, 699);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(91, 34);
            this.bRegresar.TabIndex = 64;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = false;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // bVistaprevia
            // 
            this.bVistaprevia.BackColor = System.Drawing.Color.Teal;
            this.bVistaprevia.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVistaprevia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bVistaprevia.Location = new System.Drawing.Point(507, 699);
            this.bVistaprevia.Name = "bVistaprevia";
            this.bVistaprevia.Size = new System.Drawing.Size(121, 34);
            this.bVistaprevia.TabIndex = 65;
            this.bVistaprevia.Text = "Vista Previa";
            this.bVistaprevia.UseVisualStyleBackColor = false;
            this.bVistaprevia.Click += new System.EventHandler(this.bVistaprevia_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FConsultaAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1029, 758);
            this.Controls.Add(this.bVistaprevia);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.dgInventario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.txtBusquedaProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bBuscar);
            this.Name = "FConsultaAlmacen";
            this.Load += new System.EventHandler(this.FConsultaAlmacen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FConsultaAlmacen_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.TextBox txtBusquedaProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgInventario;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.Button bVistaprevia;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}