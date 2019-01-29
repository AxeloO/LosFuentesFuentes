namespace WFFuentes
{
    partial class FAgregarCliente
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
            this.bAgregar = new System.Windows.Forms.Button();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.txtTipoCredito = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bBack = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bConsultar = new System.Windows.Forms.Button();
            this.dGClientes = new System.Windows.Forms.DataGridView();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.bBusqueda = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.Teal;
            this.bAgregar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bAgregar.Location = new System.Drawing.Point(545, 182);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(99, 37);
            this.bAgregar.TabIndex = 38;
            this.bAgregar.Text = "Guardar";
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Location = new System.Drawing.Point(171, 396);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(219, 20);
            this.txtLimiteCredito.TabIndex = 35;
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(171, 351);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(264, 20);
            this.txtGarantia.TabIndex = 34;
            // 
            // txtTipoCredito
            // 
            this.txtTipoCredito.Location = new System.Drawing.Point(171, 306);
            this.txtTipoCredito.Name = "txtTipoCredito";
            this.txtTipoCredito.Size = new System.Drawing.Size(264, 20);
            this.txtTipoCredito.TabIndex = 33;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(171, 262);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(319, 20);
            this.txtRFC.TabIndex = 32;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(171, 216);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(319, 20);
            this.txtTelefono.TabIndex = 31;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(171, 173);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(319, 20);
            this.txtDomicilio.TabIndex = 30;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(171, 128);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(319, 20);
            this.txtNombreCompleto.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Límite de Crédito: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Garantía:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(19, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tipo de Crédito: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(19, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "RFC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Domicilio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre Completo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 30);
            this.label8.TabIndex = 41;
            this.label8.Text = "Nuevo Registro";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.Teal;
            this.bBack.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bBack.Location = new System.Drawing.Point(1239, 384);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(101, 31);
            this.bBack.TabIndex = 42;
            this.bBack.Text = "Regresar";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bModificar
            // 
            this.bModificar.BackColor = System.Drawing.Color.Teal;
            this.bModificar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bModificar.Location = new System.Drawing.Point(545, 241);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(99, 33);
            this.bModificar.TabIndex = 43;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.Teal;
            this.bEliminar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bEliminar.Location = new System.Drawing.Point(545, 296);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(99, 36);
            this.bEliminar.TabIndex = 44;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bConsultar
            // 
            this.bConsultar.BackColor = System.Drawing.Color.Teal;
            this.bConsultar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bConsultar.Location = new System.Drawing.Point(1113, 385);
            this.bConsultar.Name = "bConsultar";
            this.bConsultar.Size = new System.Drawing.Size(98, 30);
            this.bConsultar.TabIndex = 45;
            this.bConsultar.Text = "Mostrar";
            this.bConsultar.UseVisualStyleBackColor = false;
            this.bConsultar.Click += new System.EventHandler(this.bConsultar_Click);
            // 
            // dGClientes
            // 
            this.dGClientes.AllowUserToOrderColumns = true;
            this.dGClientes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGClientes.GridColor = System.Drawing.Color.DimGray;
            this.dGClientes.Location = new System.Drawing.Point(709, 145);
            this.dGClientes.Name = "dGClientes";
            this.dGClientes.Size = new System.Drawing.Size(635, 201);
            this.dGClientes.TabIndex = 46;
            this.dGClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGClientes_CellClick);
            this.dGClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGClientes_CellClick);
            // 
            // bLimpiar
            // 
            this.bLimpiar.BackColor = System.Drawing.Color.Teal;
            this.bLimpiar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bLimpiar.Location = new System.Drawing.Point(545, 352);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(99, 35);
            this.bLimpiar.TabIndex = 47;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = false;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(19, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 23);
            this.label9.TabIndex = 48;
            this.label9.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 80);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 20);
            this.txtID.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(715, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "Búsqueda por nombre:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(885, 105);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(343, 20);
            this.txtBusqueda.TabIndex = 51;
            // 
            // bBusqueda
            // 
            this.bBusqueda.BackColor = System.Drawing.Color.Teal;
            this.bBusqueda.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBusqueda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bBusqueda.Location = new System.Drawing.Point(1260, 98);
            this.bBusqueda.Name = "bBusqueda";
            this.bBusqueda.Size = new System.Drawing.Size(82, 32);
            this.bBusqueda.TabIndex = 52;
            this.bBusqueda.Text = "Buscar";
            this.bBusqueda.UseVisualStyleBackColor = false;
            this.bBusqueda.Click += new System.EventHandler(this.bBusqueda_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(939, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 30);
            this.label11.TabIndex = 53;
            this.label11.Text = "Lista de clientes";
            // 
            // FAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1370, 488);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.dGClientes);
            this.Controls.Add(this.bConsultar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.txtLimiteCredito);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.txtTipoCredito);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAgregarCliente";
            this.Text = "FAgregarCliente";
            this.Load += new System.EventHandler(this.FAgregarCliente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FAgregarCliente_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.TextBox txtTipoCredito;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bConsultar;
        private System.Windows.Forms.DataGridView dGClientes;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button bBusqueda;
        private System.Windows.Forms.Label label11;
    }
}