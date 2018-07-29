namespace WFFuentes
{
    partial class FConsultaClientes
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
            this.lvListaClientes = new System.Windows.Forms.ListView();
            this.IdCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Domicilio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Teléfono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RFC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoCredito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Garantia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LimiteCredito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bActualizar
            // 
            this.bActualizar.Location = new System.Drawing.Point(857, 373);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(75, 23);
            this.bActualizar.TabIndex = 48;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            // 
            // lvListaClientes
            // 
            this.lvListaClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCliente,
            this.NombreCompleto,
            this.Domicilio,
            this.Teléfono,
            this.RFC,
            this.TipoCredito,
            this.Garantia,
            this.LimiteCredito});
            this.lvListaClientes.Location = new System.Drawing.Point(13, 152);
            this.lvListaClientes.Name = "lvListaClientes";
            this.lvListaClientes.Size = new System.Drawing.Size(919, 197);
            this.lvListaClientes.TabIndex = 47;
            this.lvListaClientes.UseCompatibleStateImageBehavior = false;
            this.lvListaClientes.View = System.Windows.Forms.View.Details;
            // 
            // IdCliente
            // 
            this.IdCliente.Text = "IdCliente";
            this.IdCliente.Width = 55;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.Text = "Nombre Completo ";
            this.NombreCompleto.Width = 168;
            // 
            // Domicilio
            // 
            this.Domicilio.Text = "Domicilio";
            this.Domicilio.Width = 127;
            // 
            // Teléfono
            // 
            this.Teléfono.Text = "Teléfono";
            this.Teléfono.Width = 111;
            // 
            // RFC
            // 
            this.RFC.Text = "RFC";
            this.RFC.Width = 102;
            // 
            // TipoCredito
            // 
            this.TipoCredito.Text = "Tipo de Crédito";
            this.TipoCredito.Width = 128;
            // 
            // Garantia
            // 
            this.Garantia.Text = "Garantía";
            this.Garantia.Width = 118;
            // 
            // LimiteCredito
            // 
            this.LimiteCredito.Text = "Límite de Crédito";
            this.LimiteCredito.Width = 106;
            // 
            // bBusqueda
            // 
            this.bBusqueda.Location = new System.Drawing.Point(605, 101);
            this.bBusqueda.Name = "bBusqueda";
            this.bBusqueda.Size = new System.Drawing.Size(75, 23);
            this.bBusqueda.TabIndex = 46;
            this.bBusqueda.Text = "Buscar";
            this.bBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(162, 104);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(356, 20);
            this.txtBusqueda.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Busqueda por Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Cartera de clientes ";
            // 
            // FConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.lvListaClientes);
            this.Controls.Add(this.bBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label8);
            this.Name = "FConsultaClientes";
            this.Text = "FConsultaClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.ListView lvListaClientes;
        private System.Windows.Forms.ColumnHeader IdCliente;
        private System.Windows.Forms.ColumnHeader NombreCompleto;
        private System.Windows.Forms.ColumnHeader Domicilio;
        private System.Windows.Forms.ColumnHeader Teléfono;
        private System.Windows.Forms.ColumnHeader RFC;
        private System.Windows.Forms.ColumnHeader TipoCredito;
        private System.Windows.Forms.ColumnHeader Garantia;
        private System.Windows.Forms.ColumnHeader LimiteCredito;
        private System.Windows.Forms.Button bBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}