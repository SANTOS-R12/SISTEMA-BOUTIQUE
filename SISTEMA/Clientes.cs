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
using System.IO;
using DGVPrinterHelper;
using System.Net;
using System.Net.Mail;


namespace SISTEMA
{
    public partial class Clientes : Form
    {
        public string CS = "";
        String nombre, apellido, telefono, direccion, estado;
        string dui ="";
        private cliente _cliente;
        private readonly ClienteBOL _ClientesBOL = new ClienteBOL();
        //funcion
        public void TodosLosClientes()
        {
            List<cliente> clientes = _ClientesBOL.ConsultarTodos();
            if (clientes.Count > 0)
            {
                tblClientes.DataSource = clientes;
            }
            else
            {
                MessageBox.Show("No hay Clientes");
            }
        }

        public void LlenarGruid()
        {
            List<cliente> clientes = _ClientesBOL.ConsultarTodos();
            if (clientes.Count > 0)
            {
                tblClientes.DataSource = clientes;
            }
            else
            {
                MessageBox.Show(":v");
            }
        }

        public void ClientesxDUI()
        {
            tblClientes.Enabled = true;
            if (mskDui.Text == "")
            {
                MessageBox.Show("Ingrese un DUI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Ingrese un DUI");
            }
            else
            {
                dui = mskDui.Text;
                _cliente = _ClientesBOL.ObtnerporDui(dui);
                List<cliente> clientes = new List<cliente>();
                string tempclie ="0" +_cliente.dui;
               // _cliente.dui = Convert.ToInt32(tempclie);
                clientes.Add(_cliente);
                tblClientes.DataSource = clientes;
                if (clientes.Count > 0)
                {
                    mskDui.Clear();
                }
                else
                {
                    MessageBox.Show("No hay Clientes");
                    tblClientes.Enabled = false;
                }
            }
        }
        public void limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            mskRDUI.Clear();
            txtdireccion.Clear();
        }

        //Codigo

        public Clientes()
        {
            InitializeComponent();
        }
        
        private void Clientes_Load(object sender, EventArgs e)
        {
            tblClientes.AutoGenerateColumns = true;
            TodosLosClientes();           
            this.tblClientes.Columns["saldo_P"].Visible = false;  //Para ocultar un dato de la tabla clientes
            this.tblClientes.Columns["venta"].Visible = false;  //Para ocultar un dato de la tabla clientes
            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
            tabControl1.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre del Cliente", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtapellido.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Apellido del Cliente", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txttelefono.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Telefóno del Cliente", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mskRDUI.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el DUI del Cliente", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtdireccion.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Dirección del Cliente", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _cliente = new cliente();

                _cliente.nombre = txtnombre.Text;
                _cliente.apellido = txtapellido.Text;
                _cliente.telefono = txttelefono.Text;
                _cliente.dui = mskRDUI.Text;
                _cliente.direccion = txtdireccion.Text;
                _ClientesBOL.registrar(_cliente);              
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tblClientes.Enabled = true;
                limpiar();
                TodosLosClientes();
            }    
        }

        private void button10_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TodosLosClientes();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            ClientesxDUI();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            TodosLosClientes();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LlenarGruid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esta seguro de Eliminar al cliente Seleccionado", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                _ClientesBOL.Eliminar(CS);
                int vartemp = Convert.ToInt32(tblClientes.CurrentRow.Cells[0].Value);
                LlenarGruid();
                if (Convert.ToInt32(tblClientes.CurrentRow.Cells[0].Value) == vartemp)
                {
                    MessageBox.Show("No se puede Eliminar, debido a la integridad referencial");
                }
                tblClientes.ClearSelection();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void tblClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtBusquedaDUI.Enabled = true;
            }
            else
            {
                txtBusquedaDUI.Enabled = false;
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtapel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string rutaCompleta = Application.StartupPath.ToString();
            string rutaNueva = rutaCompleta.Replace(@"\bin\Debug", @"\Reportes");
            string rutaArchivo = rutaNueva + @"\Clientes.pdf";
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Esmeralda's Boutique";
            printer.SubTitle = string.Format("Reporte de Clientes");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.FooterColor = Color.LightPink;
            if (File.Exists(rutaArchivo))
            {
                File.Delete(Path.Combine(rutaNueva, @"Clientes.pdf"));
            }
            printer.PrintNoDisplay(tblClientes);
            if (File.Exists(rutaArchivo))
            {
                MessageBox.Show("Operación Exitosa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MailMessage msg = new MailMessage("esmeraldaboutique23@gmail.com", "esmeraldaboutique23@gmail.com", "Reporte de Clientes", "<h1>Listado de clientes</h1>");
                msg.IsBodyHtml = true;
                Attachment attachment = new Attachment(rutaNueva + @"\\Clientes.pdf");
                msg.Attachments.Add(attachment);
                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.UseDefaultCredentials = false;
                NetworkCredential cre = new NetworkCredential("esmeraldaboutique23@gmail.com", "B0utiqu3");
                sc.Credentials = cre;
                sc.EnableSsl = true;
                sc.Send(msg);
                MessageBox.Show("Reporte Enviado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void EnableTab(TabPage page, bool enable)
        {
            EnableControls(page.Controls, enable);
        }

        private static void EnableControls(Control.ControlCollection ctls, bool enable)
        {
            foreach (Control ctl in ctls)
            {
                ctl.Enabled = enable;
                EnableControls(ctl.Controls, enable);
            }
        }

        private void btnGuardar2_Click_1(object sender, EventArgs e)
        {
            if (txtnom.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre del Cliente", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtapel.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Apellido del Cliente", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTel.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Telefóno del Cliente", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtBusquedaDUI.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el DUI del Cliente", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDir.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Dirección del Cliente", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _cliente = new cliente();

                _cliente.dui = txtBusquedaDUI.Text;
                _cliente.nombre = txtnom.Text;
                _cliente.apellido = txtapel.Text;
                _cliente.direccion = txtDir.Text;
                _cliente.telefono = txtTel.Text;
                _cliente.id_saldop = 1;
                _cliente.estado = cmbEstado.SelectedItem.ToString();
                _ClientesBOL.registrar(_cliente);
                txtnom.Clear();
                txtapel.Clear();
                txtBusquedaDUI.Clear();
                txtDir.Clear();
                txtTel.Clear();
                cmbEstado.SelectedIndex = -1;
                //Exito frm_exito = new Exito();
                //frm_exito.ShowDialog();
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TodosLosClientes();
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], true);
                tblClientes.Enabled = true;
            }
           
        }


        private void tblClientes_Click(object sender, EventArgs e)
        {         
            if (DialogResult.Yes == MessageBox.Show("Desea Actualizar al cliente Seleccionado", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], false);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], true);
                //tabControl1.SelectedIndex = 1;
                String nombreCompleto = tblClientes.CurrentRow.Cells["nombre"].Value.ToString();
                String[] cadena = nombreCompleto.Split(',');
                nombre = cadena[0];
                apellido = tblClientes.CurrentRow.Cells["apellido"].Value.ToString();
                direccion = tblClientes.CurrentRow.Cells["direccion"].Value.ToString();
                telefono = tblClientes.CurrentRow.Cells["telefono"].Value.ToString();
                dui = tblClientes.CurrentRow.Cells["dui"].Value.ToString();
                estado = tblClientes.CurrentRow.Cells["estado"].Value.ToString();
                txtnom.Text = nombre;
                txtapel.Text = apellido;
                txtTel.Text = telefono;
                txtBusquedaDUI.Text =  dui.ToString();
                txtBusquedaDUI.Enabled = false;
                txtDir.Text = direccion;
                cmbEstado.SelectedItem = estado;
            }
            else
            {
                CS = tblClientes.CurrentRow.Cells["dui"].Value.ToString();
            }
        }
    }
}
