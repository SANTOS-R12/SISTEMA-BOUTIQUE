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
    public partial class ErrorLogin : Form
    {
        public ErrorLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        //    ErrorLogin obj = new ErrorLogin();
        //    obj.Visible = false;
        //    Visible = false;
        }
        private void ErrorLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //    if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //    {
            //        ErrorLogin obj = new ErrorLogin();
            //        obj.Visible = false;
            //        Visible = false;
        }
    }

      
}

