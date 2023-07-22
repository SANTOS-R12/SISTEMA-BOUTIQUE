using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Collections;
using System.Drawing.Printing;
using DGVPrinterHelper;
using System.IO;
using System.Threading;
using System.Reflection;
using Microsoft.VisualBasic;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;

namespace SISTEMA
{
    public partial class frmNuevaVenta : Form
    {
        string dui = "";
        public int categoriaSeleccionada = -1, pxc = 0, cantidad = 0, cantidadLimite = 0, idsaldo = 0;
        public decimal total = 0, subtotal = 0, descuento = 0, precio;
        private cliente _cliente;
        private readonly ClienteBOL _ClientesBOL = new ClienteBOL();
        private categoria _categoria;
        private readonly CategoriaBOL _CategoriaBOL = new CategoriaBOL();
        private producto _producto;
        private readonly ProductoBOL _ProductoBOL = new ProductoBOL();
        private saldo_P _saldop;
        private readonly SaldoBOL _SaldoBOL = new SaldoBOL();
        String fecha = "";
        String nombreCliente = "";
        Int16 idVenta = 0;
        public struct comprador
        {
            public string NombreComprador;
            public string VentaTotal;
            public string VentaCobrada;
            public string Restante;
            public ArrayList ProductosComprados;
            public ArrayList DescripcionProductos;
            public ArrayList CantidadProductos;
        };
        comprador _comprador = new comprador();

        //Funciones
        public void CargarCategorias()
        {
            cmbCategoria.Items.Clear();
            List<categoria> categorias = _CategoriaBOL.ConsultarNombres();
            cmbCategoria.Items.Add("");
            foreach (var nombres in categorias)
            {
                cmbCategoria.Items.Add(nombres.nombre);
            }
            
        }
        public void Restablecer()
        {
            categoriaSeleccionada = -1;
            pxc = 0;
            cantidad = 0;
            precio = 0;
            descuento = 0;
            subtotal = 0;
            total = 0;
            dui = "";
            LimpiarLabels();
            txtEmail.Clear();
            txtPago.Clear();
            txtSubtotal.Clear();
            txtTotal.Clear();
            dgvProductos.Rows.Clear();
            mskDui.ReadOnly = false;
            btnBuscarDUI.Enabled = true;
            grpProducto.Enabled = false;
            btnCambiar.Enabled = false;
            grpCliente.Enabled = true;
            grpPago.Enabled = false;
            txtPago.ReadOnly = false;
            btnPagar.Enabled = true;
            btnCancelarPago.Enabled = true;
            lblMensajePago.Text = "";
            cmbCategoria.Items.Clear();
            cmbCantProducto.Items.Clear();
            cmbDescripcion.Items.Clear();
            cmbPrecioxProducto.Items.Clear();
            cmbProducto.Items.Clear();
            numCantidad.Value = 1;
            numDescuento.Value = 0;
        }
        public void pagarmora()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Prompt", "Title", "Default", 0, 0);
            decimal moraxCobrar = Convert.ToDecimal(input);
            if (moraxCobrar < _saldop.pendiente)
            {
                MessageBox.Show("La cantidad ingresada es menor, favor ingrese el cobro del pago pendiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pagarmora();
            }
            else
            {
                MessageBox.Show("Pago realizado con exito, puede continuar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _cliente.estado = "A";
                _cliente.id_saldop = 1;
                _ClientesBOL.registrar(_cliente);
            }
        }
        public void recargarCliente()
        {
            _cliente = _ClientesBOL.ObtnerporDui(dui);
            lblCliNom.Text = _cliente.nombre;
            lblCliApe.Text = _cliente.apellido;
            lblCliTel.Text = _cliente.telefono;
            lblCliDir.Text = _cliente.direccion;
            btnCambiar.Enabled = true;
            mskDui.ReadOnly = true;
            btnBuscarDUI.Enabled = false;
            grpProducto.Enabled = true;
        }
        public void ClientesxDUI()
        {
            if (mskDui.Text == "")
            {
                MessageBox.Show("Ingrese un DUI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dui = mskDui.Text;
                try
                {
                    recargarCliente();
                    if (_cliente.estado == "B")
                    {
                        _saldop = _SaldoBOL.ObtnerMoraPorDui(dui);
                        string debe = "Para contunuar con el proceso de venta con el cliente " + _cliente.nombre + ", se debe de haber pagado cualquier cuota de compra de anterior."
                            + "\n\r Mora del cliente: " + Convert.ToString(_saldop.pendiente);
                        MessageBox.Show(debe, "El cliente ingresado aun debe un pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (DialogResult.Yes == MessageBox.Show("Desea realizar el pago faltante?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor de la mora a cancelar", "Pagar mora", "0.00", 0, 0);
                            decimal moraxCobrar = Convert.ToDecimal(input);
                            if (moraxCobrar < _saldop.pendiente)
                            {
                                MessageBox.Show("La cantidad ingresada es menor, favor ingrese el cobro del pago pendiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                pagarmora();
                            }
                            else
                            {
                                MessageBox.Show("Pago realizado con exito, puede continuar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                _cliente.estado = "A";
                                _cliente.id_saldop = 1;
                                _ClientesBOL.registrar(_cliente);
                                recargarCliente();
                            }
                        }
                    }
                    else
                    {
                        recargarCliente();
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("DUI no encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskDui.Clear();
                }
            }
        }
        public void LimpiarLabels()
        {
            lblCliNom.Text = "";
            lblCliApe.Text = "";
            lblCliTel.Text = "";
            lblCliDir.Text = "";
        }
        public void restarInventario2()
        {
            for (int i = 0; i < pxc; i++)
            {
                cantidad = Convert.ToInt32(dgvProductos.Rows[i].Cells["colCantidad"].Value.ToString());
                cantidadLimite = Convert.ToInt32(dgvProductos.Rows[i].Cells["colLimite"].Value.ToString());
                int nuevaCantidad = cantidadLimite - cantidad;
                _producto.nombrePro = dgvProductos.Rows[i].Cells["colProducto"].Value.ToString();
                _producto.precio = Convert.ToDecimal(dgvProductos.Rows[i].Cells["colPrecio"].Value.ToString());
                _producto.cantidad = nuevaCantidad;
                _producto.descripcion = dgvProductos.Rows[i].Cells["colDescripcion"].Value.ToString();
                _producto.id_producto = Convert.ToInt32(dgvProductos.Rows[i].Cells["colProdId"].Value.ToString());
                _producto.id_categoria = Convert.ToInt32(dgvProductos.Rows[i].Cells["colCatId"].Value.ToString());
                _ProductoBOL.registrar(_producto);
            }
        }
        public void restarInventario()//llenado parcial del struct
        {
            _producto = new producto();
            pxc = dgvProductos.Rows.Count;
            /* if (_comprador.CantidadProductos == null
                 && _comprador.ProductosComprados == null)
             {
                 restarInventario2();
             }
             else
             {
                 //_comprador.CantidadProductos.Clear();
                // _comprador.ProductosComprados.Clear();
                 restarInventario2();
             }*/
            for (int i = 0; i < pxc; i++)
            {
                cantidad = Convert.ToInt32(dgvProductos.Rows[i].Cells["colCantidad"].Value.ToString());
                //_comprador.CantidadProductos.Add(cantidad);
                cantidadLimite = Convert.ToInt32(dgvProductos.Rows[i].Cells["colLimite"].Value.ToString());
                int nuevaCantidad = cantidadLimite - cantidad;
                _producto.nombrePro = dgvProductos.Rows[i].Cells["colProducto"].Value.ToString();
                //_comprador.ProductosComprados.Add(_producto.nombrePro);
                _producto.precio = Convert.ToDecimal(dgvProductos.Rows[i].Cells["colPrecio"].Value.ToString());
                _producto.cantidad = nuevaCantidad;
                _producto.descripcion = dgvProductos.Rows[i].Cells["colDescripcion"].Value.ToString();
                //_comprador.DescripcionProductos.Add(_producto.descripcion);
                _producto.id_producto = Convert.ToInt32(dgvProductos.Rows[i].Cells["colProdId"].Value.ToString());
                _producto.id_categoria = Convert.ToInt32(dgvProductos.Rows[i].Cells["colCatId"].Value.ToString());
                _ProductoBOL.registrar(_producto);
            }

        }

        //
        public frmNuevaVenta()
        {
            InitializeComponent();
        }

        private void btnBuscarDUI_Click(object sender, EventArgs e)
        {
            ClientesxDUI();
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            rdbNo.Checked = true;

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            LimpiarLabels();
            mskDui.ReadOnly = false;
            btnBuscarDUI.Enabled = true;
            grpProducto.Enabled = false;
            btnCambiar.Enabled = false;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProducto.Items.Clear();
            cmbDescripcion.Items.Clear();
            cmbCantProducto.Items.Clear();
            cmbPrecioxProducto.Items.Clear();
            cmbIdCategoria.Items.Clear();
            cmbIdProducto.Items.Clear();
            categoriaSeleccionada = cmbCategoria.SelectedIndex;
            List<producto> productos = _ProductoBOL.ConsultarTodos();
            foreach (var proxcat in productos)
            {
                if (proxcat.id_categoria == categoriaSeleccionada)
                {
                    cmbProducto.Items.Add(proxcat.nombrePro);
                    cmbDescripcion.Items.Add(proxcat.descripcion);
                    cmbCantProducto.Items.Add(proxcat.cantidad);
                    cmbPrecioxProducto.Items.Add(proxcat.precio);
                    cmbIdCategoria.Items.Add(proxcat.id_categoria);
                    cmbIdProducto.Items.Add(proxcat.id_producto);
                }
            }
            cmbProducto.Enabled = true;
            //cmbPrecioxProducto.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int descripcion = cmbProducto.SelectedIndex;
            cmbDescripcion.SelectedIndex = descripcion;
            cmbCantProducto.SelectedIndex = descripcion;
            cmbPrecioxProducto.SelectedIndex = descripcion;
            cmbIdCategoria.SelectedIndex = descripcion;
            cmbIdProducto.SelectedIndex = descripcion;
            cantidadLimite = Convert.ToInt32(cmbCantProducto.SelectedItem.ToString());
            if (numCantidad.Value <= cantidadLimite)
            {
                dgvProductos.Rows.Add(cmbProducto.SelectedItem, cmbDescripcion.SelectedItem, cmbPrecioxProducto.SelectedItem,
                                numCantidad.Value, cmbIdCategoria.SelectedItem, cmbIdProducto.SelectedItem, cantidadLimite, cmbCategoria.SelectedItem);
                numCantidad.Value = 1;
                cmbProducto.Items.RemoveAt(descripcion);
                cmbDescripcion.Items.RemoveAt(descripcion);
                cmbCantProducto.Items.RemoveAt(descripcion);
                cmbPrecioxProducto.Items.RemoveAt(descripcion);
                cmbIdCategoria.Items.RemoveAt(descripcion);
                cmbIdProducto.Items.RemoveAt(descripcion);
                if (cmbProducto.Items.Count == 0)
                {
                    cmbCategoria.Items.RemoveAt(categoriaSeleccionada);
                }
                btnProceder.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se pude agregar, debido a que la cantidad seleccionada supera la cantidad de inventario",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal cobrado = Convert.ToDecimal(txtPago.Text);
            total = subtotal - ((subtotal * descuento) / 100);
            decimal restante = total - cobrado;
            txtPago.ReadOnly = true;
            btnPagar.Enabled = false;
            btnCancelarPago.Enabled = false;
            btnNueva.Focus();
            restarInventario();

            if (restante > 0)
            {
                lblMensajePago.ForeColor = Color.Red;
                lblMensajePago.Text = "Pago incompleto \r\n debera la canitdad de $" + restante;
                _saldop = new saldo_P();
                _saldop.importe = total;
                _saldop.cobrado = cobrado;
                _saldop.pendiente = restante;
                _SaldoBOL.registrar(_saldop);
                List<saldo_P> slds = _SaldoBOL.ObtenerID();
                foreach (var sld in slds)
                {
                    idsaldo = sld.id_saldop;
                }
                _cliente.nombre = lblCliNom.Text;
                _cliente.apellido = lblCliApe.Text;
                _cliente.dui = mskDui.Text;
                _cliente.telefono = lblCliTel.Text;
                _cliente.direccion = lblCliDir.Text;
                _cliente.estado = "B";
                _cliente.id_saldop = idsaldo;
                _ClientesBOL.registrar(_cliente);
                MessageBox.Show("actualizado");
            }
            else
            {
                lblMensajePago.ForeColor = Color.Green;
                lblMensajePago.Text = "Transaccion exitosa, vuelto:" + (restante * -1).ToString();
                //limpiar y restablecer
            }

            if (rdbSi.Checked)
            {

                decimal res = restante;
                if (restante < 0)
                {
                    res = 0;
                }
                string nomComprador = lblCliNom.Text + " " + lblCliApe.Text;
                string rutaCompleta = Application.StartupPath.ToString();
                string rutaNueva = rutaCompleta.Replace(@"\bin\Debug", @"\Reportes");
                string rutaArchivo = rutaNueva + @"\Factura.pdf";
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Esmeralda's Boutique";
                printer.SubTitle = string.Format("Factura de compra: {0}", DateTime.Now.Date);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = false;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.FooterSpacing = 15;
                printer.Footer = "Comprador: " + nomComprador;
                printer.FooterColor = Color.LightPink;

                if (File.Exists(rutaArchivo))
                {
                    File.Delete(Path.Combine(rutaNueva, @"Factura.pdf"));
                    printer.PrintNoDisplay(dgvProductos);
                    if (File.Exists(rutaArchivo))
                    {
                        ok frm_ok = new ok();
                        string mensaje = lblMail.Text;
                        mensaje = mensaje.Replace("mundo", nomComprador).Replace("saldo", total.ToString("##.##"));
                        frm_ok.ShowDialog();
                        MailMessage msg = new MailMessage("esmeraldaboutique23@gmail.com", txtEmail.Text, "Factura de compra", mensaje);
                        msg.IsBodyHtml = true;
                        Attachment attachment = new Attachment(rutaNueva + @"\\Factura.pdf");
                        msg.Attachments.Add(attachment);
                        SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                        sc.UseDefaultCredentials = false;
                        NetworkCredential cre = new NetworkCredential("esmeraldaboutique23@gmail.com", "B0utiqu3");
                        sc.Credentials = cre;
                        sc.EnableSsl = true;
                        sc.Send(msg);
                        MessageBox.Show("Factura enviada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void btnCancelarPago_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esta seguro de cancelar el pago?", "Informacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Restablecer();
                CargarCategorias();
                MessageBox.Show("Se ha cancelado la venta exitosamente", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Restablecer();
            CargarCategorias();
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int row = dgvProductos.CurrentCell.RowIndex;
            int result = 0;
            foreach (var item in cmbCategoria.Items)
            {
                if (item.ToString() == dgvProductos.Rows[row].Cells["colCategoria"].Value.ToString())
                {
                    result += 1;
                }
            }
            if (result == 0)
            {
                cmbCategoria.Items.Add(dgvProductos.Rows[row].Cells["colCategoria"].Value.ToString());
                cmbCategoria.SelectedItem = dgvProductos.Rows[row].Cells["colCategoria"].Value.ToString();
            }
            cmbProducto.Items.Add(dgvProductos.Rows[row].Cells["colProducto"].Value.ToString());
            cmbDescripcion.Items.Add(dgvProductos.Rows[row].Cells["colDescripcion"].Value.ToString());
            cmbPrecioxProducto.Items.Add(dgvProductos.Rows[row].Cells["colPrecio"].Value.ToString());
            cmbIdCategoria.Items.Add(dgvProductos.Rows[row].Cells["colCatId"].Value.ToString());
            cmbIdProducto.Items.Add(dgvProductos.Rows[row].Cells["colProdId"].Value.ToString());
            cmbCantProducto.Items.Add(dgvProductos.Rows[row].Cells["colLimite"].Value.ToString());
            dgvProductos.Rows.RemoveAt(row);
        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmail.Enabled = true;
        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtEmail.Enabled = false;
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            CargarCategorias();
        }

        private void chkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescuento.Checked)
            {
                numDescuento.Enabled = true;
            }
            else
            {
                numDescuento.Enabled = false;
                total = 0;
                numDescuento.Value = 0;
            }
        }

        private void numDescuento_ValueChanged(object sender, EventArgs e)
        {
            txtTotal.Clear();
            descuento = numDescuento.Value;
            total = subtotal - ((subtotal * descuento) / 100);
            txtTotal.Text = "$" + total.ToString();
        }

        private void btnProceder_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnProceder.Enabled = false;
            }
            else
            {
                grpProducto.Enabled = false;
                dgvProductos.Enabled = false;
                btnCambiar.Enabled = false;
                grpPago.Enabled = true;
                pxc = dgvProductos.Rows.Count;
                for (int i = 0; i < pxc; i++)
                {
                    precio = Convert.ToDecimal(dgvProductos.Rows[i].Cells["colPrecio"].Value.ToString());
                    cantidad = Convert.ToInt32(dgvProductos.Rows[i].Cells["colCantidad"].Value.ToString());
                    subtotal += (precio * cantidad);
                }
                txtSubtotal.Text = "$" + subtotal.ToString();
                txtTotal.Text = "$" + subtotal.ToString();
            }

        }
    }
}
