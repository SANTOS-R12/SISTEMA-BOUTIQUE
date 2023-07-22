using SISTEMA;
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
    public partial class Inicio : Form
    {
        PictureBox[] ptb;
        int count = 0;
        public Inicio()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            //this.TransparencyKey = Color.FromArgb(0xAA, 0x00, 0xFF);
            //this.BackColor = Color.FromArgb(0xAA, 0x00, 0xFF);
            timerTime.Enabled = true;
            ptb = new PictureBox[5] { ptb1, ptb2, ptb3, ptb4, ptb5 };
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        //private void lblLinkContinuar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    this.Hide();
        //    Login frm = new Login();
        //    frm.Show();
        //}

        private void timerTime_Tick(object sender, EventArgs e)
        {

            switch (count)
            {
                case 0:
                    ptb[count].BackgroundImage = SISTEMA.Properties.Resources.punto;
                    lblTexto.Text = "Verificando actualizaciones...";
                    lblCarga.Text = "Cargado al " + (count + 20) + " %";
                    break;
                case 1:
                    ptb[count].BackgroundImage = SISTEMA.Properties.Resources.punto;
                    lblTexto.Text = "Aplicando configuraciones...";
                    lblCarga.Text = "Cargado al " + (count + 39) + " %";
                    break;
                case 2:
                    ptb[count].BackgroundImage = SISTEMA.Properties.Resources.punto;
                    lblTexto.Text = "Cargando controladores...";
                    lblCarga.Text = "Cargado al " + (count + 58) + " %";
                    break;
                case 3:
                    ptb[count].BackgroundImage = SISTEMA.Properties.Resources.punto;
                    lblTexto.Text = "Recopilando información...";
                    lblCarga.Text = "Cargado al " + (count + 77) + " %";
                    break;
                case 4:
                    ptb[count].BackgroundImage = SISTEMA.Properties.Resources.punto;
                    lblTexto.Text = "Accediendo al sistema...";
                    lblCarga.Text = "Cargado al " + (count + 96) + " %";
                    break;
                case 5:
                    timerTime.Enabled = false;
                    lblTexto.Visible = false;
                    btnContinuar.Visible = true;
                    break;
            }
            count++;
        }

   

    
    }
}
