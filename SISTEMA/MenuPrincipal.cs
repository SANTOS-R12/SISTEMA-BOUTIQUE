using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SISTEMA
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
           Clientes frm_clientes = new Clientes();
            frm_clientes.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe cerrar sesion para salir", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (MessageBox.Show("¿Desea cerrar sesion y salir?", "Informacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                btnSalir.Tag = "Salir";

                btnSalir.Visible = false;
                Visible = false;
            }

        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            Proveedores frm_proveedores = new Proveedores();
            frm_proveedores.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario frm_inventario = new Inventario();
            frm_inventario.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {
            if(label1.Text == "desahabilitar")
            {
                btnCategoria.Visible = false;
                btnproveedores.Visible = false;
                btnProducto.Visible = false;
                btnInventario.Visible = false;
                btnAdministracion.Visible = false;
            
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Categoria frm_categoria = new Categoria();
            frm_categoria.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Visible = true;
            Visible = false;
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            AdministradorLogin frm_administracion = new AdministradorLogin();
            frm_administracion.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Producto frm_producto = new Producto();
            frm_producto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevaVenta venta = new frmNuevaVenta();
            venta.ShowDialog();
        }

        private void btnSalir_VisibleChanged(object sender, EventArgs e)
        {
            
            if (btnSalir.Tag .ToString() == "Salir")
            {
                Login obj = new Login();
                Visible = false;
                obj.Visible = true;

                MessageBox.Show("Se ha cerrado sesion exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(500);
                obj.Close();
            }

        }
    }
}
