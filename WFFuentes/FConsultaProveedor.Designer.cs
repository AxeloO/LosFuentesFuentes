namespace WFFuentes
{
    partial class FConsultaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConsultaProveedor));
            this.bActualizar = new System.Windows.Forms.Button();
            this.bBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bRegresar = new System.Windows.Forms.Button();
            this.dgProveedores = new System.Windows.Forms.DataGridView();
            this.bVistaprevia = new System.Windows.Forms.Button();
            this.bImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // bActualizar
            // 
            this.bActualizar.BackColor = System.Drawing.Color.Teal;
            this.bActualizar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActualizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bActualizar.Location = new System.Drawing.Point(750, 719);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(88, 34);
            this.bActualizar.TabIndex = 48;
            this.bActualizar.Text = "Mostrar";
            this.bActualizar.UseVisualStyleBackColor = false;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bBusqueda
            // 
            this.bBusqueda.BackColor = System.Drawing.Color.Teal;
            this.bBusqueda.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBusqueda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bBusqueda.Location = new System.Drawing.Point(750, 107);
            this.bBusqueda.Name = "bBusqueda";
            this.bBusqueda.Size = new System.Drawing.Size(88, 32);
            this.bBusqueda.TabIndex = 46;
            this.bBusqueda.Text = "Buscar";
            this.bBusqueda.UseVisualStyleBackColor = false;
            this.bBusqueda.Click += new System.EventHandler(this.bBusqueda_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(305, 111);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(406, 24);
            this.txtBusqueda.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "Búsqueda por Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 49;
            this.label1.Text = "Proveedores";
            // 
            // bRegresar
            // 
            this.bRegresar.BackColor = System.Drawing.Color.Teal;
            this.bRegresar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bRegresar.Location = new System.Drawing.Point(859, 719);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(88, 34);
            this.bRegresar.TabIndex = 50;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = false;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // dgProveedores
            // 
            this.dgProveedores.AllowUserToAddRows = false;
            this.dgProveedores.AllowUserToDeleteRows = false;
            this.dgProveedores.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedores.Location = new System.Drawing.Point(46, 168);
            this.dgProveedores.Name = "dgProveedores";
            this.dgProveedores.ReadOnly = true;
            this.dgProveedores.Size = new System.Drawing.Size(882, 520);
            this.dgProveedores.TabIndex = 51;
            // 
            // bVistaprevia
            // 
            this.bVistaprevia.BackColor = System.Drawing.Color.Teal;
            this.bVistaprevia.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVistaprevia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bVistaprevia.Location = new System.Drawing.Point(478, 719);
            this.bVistaprevia.Name = "bVistaprevia";
            this.bVistaprevia.Size = new System.Drawing.Size(124, 34);
            this.bVistaprevia.TabIndex = 52;
            this.bVistaprevia.Text = "Vista previa";
            this.bVistaprevia.UseVisualStyleBackColor = false;
            this.bVistaprevia.Click += new System.EventHandler(this.bVistaprevia_Click);
            // 
            // bImprimir
            // 
            this.bImprimir.BackColor = System.Drawing.Color.Teal;
            this.bImprimir.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bImprimir.Location = new System.Drawing.Point(633, 719);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(88, 34);
            this.bImprimir.TabIndex = 53;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = false;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
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
            // FConsultaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(971, 777);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.bVistaprevia);
            this.Controls.Add(this.dgProveedores);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label8);
            this.Name = "FConsultaProveedor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FConsultaClientes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.DataGridView dgProveedores;
        private System.Windows.Forms.Button bVistaprevia;
        private System.Windows.Forms.Button bImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}