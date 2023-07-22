using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices; //Para mover todo un formulario que tieme panel

namespace SISTEMA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ALEXANDER-ASUS\SQLEXPRESS;Initial Catalog=ferreteria;User ID=sa;Password=1234");

        public void logear(string usuario, string contrasena)
        {
            try
            {
                con.Open();
                //SqlCommand cmd = new SqlCommand("SELECT * FROM usuario WHERE nombre = @usuario AND clave = @pas", con);
                SqlCommand cmd = new SqlCommand("SELECT nombre, id_rol From usuario WHERE nombre = @usuario AND clave = @pas", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //if (dt.Rows.Count > 0)
                    if (dt.Rows.Count == 1)
                    {
                    this.Hide();
                    //Admin frm = new Admin(usuario);
                    //frm.ShowDialog();

                    if (dt.Rows[0][1].ToString() == "1")
                    {
                        new Admin(dt.Rows[0][0].ToString()).Show();
                        //Admin frm = new Admin(usuario);
                        //frm.ShowDialog();

                    }
                    else if (dt.Rows[0][1].ToString() == "2")

                    {
                        new Usuario(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else{
                    ErrorLogin frm = new ErrorLogin();
                    frm.ShowDialog();
                    //MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                } 
            }
            catch (Exception e)
            {
                MessageBox.Show("No se Conecto" + e.ToString());
                //MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();


            }

        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //private void btnIniciar_Click(object sender, EventArgs e)
        //{
        //    logear(this.txtUsuario.Text, this.txtPass.Text);

        //}

        private void Login_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                logear(this.txtUsuario.Text, this.txtPass.Text);
            }
        }
        //Mover Formulario //Para mover todo un formulario que tieme panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Para mover todo un formulario que tieme panel
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre del Usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Clave del Usuario", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                logear(this.txtUsuario.Text, this.txtPass.Text);

            }
           

        }

        private void btnIniciar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

    

        private void txtPass_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                logear(this.txtUsuario.Text, this.txtPass.Text);
            }
        }
    }
}
