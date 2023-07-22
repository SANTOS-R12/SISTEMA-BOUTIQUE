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

namespace SISTEMA
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }
        public object CS = -1;
        String nombreCat, descripcionCat;
        string dui = "";
        private categoria _categoria;
        private readonly CategoriaBOL _CategoriaBOL = new CategoriaBOL();

        private void tblCategorias_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea Actualizar la Categoria Seleccionado", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                //tabControl1.SelectedIndex = 1;
                String nombreCompleto = tblCategorias.CurrentRow.Cells["nombre"].Value.ToString();
                String[] cadena = nombreCompleto.Split(',');
                nombreCat = cadena[0];
                descripcionCat = tblCategorias.CurrentRow.Cells["descripcion"].Value.ToString();
                txtNomCat.Text = nombreCat;
                txtDesCat.Text = descripcionCat;
                CS = tblCategorias.CurrentRow.Cells[0].Value;
            }
            else
            {
                CS = tblCategorias.CurrentRow.Cells[0].Value.ToString();
            }
        }

        //funcion
        public void TodosLasCategorias()
        {
            List<categoria> categorias = _CategoriaBOL.ConsultarTodos();
            if (categorias.Count > 0)
            {
                tblCategorias.DataSource = categorias;
            }
            else
            {
                MessageBox.Show("no hay joven");
            }
        }

        public void LlenarGruid()
        {
            List<categoria> categorias = _CategoriaBOL.ConsultarTodos();
            if (categorias.Count > 0)
            {
                tblCategorias.DataSource = categorias;
            }
            else
            {
                MessageBox.Show(":v");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Esta seguro de Eliminar la Categoria Seleccionado", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                _CategoriaBOL.Eliminar(Convert.ToInt32(CS));
                int vartemp = Convert.ToInt32(tblCategorias.CurrentRow.Cells[0].Value);
                LlenarGruid();
                if (Convert.ToInt32(tblCategorias.CurrentRow.Cells[0].Value) == vartemp)
                {
                    MessageBox.Show("No se puede Eliminar, debido a la integridad referencial");
                }
                tblCategorias.ClearSelection();
            }
        }

        public void limpiar()
        {
            txtDesCat.Clear();
            txtNomCat.Clear();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            //tblCategorias.Enabled = false;
            tblCategorias.AutoGenerateColumns = true;
          
            TodosLasCategorias();
            this.tblCategorias.Columns["producto"].Visible = false;  //Para ocultar un dato de la tabla clientes
        }

        private void tblCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNomCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            if (txtNomCat.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar el Nombre de la Categoría", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDesCat.Text.Equals(""))
            {
                MessageBox.Show("Falta Ingresar la Descripción de la Categoría", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _categoria = new categoria();

                _categoria.nombre = txtNomCat.Text;
                _categoria.descripcion = txtDesCat.Text;
                _categoria.id_categoria = Convert.ToInt32(CS);
                _CategoriaBOL.registrar(_categoria);
                //Exito frm_exito = new Exito();
                //frm_exito.ShowDialog();
                MessageBox.Show("Datos agregados exitosamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tblCategorias.Enabled = true;
                limpiar();
                TodosLasCategorias();
                LlenarGruid();
            }

         
           
        }
    }
}
