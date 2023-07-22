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

namespace SISTEMA
{

    public partial class Inventario : Form
    {

        private pedido _pedido;
        private readonly PedidoBOL _PedidosBOL = new PedidoBOL();
        public Inventario()
        {
            InitializeComponent();
            seleccionar(cb);
        }
        public void TodosLosPedidos()
        {
            List<SELECT_PEDIDO_FULL_Result> pedidos = _PedidosBOL.ConsultarTodos();
            if (pedidos.Count > 0)
            {
               
                dgvpedidos.DataSource = pedidos;
            }
            else
            {
                //MessageBox.Show("");
            }
        }

        public void TodosLosProductosagotados()
        {
            List<producto> productos = _PedidosBOL.Consultarproductos();
            if (productos.Count > 0)
            {
                
                dgvagotados.DataSource = productos;

            }
            else
            {
                //MessageBox.Show("");
            }
        }

        public void TodosLosUsuariosMora()
        {
            List<SELECT_MORA_USUARIO_Result> moras = _PedidosBOL.ConsultarMora();
            if (moras.Count > 0)
            {
                
                dgvmora.DataSource = moras;

            }
            else
            {
                //MessageBox.Show("");
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


        SqlConnection con = new SqlConnection(@"Data Source=ALEXANDER-ASUS\SQLEXPRESS;Initial Catalog=boutique;User ID=sa;Password=1234");
        public void seleccionar(ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from proveedor", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
            con.Close();
            cb.Items.Insert(0,"Seleccione un Proveedor");
            cb.SelectedIndex = 0;
        }
        

        public string[] captar_info(string nombre)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select*from Proveedor where nombre= '" + nombre + "'", con);
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


        private void Inventario_Load(object sender, EventArgs e)
        {
           
                dgvpedidos.AutoGenerateColumns = true;
            dgvagotados.AutoGenerateColumns = true;
            dgvmora.AutoGenerateColumns = true;
            TodosLosPedidos();
            TodosLosProductosagotados();
            TodosLosUsuariosMora();

            //this.dgvagotados.Columns["id_categoria"].Visible = false;
           
            EnableTab(tabControl1.TabPages[tabControl1.SelectedIndex = 1], false);
            tabControl1.SelectedIndex = 0;
          

            SqlCommand con = new SqlCommand("select nombre from proveedor" );
                
            
        }
        public void LlenarGruid()
        {
            List<SELECT_PEDIDO_FULL_Result> pedidos = _PedidosBOL.ConsultarTodos();
            if (pedidos.Count > 0)
            {
               
                dgvpedidos.DataSource = pedidos;
            }
            else
            {
                MessageBox.Show("UwU");
            }
        }

        public void LlenarGru()
        {
            List<producto> productos = _PedidosBOL.Consultarproductos();
            if (productos.Count > 0)
            {

                dgvpedidos.DataSource = productos;
            }
            else
            {
                MessageBox.Show("UwU");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        //public void signoprecio()
        //{
        //    dgvpedidos.Enabled = true;
        //    List<pedido> clientes = new List<pedido>();
        //    string tempclie = "$" + _pedido.precio;
        //}
        private void btnguadar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el ID del Proveedor", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtDETALLE.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Detalle", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (calendario.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Fecha", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fecha = calendario.Value.ToShortDateString();
                _pedido = new pedido();
                _pedido.fecha = Convert.ToDateTime(fecha);
                _pedido.detalle = txtDETALLE.Text;
                _pedido.precio = Convert.ToDecimal(txtPRECIO.Text);
                _pedido.cantidad = Convert.ToInt32(txtCANTIDAD.Text);
                _pedido.id_proveedor = Convert.ToInt32(txtID.Text);
                //string tempclie = "$" + _pedido.precio; //muestra un signo en la tabla
                _PedidosBOL.registrar(_pedido);
               
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvpedidos.Enabled = true;

                limpiar();
                TodosLosPedidos();
            }

           

        }
        public void limpiar()
        {
            //txtCANTIDAD = "b";
            txtDETALLE.Clear();
            txtID.Clear();
            //txtPRECIO.Items.Clear();
            
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cb.SelectedIndex>0)
            {
                string[] valores = captar_info(cb.Text);
                txtID.Text = valores[0];
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        //public virtual void Sort(System.Collections.IComparer comparer);
        private void button3_Click(object sender, EventArgs e)
        {

            //if (radioButton1.Checked == true)
            //{
            //    dgvmora.Sort(new RowComparer(SortOrder.Ascending));
            //}
            //else if (radioButton2.Checked == true)
            //{
            //    dgvmora.Sort(new RowComparer(SortOrder.Descending));
            //}

            this.dgvmora.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dgvmora.Columns[0].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            //double  direction = ListSortDirection.Descending; 
           // dgvmora.Sort(dgvmora.Columns["nombre"], ListSortDirection.Ascending);
            dgvmora.Refresh();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dgvmora.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
            dgvmora.Columns[0].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            //double  direction = ListSortDirection.Descending; 
            // dgvmora.Sort(dgvmora.Columns["nombre"], ListSortDirection.Ascending);
            dgvmora.Refresh();
        }

        private void txtPRECIO_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dgvpedidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvagotados_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvmora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
