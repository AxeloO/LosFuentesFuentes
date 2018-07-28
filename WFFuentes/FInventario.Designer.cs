namespace WFFuentes
{
    partial class FInventario
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grupoP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.presentacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preciContado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precioCredito = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPrecioCredito = new System.Windows.Forms.TextBox();
            this.txtPrecioDeContado = new System.Windows.Forms.TextBox();
            this.txtPorcentajePrecioCredito = new System.Windows.Forms.TextBox();
            this.txtPorcentajeDeContado = new System.Windows.Forms.TextBox();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtGrupoPerteneciente = new System.Windows.Forms.TextBox();
            this.txtNombreDelProducto = new System.Windows.Forms.TextBox();
            this.cbPresentacion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(801, 470);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 55;
            this.button6.Text = "Imprimir";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(676, 470);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 54;
            this.button5.Text = "Acttualizar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(183, 317);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(399, 20);
            this.textBox9.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Busqueda por nombre";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(615, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 51;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 27);
            this.button3.TabIndex = 50;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Guardar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProducto,
            this.nombreProducto,
            this.grupoP,
            this.cantidad,
            this.presentacion,
            this.preciContado,
            this.precioCredito});
            this.listView1.Location = new System.Drawing.Point(60, 355);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(830, 93);
            this.listView1.TabIndex = 47;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // txtPrecioCredito
            // 
            this.txtPrecioCredito.Location = new System.Drawing.Point(537, 217);
            this.txtPrecioCredito.Name = "txtPrecioCredito";
            this.txtPrecioCredito.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCredito.TabIndex = 46;
            // 
            // txtPrecioDeContado
            // 
            this.txtPrecioDeContado.Location = new System.Drawing.Point(537, 182);
            this.txtPrecioDeContado.Name = "txtPrecioDeContado";
            this.txtPrecioDeContado.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioDeContado.TabIndex = 45;
            // 
            // txtPorcentajePrecioCredito
            // 
            this.txtPorcentajePrecioCredito.Location = new System.Drawing.Point(364, 217);
            this.txtPorcentajePrecioCredito.Name = "txtPorcentajePrecioCredito";
            this.txtPorcentajePrecioCredito.Size = new System.Drawing.Size(38, 20);
            this.txtPorcentajePrecioCredito.TabIndex = 44;
            // 
            // txtPorcentajeDeContado
            // 
            this.txtPorcentajeDeContado.Location = new System.Drawing.Point(364, 182);
            this.txtPorcentajeDeContado.Name = "txtPorcentajeDeContado";
            this.txtPorcentajeDeContado.Size = new System.Drawing.Size(38, 20);
            this.txtPorcentajeDeContado.TabIndex = 43;
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(651, 130);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtCostoUnitario.TabIndex = 42;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(123, 130);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 20);
            this.txtCantidad.TabIndex = 41;
            // 
            // txtGrupoPerteneciente
            // 
            this.txtGrupoPerteneciente.Location = new System.Drawing.Point(583, 78);
            this.txtGrupoPerteneciente.Name = "txtGrupoPerteneciente";
            this.txtGrupoPerteneciente.Size = new System.Drawing.Size(210, 20);
            this.txtGrupoPerteneciente.TabIndex = 40;
            // 
            // txtNombreDelProducto
            // 
            this.txtNombreDelProducto.Location = new System.Drawing.Point(169, 78);
            this.txtNombreDelProducto.Name = "txtNombreDelProducto";
            this.txtNombreDelProducto.Size = new System.Drawing.Size(215, 20);
            this.txtNombreDelProducto.TabIndex = 39;
            // 
            // cbPresentacion
            // 
            this.cbPresentacion.FormattingEnabled = true;
            this.cbPresentacion.Location = new System.Drawing.Point(365, 130);
            this.cbPresentacion.Name = "cbPresentacion";
            this.cbPresentacion.Size = new System.Drawing.Size(156, 21);
            this.cbPresentacion.TabIndex = 38;
            
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Precio crédito";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Precio contado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Porcentaje precio crédito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Porcentaje precio contado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Costo unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Presentación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Grupo perteneciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Agregar Productos";
            // 
            // FInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 512);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtPrecioCredito);
            this.Controls.Add(this.txtPrecioDeContado);
            this.Controls.Add(this.txtPorcentajePrecioCredito);
            this.Controls.Add(this.txtPorcentajeDeContado);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtGrupoPerteneciente);
            this.Controls.Add(this.txtNombreDelProducto);
            this.Controls.Add(this.cbPresentacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FInventario";
            this.Text = "FInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idProducto;
        private System.Windows.Forms.ColumnHeader nombreProducto;
        private System.Windows.Forms.ColumnHeader grupoP;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.ColumnHeader presentacion;
        private System.Windows.Forms.ColumnHeader preciContado;
        private System.Windows.Forms.ColumnHeader precioCredito;
        private System.Windows.Forms.TextBox txtPrecioCredito;
        private System.Windows.Forms.TextBox txtPrecioDeContado;
        private System.Windows.Forms.TextBox txtPorcentajePrecioCredito;
        private System.Windows.Forms.TextBox txtPorcentajeDeContado;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtGrupoPerteneciente;
        private System.Windows.Forms.TextBox txtNombreDelProducto;
        private System.Windows.Forms.ComboBox cbPresentacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}