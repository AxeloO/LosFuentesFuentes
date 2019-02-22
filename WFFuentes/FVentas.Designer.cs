namespace WFFuentes
{
    partial class FVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.FdFechaSalida = new System.Windows.Forms.TextBox();
            this.FcNombreCliente = new System.Windows.Forms.TextBox();
            this.FcDomicilio = new System.Windows.Forms.TextBox();
            this.FcCiudad = new System.Windows.Forms.TextBox();
            this.FcTelefono = new System.Windows.Forms.TextBox();
            this.FdFechaPago = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.FdTotal = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bRegresar = new System.Windows.Forms.Button();
            this.bBusqueda = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dgTotalProductos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FcConcepto = new System.Windows.Forms.TextBox();
            this.txtTotalAPagarCredito = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPrecioACredito = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPrecioDeContado = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnImprimirVenta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btPrevioImprecion = new System.Windows.Forms.Button();
            this.PrevioImprecion = new System.Windows.Forms.PrintPreviewDialog();
            this.ImprecionNota = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Salida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Domicilio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1345, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cantidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Importe:";
            // 
            // dgProductos
            // 
            this.dgProductos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(45, 563);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(720, 155);
            this.dgProductos.TabIndex = 12;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick);
            // 
            // FdFechaSalida
            // 
            this.FdFechaSalida.Enabled = false;
            this.FdFechaSalida.Location = new System.Drawing.Point(228, 114);
            this.FdFechaSalida.Name = "FdFechaSalida";
            this.FdFechaSalida.ReadOnly = true;
            this.FdFechaSalida.Size = new System.Drawing.Size(206, 20);
            this.FdFechaSalida.TabIndex = 13;
            // 
            // FcNombreCliente
            // 
            this.FcNombreCliente.Location = new System.Drawing.Point(228, 159);
            this.FcNombreCliente.Name = "FcNombreCliente";
            this.FcNombreCliente.Size = new System.Drawing.Size(206, 20);
            this.FcNombreCliente.TabIndex = 14;
            // 
            // FcDomicilio
            // 
            this.FcDomicilio.Location = new System.Drawing.Point(228, 204);
            this.FcDomicilio.Name = "FcDomicilio";
            this.FcDomicilio.Size = new System.Drawing.Size(206, 20);
            this.FcDomicilio.TabIndex = 15;
            // 
            // FcCiudad
            // 
            this.FcCiudad.Location = new System.Drawing.Point(228, 247);
            this.FcCiudad.Name = "FcCiudad";
            this.FcCiudad.Size = new System.Drawing.Size(206, 20);
            this.FcCiudad.TabIndex = 16;
            // 
            // FcTelefono
            // 
            this.FcTelefono.Location = new System.Drawing.Point(228, 292);
            this.FcTelefono.Name = "FcTelefono";
            this.FcTelefono.Size = new System.Drawing.Size(206, 20);
            this.FcTelefono.TabIndex = 17;
            // 
            // FdFechaPago
            // 
            this.FdFechaPago.Location = new System.Drawing.Point(228, 340);
            this.FdFechaPago.Name = "FdFechaPago";
            this.FdFechaPago.Size = new System.Drawing.Size(206, 20);
            this.FdFechaPago.TabIndex = 18;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(197, 111);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(206, 20);
            this.txtCantidad.TabIndex = 19;
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(864, 371);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(206, 20);
            this.txtImporte.TabIndex = 22;
            // 
            // FdTotal
            // 
            this.FdTotal.Enabled = false;
            this.FdTotal.Location = new System.Drawing.Point(1376, 464);
            this.FdTotal.Name = "FdTotal";
            this.FdTotal.Size = new System.Drawing.Size(100, 20);
            this.FdTotal.TabIndex = 23;
            // 
            // bCancelar
            // 
            this.bCancelar.BackColor = System.Drawing.Color.Teal;
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bCancelar.Location = new System.Drawing.Point(1363, 647);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(113, 31);
            this.bCancelar.TabIndex = 25;
            this.bCancelar.Text = "Cancelar Venta";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.BackColor = System.Drawing.Color.Teal;
            this.bLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpiar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bLimpiar.Location = new System.Drawing.Point(445, 371);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(128, 33);
            this.bLimpiar.TabIndex = 26;
            this.bLimpiar.Text = "Limpiar Campos";
            this.bLimpiar.UseVisualStyleBackColor = false;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bRegresar
            // 
            this.bRegresar.BackColor = System.Drawing.Color.Teal;
            this.bRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bRegresar.Location = new System.Drawing.Point(1483, 647);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(111, 31);
            this.bRegresar.TabIndex = 27;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = false;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // bBusqueda
            // 
            this.bBusqueda.BackColor = System.Drawing.Color.Teal;
            this.bBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBusqueda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bBusqueda.Location = new System.Drawing.Point(607, 494);
            this.bBusqueda.Name = "bBusqueda";
            this.bBusqueda.Size = new System.Drawing.Size(94, 32);
            this.bBusqueda.TabIndex = 28;
            this.bBusqueda.Text = "Buscar";
            this.bBusqueda.UseVisualStyleBackColor = false;
            this.bBusqueda.Click += new System.EventHandler(this.bBusqueda_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(223, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 27);
            this.label13.TabIndex = 29;
            this.label13.Text = "Datos Generales";
            // 
            // dgTotalProductos
            // 
            this.dgTotalProductos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgTotalProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTotalProductos.Location = new System.Drawing.Point(1115, 189);
            this.dgTotalProductos.Name = "dgTotalProductos";
            this.dgTotalProductos.Size = new System.Drawing.Size(496, 234);
            this.dgTotalProductos.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.AcceptsReturn = true;
            this.txtNombre.AcceptsTab = true;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(197, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 20);
            this.txtNombre.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 23);
            this.label14.TabIndex = 33;
            this.label14.Text = "Nombre de Producto:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1265, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 27);
            this.label15.TabIndex = 32;
            this.label15.Text = "Generar Venta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1110, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 26);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total a Pagar de Contado";
            // 
            // bAgregar
            // 
            this.bAgregar.BackColor = System.Drawing.Color.Teal;
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bAgregar.Location = new System.Drawing.Point(260, 316);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(143, 32);
            this.bAgregar.TabIndex = 35;
            this.bAgregar.Text = "Agregar Producto";
            this.bAgregar.UseVisualStyleBackColor = false;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(233, 444);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 27);
            this.label16.TabIndex = 36;
            this.label16.Text = "Mostrar Productos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Búsqueda por nombre:";
            // 
            // FcConcepto
            // 
            this.FcConcepto.Location = new System.Drawing.Point(252, 502);
            this.FcConcepto.Name = "FcConcepto";
            this.FcConcepto.Size = new System.Drawing.Size(333, 20);
            this.FcConcepto.TabIndex = 38;
            // 
            // txtTotalAPagarCredito
            // 
            this.txtTotalAPagarCredito.Enabled = false;
            this.txtTotalAPagarCredito.Location = new System.Drawing.Point(1376, 506);
            this.txtTotalAPagarCredito.Name = "txtTotalAPagarCredito";
            this.txtTotalAPagarCredito.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAPagarCredito.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1110, 506);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(214, 26);
            this.label17.TabIndex = 40;
            this.label17.Text = "Total a Pagar a Credito";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1345, 500);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 26);
            this.label18.TabIndex = 39;
            this.label18.Text = "$";
            // 
            // txtPrecioACredito
            // 
            this.txtPrecioACredito.Enabled = false;
            this.txtPrecioACredito.Location = new System.Drawing.Point(864, 326);
            this.txtPrecioACredito.Name = "txtPrecioACredito";
            this.txtPrecioACredito.Size = new System.Drawing.Size(206, 20);
            this.txtPrecioACredito.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 23);
            this.label19.TabIndex = 42;
            this.label19.Text = "Precio a Credito:";
            // 
            // txtPrecioDeContado
            // 
            this.txtPrecioDeContado.Enabled = false;
            this.txtPrecioDeContado.Location = new System.Drawing.Point(197, 153);
            this.txtPrecioDeContado.Name = "txtPrecioDeContado";
            this.txtPrecioDeContado.Size = new System.Drawing.Size(206, 20);
            this.txtPrecioDeContado.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 149);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(145, 23);
            this.label20.TabIndex = 44;
            this.label20.Text = "Precio de Contado:";
            // 
            // btnImprimirVenta
            // 
            this.btnImprimirVenta.BackColor = System.Drawing.Color.Teal;
            this.btnImprimirVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirVenta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnImprimirVenta.Location = new System.Drawing.Point(1115, 567);
            this.btnImprimirVenta.Name = "btnImprimirVenta";
            this.btnImprimirVenta.Size = new System.Drawing.Size(231, 31);
            this.btnImprimirVenta.TabIndex = 46;
            this.btnImprimirVenta.Text = "Imprimir y Pagar Contado";
            this.btnImprimirVenta.UseVisualStyleBackColor = false;
            this.btnImprimirVenta.Click += new System.EventHandler(this.btnImprimirVenta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(1363, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 31);
            this.button1.TabIndex = 47;
            this.button1.Text = "Imprimir y Pagar a Crédito";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPrevioImprecion
            // 
            this.btPrevioImprecion.BackColor = System.Drawing.Color.Teal;
            this.btPrevioImprecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrevioImprecion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btPrevioImprecion.Location = new System.Drawing.Point(1115, 647);
            this.btPrevioImprecion.Name = "btPrevioImprecion";
            this.btPrevioImprecion.Size = new System.Drawing.Size(227, 31);
            this.btPrevioImprecion.TabIndex = 48;
            this.btPrevioImprecion.Text = "Vista previa de Impresion";
            this.btPrevioImprecion.UseVisualStyleBackColor = false;
            this.btPrevioImprecion.Click += new System.EventHandler(this.button2_Click);
            // 
            // PrevioImprecion
            // 
            this.PrevioImprecion.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrevioImprecion.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrevioImprecion.ClientSize = new System.Drawing.Size(400, 300);
            this.PrevioImprecion.Enabled = true;
            this.PrevioImprecion.Icon = ((System.Drawing.Icon)(resources.GetObject("PrevioImprecion.Icon")));
            this.PrevioImprecion.Name = "PrevioImprecion";
            this.PrevioImprecion.Visible = false;
            // 
            // ImprecionNota
            // 
            this.ImprecionNota.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprecionNota_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtPrecioDeContado);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.bAgregar);
            this.groupBox1.Location = new System.Drawing.Point(667, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 365);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 382);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // FVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1378, 780);
            this.Controls.Add(this.btPrevioImprecion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImprimirVenta);
            this.Controls.Add(this.txtPrecioACredito);
            this.Controls.Add(this.txtTotalAPagarCredito);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.FcConcepto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgTotalProductos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bBusqueda);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.FdTotal);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.FdFechaPago);
            this.Controls.Add(this.FcTelefono);
            this.Controls.Add(this.FcCiudad);
            this.Controls.Add(this.FcDomicilio);
            this.Controls.Add(this.FcNombreCliente);
            this.Controls.Add(this.FdFechaSalida);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FVentas";
            this.Text = "FVentas";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FVentas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.TextBox FdFechaSalida;
        private System.Windows.Forms.TextBox FcNombreCliente;
        private System.Windows.Forms.TextBox FcDomicilio;
        private System.Windows.Forms.TextBox FcCiudad;
        private System.Windows.Forms.TextBox FcTelefono;
        private System.Windows.Forms.TextBox FdFechaPago;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox FdTotal;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.Button bBusqueda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgTotalProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FcConcepto;
        private System.Windows.Forms.TextBox txtTotalAPagarCredito;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPrecioACredito;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPrecioDeContado;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnImprimirVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btPrevioImprecion;
        private System.Windows.Forms.PrintPreviewDialog PrevioImprecion;
        private System.Drawing.Printing.PrintDocument ImprecionNota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}