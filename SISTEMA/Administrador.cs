using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA
{
    public partial class Admin : Form
    {
        
        
            public Admin(string nombre)
            {
                InitializeComponent();
            lblBienvenido.Text = "Bienvenido  " + nombre;
            }

           
            
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menu_principal obj = new Menu_principal();
            obj.Visible = true;
            Visible = false;
            //Menu_principal frm_principal = new Menu_principal();
            //frm_principal.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void Admin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Menu_principal obj = new Menu_principal();
                obj.Visible = true;
                Visible = false;
            }
        }

        private void lblContinuar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
