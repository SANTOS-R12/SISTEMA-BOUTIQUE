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
using System.Net;
using System.Net.Mail;
using DGVPrinterHelper;
using System.IO;

namespace SISTEMA
{
    public partial class Proveedores : Form
    {
        public object CS = -1;
        public int idpro = -1;
        private proveedor _proveedor;
        String nombre, apellido, telefono, direccion, estado;
        private readonly ProveedorBOL _ProveedorBOL = new ProveedorBOL();
        //funcion
        public void TodosLosProveedores()
        {
            List<proveedor> proveedores = _ProveedorBOL.ConsultarTodos();
            if (proveedores.Count > 0)
            {
                tblProveedor.DataSource = proveedores;
            }
            else
            {
                MessageBox.Show("No hay Proveedores");
            }
        }
        public void LlenarGruid()
        {
            List<proveedor> proveedores = _ProveedorBOL.ConsultarTodos();
            if (proveedores.Count > 0)
            {
               tblProveedor.DataSource = proveedores;
            }
            else
            {
                MessageBox.Show(":v");
            }
        }
        public Proveedores()
        {
            InitializeComponent();
        }

      

        private void Proveedores_Load(object sender, EventArgs e)
        {
            tblProveedor.AutoGenerateColumns = true;
      
            TodosLosProveedores();
            this.tblProveedor.Columns["pedido"].Visible = false;  //Para ocultar un dato de la tabla proveedor
            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
            tabControl1.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre del Proveedor", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Apellido del Proveedor", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTelefono.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Telefóno del Proveedor", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDireccion.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Dirección del Proveedor", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _proveedor = new proveedor();

                _proveedor.nombre = txtNombre.Text;
                _proveedor.apellido = txtApellido.Text;
                _proveedor.telefono = txtTelefono.Text;
                _proveedor.direccion = txtDireccion.Text;
                _ProveedorBOL.registrar(_proveedor);              
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                TodosLosProveedores();
            }
            
        }
        public void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esta seguro de Eliminar al Proveedor Seleccionado", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                _ProveedorBOL.Eliminar(Convert.ToInt32(CS));
                int vartemp = Convert.ToInt32(tblProveedor.CurrentRow.Cells[0].Value);
                LlenarGruid();
                if (Convert.ToInt32(tblProveedor.CurrentRow.Cells[0].Value) == vartemp)
                {
                    MessageBox.Show("No se puede Eliminar, debido a la integridad referencial");
                }
                tblProveedor.ClearSelection();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtUPNombre.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre del Proveedor", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUPApellido.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Apellido del Proveedor", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUPtelefono.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Telefóno del Proveedor", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUPDireccion.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Dirección del Proveedor", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _proveedor = new proveedor();
                _proveedor.nombre = txtUPNombre.Text;
                _proveedor.apellido = txtUPApellido.Text;
                _proveedor.direccion = txtUPDireccion.Text;
                _proveedor.telefono = txtUPtelefono.Text;
                _proveedor.id_proveedor = Convert.ToInt32(CS);

                _ProveedorBOL.registrar(_proveedor);
                txtUPNombre.Clear();
                txtUPApellido.Clear();
                txtUPDireccion.Clear();
                txtUPtelefono.Clear();
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                TodosLosProveedores();
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], true);
                tblProveedor.Enabled = true;
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUpdateApellido.Clear();
            txtUpdateDireccion.Clear();
            txtUpdateNombre.Clear();
            txtUpdateTelefono.Clear();
        }

        private void tblProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string rutaCompleta = Application.StartupPath.ToString();
            string rutaNueva = rutaCompleta.Replace(@"\bin\Debug", @"\Reportes");
            string rutaArchivo = rutaNueva + @"\Proveedores.pdf";
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Esmeralda's Boutique";
            printer.SubTitle = string.Format("Reporte de Proveedores");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.FooterColor = Color.LightPink;

            if (File.Exists(rutaArchivo))
            {
                File.Delete(Path.Combine(rutaNueva, @"Proveedores.pdf"));
            }
            printer.PrintNoDisplay(tblProveedor);
            if (File.Exists(rutaArchivo))
            {
                MessageBox.Show("Operación Exitosa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MailMessage msg = new MailMessage("esmeraldaboutique23@gmail.com", "esmeraldaboutique23@gmail.com", "Reporte de Proveedores", "<h1>Listado de Proveedors</h1>");
                msg.IsBodyHtml = true;
                Attachment attachment = new Attachment(rutaNueva + @"\\Proveedores.pdf");
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
        private void tblProveedor_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Actualizar al Proveedor Seleccionado", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], false);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], true);
                //tabControl1.SelectedIndex = 1;
                String nombreCompleto = tblProveedor.CurrentRow.Cells["nombre"].Value.ToString();
                String[] cadena = nombreCompleto.Split(',');
                nombre = cadena[0];
                apellido = tblProveedor.CurrentRow.Cells["apellido"].Value.ToString();
                direccion = tblProveedor.CurrentRow.Cells["direccion"].Value.ToString();
                telefono = tblProveedor.CurrentRow.Cells["telefono"].Value.ToString();
                CS= tblProveedor.CurrentRow.Cells["id_proveedor"].Value;
                txtUPNombre.Text = nombre;
                txtUPApellido.Text = apellido;
                txtUPtelefono.Text = telefono;
                txtUPDireccion.Text = direccion;
            }
            else
            {
                CS = tblProveedor.CurrentRow.Cells["id_proveedor"].Value;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TodosLosProveedores();

        }
    }
}
