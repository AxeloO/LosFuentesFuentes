namespace WFFuentes
{
    partial class FConsultaCuentasCobrar
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvListadoCuentasCobrar = new System.Windows.Forms.ListView();
            this.IdCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoNota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Importe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FechaLimite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Interes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(817, 291);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(75, 23);
            this.bActualizar.TabIndex = 44;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(706, 119);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 43;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(197, 128);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(425, 20);
            this.txtBusqueda.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Búsqueda por nombre";
            // 
            // lvListadoCuentasCobrar
            // 
            this.lvListadoCuentasCobrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCliente,
            this.Nombre,
            this.NoNota,
            this.Importe,
            this.Salida,
            this.FechaLimite,
            this.Interes,
            this.Total});
            this.lvListadoCuentasCobrar.Location = new System.Drawing.Point(54, 164);
            this.lvListadoCuentasCobrar.Name = "lvListadoCuentasCobrar";
            this.lvListadoCuentasCobrar.Size = new System.Drawing.Size(880, 97);
            this.lvListadoCuentasCobrar.TabIndex = 40;
            this.lvListadoCuentasCobrar.UseCompatibleStateImageBehavior = false;
            this.lvListadoCuentasCobrar.View = System.Windows.Forms.View.Details;
            // 
            // IdCliente
            // 
            this.IdCliente.Text = "IdCliente";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre Completo";
            this.Nombre.Width = 176;
            // 
            // NoNota
            // 
            this.NoNota.Text = "No. de nota";
            this.NoNota.Width = 78;
            // 
            // Importe
            // 
            this.Importe.Text = "Importe ";
            this.Importe.Width = 100;
            // 
            // Salida
            // 
            this.Salida.Text = "Fecha de salida ";
            this.Salida.Width = 109;
            // 
            // FechaLimite
            // 
            this.FechaLimite.Text = "Fecha limite de pago";
            this.FechaLimite.Width = 124;
            // 
            // Interes
            // 
            this.Interes.Text = "Interes Generado";
            this.Interes.Width = 104;
            // 
            // Total
            // 
            this.Total.Text = "Total a pagar";
            this.Total.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Cuentas por cobrar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FConsultaCuentasCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvListadoCuentasCobrar);
            this.Name = "FConsultaCuentasCobrar";
            this.Text = "FConsultaCuentasCobrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvListadoCuentasCobrar;
        private System.Windows.Forms.ColumnHeader IdCliente;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader NoNota;
        private System.Windows.Forms.ColumnHeader Importe;
        private System.Windows.Forms.ColumnHeader Salida;
        private System.Windows.Forms.ColumnHeader FechaLimite;
        private System.Windows.Forms.ColumnHeader Interes;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label1;
    }
}