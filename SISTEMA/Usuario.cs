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
    public partial class Usuario : Form
    {
     
        public Usuario(string nombre)
        {
            InitializeComponent();
            lblBienvenido.Text = "Bienvenido  " + nombre;
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Menu_principal frm = new Menu_principal();
            frm.Visible = true;
            Visible = false;


        }
        private void lblContinuar_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Menu_principal frm = new Menu_principal();
            //label1.Text = "desahabilitar";
            //frm.label1.Text = label1.Text;
            //frm.Show();
            //this.Hide();
        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Menu_principal frm = new Menu_principal();
                label1.Text = "desahabilitar";
                frm.label1.Text = label1.Text;
                frm.Visible = true;
                Visible = false;
              
                //frm.Show();
                //this.Hide();
            }
        }

      
    }
}
