using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using SortOrder = System.Windows.Forms.SortOrder;
using System.Runtime.InteropServices; //Para mover todo un formulario que tieme panel

namespace SISTEMA
{
    public partial class AdministradorLogin : Form
    {
        //SqlConnection cnn;
        //SqlCommand cmd;
        //SqlDataReader dr;
        public object CS = -1;
        public int idpro = -1;
        private usuario _usuario;
        String nombre, clave, id_rol;
        private readonly UsuarioBOL _UsuariosDAL = new UsuarioBOL();
        //funcion


        public void TodosLosUSuarios()
        {
            List<usuario> usuarios = _UsuariosDAL.ConsultarTodos();
            if (usuarios.Count > 0)
            {

                tblUsuarios.DataSource = usuarios;
            }
            else
            {
                MessageBox.Show("No hay Proveedores");
            }
            //txtbuscardui.Visible = false;
        }
        public AdministradorLogin()
        {
            InitializeComponent();
            seleccionar(cmbRol);
            seleccionar(txtUPRol);
        }


        SqlConnection con = new SqlConnection(@"Data Source=ALEXANDER-ASUS\SQLEXPRESS;Initial Catalog=boutique;User ID=sa;Password=1234");
        public void seleccionar(ComboBox cmbRol)
        {
            cmbRol.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from roles", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbRol.Items.Add(dr[1].ToString());
            }
            con.Close();
            cmbRol.Items.Insert(0, "Seleccione un Rol");
            cmbRol.SelectedIndex = 0;
        }





        public string[] captar_info(string rol)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from roles where rol= '" + rol + "'", con);
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











        public void limpiar()
        {
            txtNombre.Clear();
            txtClave.Clear();
            //cmbRol.Items.Clear(); //limmpia un comboBox
            txtID.Clear();
            //cmbRol.Clear();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre de Usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtClave.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Clave del Usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (cmbRol.SelectedItem.Equals("Seleccione el Rol"))
            {
                MessageBox.Show("Falta Seleccionar el Rol", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el ID", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _usuario = new usuario();

                _usuario.nombre = txtNombre.Text;
                _usuario.clave = txtClave.Text;
                _usuario.id_rol = Convert.ToInt32(txtID.Text);



                _UsuariosDAL.registrar(_usuario);
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ok frm_exito = new ok();
                //frm_exito.ShowDialog();
                //MessageBox.Show("Datos agregados exitosamente");
                limpiar();
                TodosLosUSuarios();

            }

        }


        private void AdministradorLogin_Load(object sender, EventArgs e)
        {
            txtClave.PasswordChar = '*';
            txtUPClave.PasswordChar = '*';
            tblUsuarios.AutoGenerateColumns = true;
            TodosLosUSuarios();
            this.tblUsuarios.Columns["roles"].Visible = false; //ocultar datos de tabla
            this.tblUsuarios.Columns["venta"].Visible = false; //ocultar datos de tabla

            SqlCommand con = new SqlCommand("select rol from roles");
            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
            tabControl1.SelectedIndex = 0;
            txtID.Enabled = false;
            //txtIDRol.Enabled = false;
        }




        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRol.SelectedIndex > 0)
            {
                string[] valores = captar_info(cmbRol.Text);
                txtID.Text = valores[0];
            }
        }
        public void LlenarGruid()
        {
            List<usuario> usuarios = _UsuariosDAL.ConsultarTodos();
            if (usuarios.Count > 0)
            {
                tblUsuarios.DataSource = usuarios;
            }
            else
            {
                MessageBox.Show(":v");
            }
        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esta seguro de Eliminar al Usuario Seleccionado", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                _UsuariosDAL.Eliminar(Convert.ToInt32(CS));
                int vartemp = Convert.ToInt32(tblUsuarios.CurrentRow.Cells[0].Value);
                LlenarGruid();
                if (Convert.ToInt32(tblUsuarios.CurrentRow.Cells[0].Value) == vartemp)
                {
                    MessageBox.Show("No se puede Eliminar, debido a la integridad referencial");
                }
                tblUsuarios.ClearSelection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUPNombre.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre de Usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUPClave.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Clave del Usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtUPRol.SelectedItem.Equals("Seleccione el Rol"))
            {
                MessageBox.Show("Falta Seleccionar el Rol", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtIDRol.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el ID", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _usuario = new usuario();
                _usuario.nombre = txtUPNombre.Text;
                _usuario.clave = txtUPClave.Text;
                _usuario.id_rol = Convert.ToInt32(txtIDRol.Text);
                _usuario.id_usuario = Convert.ToInt32(CS);

                _UsuariosDAL.registrar(_usuario);
                //ok frm_exito = new ok();
                //frm_exito.ShowDialog();
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUPNombre.Clear();
                txtUPClave.Clear();
                txtUPRol.Items.Clear(); //limpiar combobox
                txtIDRol.Clear();



                TodosLosUSuarios();
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], true);
                tblUsuarios.Enabled = true;
            }

        }

        private void btnVertodo_Click(object sender, EventArgs e)
        {
            TodosLosUSuarios();
        }
        public static void EnableTab(TabPage page, bool enable)
        {
            EnableControls(page.Controls, enable);
        }

        private void txtUPRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtUPRol.SelectedIndex > 0)
            {
                string[] valores = captar_info(txtUPRol.Text);
                txtIDRol.Text = valores[0];
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtUPNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tblUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIDRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtUPRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tblUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private static void EnableControls(Control.ControlCollection ctls, bool enable)
        {
            foreach (Control ctl in ctls)
            {
                ctl.Enabled = enable;
                EnableControls(ctl.Controls, enable);
            }
        }

        private void tblUsuarios_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Desea Actualizar al Usuario Seleccionado", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                txtIDRol.Enabled = false;
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 2], false);
                EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], true);
                //tabControl1.SelectedIndex = 1;
                String nombreCompleto = tblUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
                String[] cadena = nombreCompleto.Split(',');
                nombre = cadena[0];
                clave = tblUsuarios.CurrentRow.Cells["clave"].Value.ToString();
                id_rol = tblUsuarios.CurrentRow.Cells["id_rol"].Value.ToString();

                CS = tblUsuarios.CurrentRow.Cells["id_usuario"].Value;
                txtUPNombre.Text = nombre;
                txtUPClave.Text = clave;
                txtIDRol.Text = id_rol;

            }
            else
            {
                CS = tblUsuarios.CurrentRow.Cells["id_usuario"].Value;
            }
        }
    }
}
