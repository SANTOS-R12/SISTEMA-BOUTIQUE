using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
   public class CategoriaBOL
    {
        StringBuilder sb = new StringBuilder();

        private CategoriaDALsp _CategoriasDALsp = new CategoriaDALsp();
        private bool validarCategoria(categoria categoria)
        {
            sb.Clear();

            if (string.IsNullOrEmpty(categoria.nombre))
                sb.Append("El nombre de categoria es obligatorio");
            if (string.IsNullOrEmpty(categoria.descripcion))
                sb.Append("La descripcion es obligatorio");
        
        
            return sb.Length == 0;
        }

        public readonly StringBuilder stringBuilder = new StringBuilder();
        public void registrar(categoria categoria)
        {
            if (validarCategoria(categoria))
            {
                if (_CategoriasDALsp.GetByCategoria(categoria.id_categoria) == null)
                    _CategoriasDALsp.Insert(categoria);
                else
                    _CategoriasDALsp.Update(categoria);
            }
        }

        public bool Eliminar(int id_categoria)
        {
            return _CategoriasDALsp.Delete(id_categoria);
        }

        public categoria Obtnerporidcategoria(int id_categoria)
        {
            return _CategoriasDALsp.GetByCategoria(id_categoria);
        }
        public List<categoria> ConsultarTodos()
        {
            return _CategoriasDALsp.GetAll();
        }
        public List<categoria> ConsultarNombres()
        {
            return _CategoriasDALsp.GetAllNames();
        }
        //public List<SELECT_CATEGORIA_FULL_Result> ConsultarCategorias()
        //{
        //    return _CategoriasDALsp.GetNomCategoria();
        //}

    }
}
