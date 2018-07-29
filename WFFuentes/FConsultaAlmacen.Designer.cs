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
            this.bImprimir = new System.Windows.Forms.Button();
            this.bActualizar = new System.Windows.Forms.Button();
            this.txtBusquedaProducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tabVerProducto = new System.Windows.Forms.ListView();
            this.idProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grupoP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.presentacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preciContado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precioCredito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bImprimir
            // 
            this.bImprimir.Location = new System.Drawing.Point(792, 329);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(75, 23);
            this.bImprimir.TabIndex = 61;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = true;
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(667, 329);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(75, 23);
            this.bActualizar.TabIndex = 60;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            // 
            // txtBusquedaProducto
            // 
            this.txtBusquedaProducto.Location = new System.Drawing.Point(159, 99);
            this.txtBusquedaProducto.Name = "txtBusquedaProducto";
            this.txtBusquedaProducto.Size = new System.Drawing.Size(399, 20);
            this.txtBusquedaProducto.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Busqueda por nombre";
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(591, 96);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 57;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // tabVerProducto
            // 
            this.tabVerProducto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProducto,
            this.nombreProducto,
            this.grupoP,
            this.cantidad,
            this.presentacion,
            this.preciContado,
            this.precioCredito});
            this.tabVerProducto.Location = new System.Drawing.Point(36, 137);
            this.tabVerProducto.Name = "tabVerProducto";
            this.tabVerProducto.Size = new System.Drawing.Size(830, 186);
            this.tabVerProducto.TabIndex = 56;
            this.tabVerProducto.UseCompatibleStateImageBehavior = false;
            this.tabVerProducto.View = System.Windows.Forms.View.Details;
            // 
            // idProducto
            // 
            this.idProducto.Text = "Id Producto";
            this.idProducto.Width = 77;
            // 
            // nombreProducto
            // 
            this.nombreProducto.Text = "Nombre del producto";
            this.nombreProducto.Width = 184;
            // 
            // grupoP
            // 
            this.grupoP.Text = "Grupo perteneciente";
            this.grupoP.Width = 142;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Existencia";
            this.cantidad.Width = 108;
            // 
            // presentacion
            // 
            this.presentacion.Text = "Presentación";
            this.presentacion.Width = 105;
            // 
            // preciContado
            // 
            this.preciContado.Text = "Precio Contado";
            this.preciContado.Width = 107;
            // 
            // precioCredito
            // 
            this.precioCredito.Text = "Precio Crédito";
            this.precioCredito.Width = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 62;
            this.label1.Text = "Producto en almacen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FConsultaAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.txtBusquedaProducto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tabVerProducto);
            this.Name = "FConsultaAlmacen";
            this.Text = "FConsultaAlmacen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.TextBox txtBusquedaProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.ListView tabVerProducto;
        private System.Windows.Forms.ColumnHeader idProducto;
        private System.Windows.Forms.ColumnHeader nombreProducto;
        private System.Windows.Forms.ColumnHeader grupoP;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.ColumnHeader presentacion;
        private System.Windows.Forms.ColumnHeader preciContado;
        private System.Windows.Forms.ColumnHeader precioCredito;
        private System.Windows.Forms.Label label1;
    }
}