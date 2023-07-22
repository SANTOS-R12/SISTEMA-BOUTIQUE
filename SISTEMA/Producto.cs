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
using SortOrder = System.Windows.Forms.SortOrder;
using System.Runtime.InteropServices; //Para mover todo un formulario que tieme panel
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using DGVPrinterHelper;
using System.IO;

namespace SISTEMA
{
    public partial class Producto : Form
    {
        public object CS = -1, id_pro =-1;
       decimal precio;
        String  nombrePro,desc, cant, id_categoria;
        //string dui = "";
        private producto _producto;
        private readonly ProductoBOL _ProductoBOL = new ProductoBOL();
        //funcion
        public void TodosLosProductos()
        {
            List<producto> productos = _ProductoBOL.ConsultarTodos();
            if (productos.Count > 0)
            {
                tblProd.DataSource = productos;
            }
            else
            {
                MessageBox.Show("no hay productos");
            }
        }
        public Producto()
        {
            InitializeComponent();
            seleccionar(cmbCat);
            seleccionar(cmbCat2);
        }

        public void LlenarGruid()
        {
            List<producto> productos = _ProductoBOL.ConsultarTodos();
            if (productos.Count > 0)
            {
                tblProd.DataSource = productos;
            }
            else
            {
                MessageBox.Show(":v");
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
        private void Producto_Load(object sender, EventArgs e)
        {
            tblProd.AutoGenerateColumns = true;
            TodosLosProductos();
            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
            tabControl1.SelectedIndex = 0;
            txtIDCat.Enabled = false;
            txtIDCat2.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esta seguro de Eliminar al cliente Seleccionado", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                _ProductoBOL.Eliminar(Convert.ToInt32(CS));
                int vartemp = Convert.ToInt32(tblProd.CurrentRow.Cells[0].Value);
                LlenarGruid();
                if (Convert.ToInt32(tblProd.CurrentRow.Cells[0].Value) == vartemp)
                {
                    MessageBox.Show("No se puede Eliminar, debido a la integridad referencial");
                }
                tblProd.ClearSelection();
            }
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            if (txtNombreProUP.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre del Producto", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtdesc2.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Descripción del Producto", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtIDCat2.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el ID de la Categoria", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _producto = new producto();
                _producto.nombrePro = Convert.ToString(txtNombreProUP.Text);
                _producto.precio = Convert.ToDecimal(txtPrecio2.Text);
                _producto.cantidad = Convert.ToInt32(numCant2.Value);
                _producto.descripcion = txtdesc2.Text;
                _producto.id_producto = Convert.ToInt32(CS);
                _producto.id_categoria = Convert.ToInt32(txtIDCat2.Text);
                _ProductoBOL.registrar(_producto);
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                TodosLosProductos();
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], true);
                tblProd.Enabled = true;
            }
           
        }

       

        public void ProdxId()
        {
            tblProd.Enabled = true;
            _producto = _ProductoBOL.ObtnerporID(Convert.ToInt32(CS));
            List<producto> productos = new List<producto>();
            productos.Add(_producto);
            tblProd.DataSource = productos;
            if(true)
            {
                MessageBox.Show("no hay joven");
                tblProd.Enabled = false;
            
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {

        }

        private void tblProd_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Actualizar al cliente Seleccionado", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], false);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], true);
                //tabControl1.SelectedIndex = 1;

                String nombrePro = tblProd.CurrentRow.Cells["nombrePro"].Value.ToString();
                String[] cadena = nombrePro.Split(',');
                nombrePro = cadena[0];
                precio = Convert.ToDecimal(tblProd.CurrentRow.Cells["precio"].Value.ToString());
                //precio = tblProd.CurrentRow.Cells["precio"].Value.ToString();
                desc = tblProd.CurrentRow.Cells["descripcion"].Value.ToString();
                cant = tblProd.CurrentRow.Cells["cantidad"].Value.ToString();
             
                CS = tblProd.CurrentRow.Cells["id_producto"].Value;
                id_categoria = tblProd.CurrentRow.Cells["id_categoria"].Value.ToString();
             
                precio = Convert.ToDecimal(txtPrecio2.Text);
                //txtNombreProUP.Text = precio;
                txtNombreProUP.Text = nombrePro;
                txtdesc2.Text = desc;
                numCant2.Text = cant;
                txtIDCat2.Text = id_categoria;
            }
            else
            {
                CS = tblProd.CurrentRow.Cells[0].Value;
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=ALEXANDER-ASUS\SQLEXPRESS;Initial Catalog=boutique;User ID=sa;Password=1234");
        public void seleccionar(ComboBox cmbCat)
        {
            cmbCat.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from categoria", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCat.Items.Add(dr[1].ToString());
            }
            con.Close();
            cmbCat.Items.Insert(0, "Seleccione una Categoria");
            cmbCat.SelectedIndex = 0;
        }





        public string[] captar_info(string nombre)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from categoria where nombre= '" + nombre + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),
                };
                resultado = valores;
            }
            con.Close();
            return resultado;
        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tblProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string rutaCompleta = Application.StartupPath.ToString();
            string rutaNueva = rutaCompleta.Replace(@"\bin\Debug", @"\Reportes");
            string rutaArchivo = rutaNueva + @"\Productos.pdf";
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Esmeralda's Boutique";
            printer.SubTitle = string.Format("Reporte de Productos");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.FooterColor = Color.LightPink;

            if (File.Exists(rutaArchivo))
            {
                File.Delete(Path.Combine(rutaNueva, @"Productos.pdf"));
            }
            printer.PrintNoDisplay(tblProd);
            if (File.Exists(rutaArchivo))
            {
                MessageBox.Show("Operación Exitosa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MailMessage msg = new MailMessage("esmeraldaboutique23@gmail.com", "esmeraldaboutique23@gmail.com", "Reporte de Productos", "<h1>Listado de Productos</h1>");
                msg.IsBodyHtml = true;
                Attachment attachment = new Attachment(rutaNueva + @"\\Productos.pdf");
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

        private void cmbCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPrecio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCat2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCat.SelectedIndex > 0)
            {
                string[] valores = captar_info(cmbCat.Text);
                txtIDCat.Text = valores[0];
            }
        }
        private void cmbCat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCat2.SelectedIndex > 0)
            {
                string[] valores = captar_info(cmbCat2.Text);
                txtIDCat2.Text = valores[0];
            }
        }

        public void limpiar()
        {
            txtNombrePro.Clear();
            txtdesc.Clear();
            //txtPrecio.Clear();
            numCantidad.Value = 0;
            txtPrecio.Value = 0; //limpiar un numericdow
            numCantidad.Value = 0;
            cmbCat.Items.Clear();
            txtIDCat.Clear();



        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombrePro.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre del Producto", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtdesc.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Descripción del Producto", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtIDCat.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el ID de la Categoria", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _producto = new producto();
                _producto.nombrePro = Convert.ToString(txtNombrePro.Text);
                _producto.precio = Convert.ToDecimal(txtPrecio.Text);
                _producto.cantidad = Convert.ToInt32(numCantidad.Value);
                _producto.descripcion = txtdesc.Text;
                _producto.id_producto = Convert.ToInt32(CS);
                _producto.id_categoria = Convert.ToInt32(txtIDCat.Text);
                _ProductoBOL.registrar(_producto);
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Exito exi = new Exito();
                //exi.ShowDialog();
                //MessageBox.Show("Datos agregados exitosamente");
                tblProd.Enabled = true;
                limpiar();
                TodosLosProductos();
            }
           
        }

    }
}
