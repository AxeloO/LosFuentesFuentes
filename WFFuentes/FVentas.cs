﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using EN;
using BL;
namespace WFFuentes
{
    public partial class FVentas : Form
    {
        Bitmap bmp;
        //  Graphics mg;
        EnVentas _enVentas = new EnVentas();
        VentasBL _ventasBL = new VentasBL();
        InventarioBL _inventarioBL = new InventarioBL();
        Inventario _enInventario = new Inventario();



        // variables globales
        string strtipoDeVenta = String.Empty;
        string strTotalAPagarCredito = String.Empty;
        string strTotalAPagarContado = String.Empty;
        double douTotalSumaProductos = 0;
        double douTotalSumaProductosCredito = 0;
        public string strExistenciaProducto = string.Empty;
        string striDProducto = string.Empty;
        DataGridViewRow finaldgTotalProductos = new DataGridViewRow();

        public FVentas()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void bRegresar_Click(object sender, EventArgs e)
        {
            FMenuEmpleado _fPrincipal = new FMenuEmpleado();
            _fPrincipal.Show();
            this.Close();
        }

        private void FVentas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        // Programacion OP

        private void bVenta_Click(object sender, EventArgs e)
        {

            try
            {


                if (FdFechaSalida.Text == "" || FcNombreCliente.Text == "" || FcDomicilio.Text == "" || FcCiudad.Text == "" || FcTelefono.Text == "" || FdFechaPago.Text == "" || txtCantidad.Text == "" || txtPrecioDeContado.Text == "" || txtPrecioACredito.Text == "" || txtImporte.Text == "" || txtNombre.Text =="")

                // if (FdFechaSalida.Text == "" || FcNombreCliente.Text == "" || FcDomicilio.Text == "" || FcCiudad.Text == "" || FcTelefono.Text == "" || FdFechaPago.Text == "" || txtCantidad.Text == "" || FcConcepto.Text == "" || txtPrecioUnitario.Text == "" || txtImporte.Text == "")
                {
                    MessageBox.Show("Parece que olvidaste llenar todos los campos", "¡Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    _enVentas.fDtFechaSalida = FdFechaSalida.Text;
                    _enVentas.fcNombreCliente = FcNombreCliente.Text;
                    _enVentas.fcDomicilio = FcDomicilio.Text;
                    _enVentas.fcCiudad = FcCiudad.Text;
                    _enVentas.fcTelefono = FcTelefono.Text;
                    _enVentas.fcFechaPago = FdFechaPago.Text;
                    _enVentas.fiCantidad = int.Parse(txtCantidad.Text);
                    _enVentas.fcConcepto = txtNombre.Text;//Cambio de Variable para asignar el nombre del producto 08/03/19
                    //_enVentas.fdPrecioUnitario = decimal.Parse(txtPrecioUnitario.Text);
                    _enVentas.fdImporte = decimal.Parse(txtImporte.Text);
                    _enVentas.fdTotal = decimal.Parse(FdTotal.Text);

                    int Resultado = _ventasBL.AgregarVenta(_enVentas);

                    if (Resultado == 1)
                    {
                        MessageBox.Show("Se agrego el nuevo producto correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpiar();
                        Limpiar_Venta();
                    }

                }
            }

            catch (Exception)
            {

                MessageBox.Show("Hubo un error al agregar el producto", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void btConsultarVentas_Click(object sender, EventArgs e)
        {
            dgProductos.DataSource = _ventasBL.MostrarVentas();
        }

        private void bBusqueda_Click(object sender, EventArgs e)
        {
            if (!(FcConcepto.Text == ""))
            {
                _enInventario.NombreProducto = FcConcepto.Text;
                dgProductos.DataSource = _inventarioBL.MostrarInventarioPorNombreEmpleado(_enInventario);//Evitamos mostrar el precio unitario ó precio proveedor 21/03/19
                FcConcepto.Text = string.Empty;

            }
            //dgProductos.DataSource = _inventarioBL.MostrarInventario();
        }

        private void Limpiar()
        {
            FdFechaSalida.Text = string.Empty;
            FcNombreCliente.Text = string.Empty;
            FcDomicilio.Text = string.Empty;
            FcCiudad.Text = string.Empty;
            FcTelefono.Text = string.Empty;
            FdFechaPago.Text = string.Empty;
            FdFechaSalida.Focus();
        }

        private void Limpiar_Venta()
        {

            txtNombre.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtPrecioDeContado.Text = string.Empty;
            txtPrecioACredito.Text = string.Empty;
            txtImporte.Text = string.Empty;
            txtNombre.Focus();


        }
        private void bLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void dgProductos_CellClick(object sender, DataGridViewCellEventArgs e)//Odio lo de sincronizacion -.-"
        {

            striDProducto = dgProductos.Rows[e.RowIndex].Cells["idProducto"].Value.ToString();
            strExistenciaProducto = dgProductos.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            string strCantidad = txtCantidad.Text.ToString().Trim();
            txtNombre.Text = dgProductos.Rows[e.RowIndex].Cells["NombreProducto"].Value.ToString();
            //txtPrecioUnitario.Text = dgProductos.Rows[e.RowIndex].Cells["CostoUnitario"].Value.ToString();
            txtPrecioACredito.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioACredito"].Value.ToString();
            txtPrecioDeContado.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioContado"].Value.ToString();
            // txtPrecioUnitario.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioContado"].Value.ToString();//Precio Contado o Precio Credito //Precio depende del tipo de venta      
            // txtPrecioUnitario.Text = dgProductos.Rows[e.RowIndex].Cells["PrecioContado"].Value.ToString();//Precio Contado o Precio Credito //Precio depende del tipo de venta      
            //  string strPrecio = txtPrecioUnitario.Text.ToString().Trim();


        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                double intCantidadProducto;
                double doTotalDelProducto;
                double doTotalDelProductoCredito;
                string strNombreProductos;
                double doublePrecioContado;//Agregado para guardar el precio de contado por unidad.. 21/03/19
                double doublePrecioACredito;//Agregado para guardar el prcio de credito por unidad.. 21/03/19


                if (!txtNombre.Text.Equals(""))
                {
                    double intCantidadDeProductoExistencia = double.Parse(strExistenciaProducto);

                    if (txtCantidad.Text.Equals("") || txtCantidad.Text.Equals(null))
                    {
                        MessageBox.Show("Debe colocar la cantidad que desea vender", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }

                    int intCantidadAComprar = int.Parse(txtCantidad.Text);

                    if (intCantidadDeProductoExistencia < intCantidadAComprar)
                    {
                        MessageBox.Show("No se puede vender más productos de los que hay en almacen", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {

                        int intIdProducto = int.Parse(striDProducto);
                        intCantidadProducto = double.Parse(txtCantidad.Text.ToString().Trim());
                        double intProductoUnitario = double.Parse(txtPrecioDeContado.Text.ToString().Trim());
                        double doProductoUnitarioCredito = double.Parse(txtPrecioACredito.Text.ToString().Trim());
                        doTotalDelProducto = intProductoUnitario * intCantidadProducto;
                        doTotalDelProductoCredito = doProductoUnitarioCredito * intCantidadProducto;
                        txtImporte.Text = doTotalDelProducto.ToString();
                        this.Controls.Add(dgTotalProductos);
                        strNombreProductos = txtNombre.Text.ToString().Trim();
                        doublePrecioContado = double.Parse(txtPrecioDeContado.Text.ToString().Trim());//Agregado para gaurdar los precios por unidad.. 21/03/19.. Haber que pasa..
                        doublePrecioACredito = double.Parse(txtPrecioACredito.Text.ToString().Trim());//Agregado para gaurdar los precios por unidad.. 21/03/19.. Haber que pasa..


                        if (dgTotalProductos.Columns.Count == 0)
                        {
                            DataGridViewTextBoxColumn colIdProducto = new DataGridViewTextBoxColumn();
                            colIdProducto.HeaderText = "Id Producto";
                            colIdProducto.Width = 80;
                            dgTotalProductos.Columns.Add(colIdProducto);

                            DataGridViewTextBoxColumn colNombreProducto = new DataGridViewTextBoxColumn();
                            colNombreProducto.HeaderText = "Nombre del Producto";
                            colNombreProducto.Width = 80;
                            dgTotalProductos.Columns.Add(colNombreProducto);

                            DataGridViewTextBoxColumn colCantidadProducto = new DataGridViewTextBoxColumn();
                            colCantidadProducto.HeaderText = "Cantidad";
                            colCantidadProducto.Width = 80;
                            dgTotalProductos.Columns.Add(colCantidadProducto);

                            DataGridViewTextBoxColumn colTotalProducto = new DataGridViewTextBoxColumn();
                            colTotalProducto.HeaderText = "Precio Total Unitario";
                            colTotalProducto.Width = 80;
                            dgTotalProductos.Columns.Add(colTotalProducto);

                            DataGridViewTextBoxColumn colCantidadProductoCredito = new DataGridViewTextBoxColumn();
                            colCantidadProductoCredito.HeaderText = "Precio Total A Credito";
                            colCantidadProductoCredito.Width = 80;
                            dgTotalProductos.Columns.Add(colCantidadProductoCredito);

                            DataGridViewTextBoxColumn colPrecioContado = new DataGridViewTextBoxColumn();//Agregado por prueba para poner precio de contado por producto.. 21/03/19
                            colCantidadProductoCredito.HeaderText = "Precio Unitario de Contado";
                            colCantidadProductoCredito.Width = 80;
                            dgTotalProductos.Columns.Add(colPrecioContado);

                            DataGridViewTextBoxColumn colPrecioACredito = new DataGridViewTextBoxColumn();//Agregado por prueba para poner precio a credito por producto.. 21/03/19
                            colCantidadProductoCredito.HeaderText = "Precio Unitario A Credito";
                            colCantidadProductoCredito.Width = 80;
                            dgTotalProductos.Columns.Add(colPrecioACredito);

                            dgTotalProductos.Rows.Add(intIdProducto, strNombreProductos, intCantidadProducto, doTotalDelProducto, doTotalDelProductoCredito,doublePrecioContado,doublePrecioACredito);

                        }
                        else
                        {
                            dgTotalProductos.Rows.Add(intIdProducto, strNombreProductos, intCantidadProducto, doTotalDelProducto, doTotalDelProductoCredito,doublePrecioContado, doublePrecioACredito);

                        }

                        douTotalSumaProductos = douTotalSumaProductos + doTotalDelProducto;
                        douTotalSumaProductosCredito = douTotalSumaProductosCredito + doTotalDelProductoCredito;
                        FdTotal.Text = douTotalSumaProductos.ToString();
                        txtTotalAPagarCredito.Text = douTotalSumaProductosCredito.ToString();
                        strTotalAPagarCredito = douTotalSumaProductosCredito.ToString();
                        strTotalAPagarContado = douTotalSumaProductos.ToString();

                    }

                }


                else
                {
                    MessageBox.Show("Debe seleccionar un producto primero", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Limpiar_Venta();
        }

        private void btnImprimirVenta_Click(object sender, EventArgs e)//Venta de contado 08/03/19
        {
            try
            {

                Inventario _en = new Inventario();
                InventarioBL _inventarioBl = new InventarioBL();

                //Variables del Metodo
                strtipoDeVenta = "1";
                double doTotalSumaProductos;
                double doTotalSumaProductosCredito;
                double intCantidadProducto;
                int intCantidadProductoafectarInventario = 0;
                string strNombreModificado = string.Empty;
                string strIdProductoComparar = string.Empty;
                int intCantidadModificada = 0;
         


                if (!FdFechaPago.Text.Equals(string.Empty) && !FdFechaSalida.Text.Equals(string.Empty) && !FcNombreCliente.Text.Equals(string.Empty) && !FcDomicilio.Text.Equals(string.Empty) && !FcCiudad.Text.Equals(string.Empty) && !FcTelefono.Text.Equals(string.Empty))
                {


                    _enVentas.fDtFechaSalida = FdFechaSalida.Text.ToString();
                    _enVentas.fcNombreCliente = FcNombreCliente.Text.ToString();
                    _enVentas.fcDomicilio = FcDomicilio.Text.ToString();
                    _enVentas.fcCiudad = FcCiudad.Text.ToString();
                    _enVentas.fcTelefono = FcTelefono.Text.ToString();
                    _enVentas.fcFechaPago = FdFechaPago.Text.ToString();//Cambio de Variable a fecha de pago porque guardaba el domicilio 08/03/19
                    _enVentas.fiCantidad = Int32.Parse(txtCantidad.Text); // Evitar que guarde 1 y guarde la cantidad agregada 08/03/19
                    //_enVentas.fiCantidad = 1; // cantidad? aqui es un elemento nada mas.. osease lo unico que puedo meter es la cantidad total de articulos adquiridos en conjunto.. no individuales
                    _enVentas.fcConcepto = txtNombre.Text.ToString();//Campo del nombre del producto 08/03/19
                    _enVentas.fdPrecioUnitario = decimal.Parse(txtPrecioDeContado.Text);//(FdTotal.Text);//Haber que hace 08/08/19

                    // aqui ayudame con un if

                    if (true) // si preciona el boton de imprimir y contado que le debuelva el objeto de douTotalSumaProductosCredito, 
                              //en caso de lo contrario que le devuelba el objeto douTotalSumaProductos.. son doubles
                    {//Prueba
                        intCantidadProducto = double.Parse(txtCantidad.Text.ToString().Trim());
                        doTotalSumaProductosCredito = douTotalSumaProductosCredito + intCantidadProducto;
                    }
                    else
                    {
                        // doTotalSumaProductos = douTotalSumaProductos + intCantidadProducto;

                    }

                    _enVentas.fdTotal = decimal.Parse(FdTotal.Text);
                    _enVentas.fdImporte = decimal.Parse(txtImporte.Text);//Total a pagar de importe

                    int RespuestaTipoVenta = _ventasBL.AgregarVenta(_enVentas);

                    if (!RespuestaTipoVenta.Equals(null))
                    {


                        foreach (DataGridViewRow producto in dgTotalProductos.Rows)
                        {
                                                       

                                strNombreModificado = producto.Cells[1].Value.ToString();
                                intCantidadModificada = int.Parse(producto.Cells[2].Value.ToString());
                                strIdProductoComparar = producto.Cells[0].Value.ToString();

                                foreach (var productoInventario in _inventarioBl.MostrarInventario())
                                {
                                    _en.IdProducto = productoInventario.IdProducto;
                                    _en.NombreProducto = productoInventario.NombreProducto;
                                    _en.GrupoPertenenciente = productoInventario.GrupoPertenenciente;
                                    _en.Cantidad = productoInventario.Cantidad;
                                    _en.Presentacion = productoInventario.Presentacion;
                                    _en.CostoUnitario = productoInventario.CostoUnitario;
                                    _en.PrecioContado = productoInventario.PrecioContado;
                                    _en.PrecioACredito = productoInventario.PrecioACredito;

                                    if (strNombreModificado.Equals(_en.NombreProducto.ToString()) && strIdProductoComparar.Equals(_en.IdProducto.ToString()))
                                    {
                                        _en.Cantidad = _en.Cantidad - intCantidadModificada;
                                        _inventarioBl.ModificarProducto(_en);
                                    }

                                }

                            }
                        FNotaVenta fNuevaNotaVenta = new FNotaVenta();
                        fNuevaNotaVenta.llenarNota(_enVentas, dgTotalProductos, strtipoDeVenta, strTotalAPagarCredito);
                        MessageBox.Show("¡Se realizó la venta correctamente!", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpiar();
                        Limpiar_Venta();
                    }

                   
                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }

            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //PrevioImprecion.Document = ImprecionNota;
            //PrevioImprecion.ShowDialog();

            FNotaVenta nuevaNota = new FNotaVenta();
            nuevaNota.ShowDialog();
        }

        private void ImprecionNota_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FNotaVenta _FNotaVenta = new FNotaVenta();
            Image bmp = _FNotaVenta.CaptureScreen();
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)//Venta a credito 08/03/19
        {
            try
            {
                strtipoDeVenta = "2";
                Inventario _en = new Inventario();
                InventarioBL _inventarioBl = new InventarioBL();

                //Variables del Metodo
                double doTotalSumaProductos;
                double doTotalSumaProductosCredito;
                double intCantidadProducto;
                int intCantidadProductoafectarInventario = 0;
                string strNombreModificado = string.Empty;
                string strIdProductoComparar = string.Empty;
                int intCantidadModificada = 0;
                int iteracion = 1;


                if (!FdFechaPago.Equals(string.Empty))
                {


                    _enVentas.fDtFechaSalida = FdFechaSalida.Text.ToString();
                    _enVentas.fcNombreCliente = FcNombreCliente.Text.ToString();
                    _enVentas.fcDomicilio = FcDomicilio.Text.ToString();
                    _enVentas.fcCiudad = FcCiudad.Text.ToString();
                    _enVentas.fcTelefono = FcTelefono.Text.ToString();
                    _enVentas.fcFechaPago = FdFechaPago.Text.ToString();//Tenia FcDomicilio cambio de variable 08/03/19
                    //_enVentas.fiCantidad = txtCantidad.Text.ToString(); // de prueba
                    _enVentas.fiCantidad = Int32.Parse(txtCantidad.Text);//Agregado para ver si guarda el dato correcto, cambio de variable 08/03/19
                    //_enVentas.fiCantidad = 1; // cantidad? aqui es un elemento nada mas.. osease lo unico que puedo meter es la cantidad total de articulos adquiridos en conjunto.. no individuales
                    _enVentas.fcConcepto = txtNombre.Text.ToString();//Obtiene el valor de la venta mas no de la busqueda 08/03/19
                    _enVentas.fdPrecioUnitario = decimal.Parse(txtTotalAPagarCredito.Text);//Precio por unidad 08/03/19

                    // aqui ayudame con un if

                    if (true) // si preciona el boton de imprimir y contado que le debuelva el objeto de douTotalSumaProductosCredito, 
                              //en caso de lo contrario que le devuelba el objeto douTotalSumaProductos.. son doubles
                    {//Prueba
                        intCantidadProducto = double.Parse(txtCantidad.Text.ToString().Trim());
                        doTotalSumaProductosCredito = douTotalSumaProductosCredito + intCantidadProducto;
                    }
                    else
                    {
                        // doTotalSumaProductos = douTotalSumaProductos + intCantidadProducto;

                    }

                    _enVentas.fdTotal = decimal.Parse(FdTotal.Text);//Haber que hace
                    _enVentas.fdImporte = decimal.Parse(txtImporte.Text);//Haber que hace 09/03/19

                    int RespuestaTipoVenta = _ventasBL.AgregarVenta(_enVentas);

                    if (!RespuestaTipoVenta.Equals(null))
                    {


                        foreach (DataGridViewRow producto in dgTotalProductos.Rows)
                        {
                            
                                strNombreModificado = producto.Cells[3].Value.ToString();
                                intCantidadModificada = int.Parse(producto.Cells[1].Value.ToString());
                                strIdProductoComparar = producto.Cells[4].Value.ToString();

                                foreach (var productoInventario in _inventarioBl.MostrarInventario())
                                {
                                    _en.IdProducto = productoInventario.IdProducto;
                                    _en.NombreProducto = productoInventario.NombreProducto;
                                    _en.GrupoPertenenciente = productoInventario.GrupoPertenenciente;
                                    _en.Cantidad = productoInventario.Cantidad;
                                    _en.Presentacion = productoInventario.Presentacion;
                                    _en.CostoUnitario = productoInventario.CostoUnitario;
                                    _en.PrecioContado = productoInventario.PrecioContado;
                                    _en.PrecioACredito = productoInventario.PrecioACredito;

                                    if (strNombreModificado.Equals(_en.NombreProducto.ToString()) && strIdProductoComparar.Equals(_en.IdProducto.ToString()))
                                    {
                                        _en.Cantidad = _en.Cantidad - intCantidadModificada;
                                        _inventarioBl.ModificarProducto(_en);
                                    }

                                }

                            }
                        FNotaVenta fNuevaNotaVenta = new FNotaVenta();
                        fNuevaNotaVenta.llenarNota(_enVentas, dgTotalProductos, strtipoDeVenta, strTotalAPagarContado);
                        MessageBox.Show("¡Se realizó la venta correctamente!", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Limpiar();
                        Limpiar_Venta();

                    }

                }
                else
                {
                    MessageBox.Show("Favor de llenar todos los campos", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void bNuevaVenta_Click(object sender, EventArgs e)//Direccionar al from de ventas para crear una nueva venta.. 08/03/19.
        {
            Form _fVender = new FVentas();
            _fVender.Show();
            this.Close();
        }

        private void FVentas_Load(object sender, EventArgs e)//Agregado para poner automaticamente la fecha en cuanto se inicie el from 08/03/19
        {
            FdFechaSalida.Text = DateTime.Now.ToString();
        }

        private void dgTotalProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
