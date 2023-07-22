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
    public class RolBOL
    {

        StringBuilder sb = new StringBuilder();

        private RolesDALsp _RolDALsp = new RolesDALsp();
        private bool validarRol(roles roles)
        {
            sb.Clear();

            if (string.IsNullOrEmpty(roles.rol))
                sb.Append("El rol es obligatorio");



            return sb.Length == 0;
        }

        public readonly StringBuilder stringBuilder = new StringBuilder();
        public void registrar(roles roles)
        {
            if (validarRol(roles))
            {
                if (_RolDALsp.GetByid_rol(roles.id_rol) == null)
                    _RolDALsp.Insert(roles);
                else
                    _RolDALsp.Update(roles);
            }
        }

        public bool Eliminar(int id_rol)
        {
            return _RolDALsp.Delete(id_rol);
        }

        public roles ObtnerporDui(int id_rol)
        {
            return _RolDALsp.GetByid_rol(id_rol);
        }
        public List<roles> ConsultarTodos()
        {
            return _RolDALsp.GetAll();
        }
    }
}
