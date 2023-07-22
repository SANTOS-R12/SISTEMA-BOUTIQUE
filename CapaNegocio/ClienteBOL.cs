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
    public class ClienteBOL
    {
        StringBuilder sb = new StringBuilder();

        private ClienteDALsp _ClientesDALsp = new ClienteDALsp();
        private bool validarCliente(cliente cliente)
        {
            sb.Clear();
            //if (string.IsNullOrEmpty(cliente.id_cliente.ToString()))
            //    sb.Append("El dui del cliente es obligatorio");
            if (string.IsNullOrEmpty(cliente.nombre))
                sb.Append("El nombre del cliente es obligatorio");      
            if (string.IsNullOrEmpty(cliente.direccion))
                sb.Append("El direccion del cliente es obligatorio");
            if (string.IsNullOrEmpty(cliente.email))
                sb.Append("El email del cliente es obligatorio");
            if (string.IsNullOrEmpty(cliente.telefono))
                sb.Append("El telefono del cliente es obligatorio");
            return sb.Length == 0;
        }

        public readonly StringBuilder stringBuilder = new StringBuilder();
        public void registrar(cliente cliente)
        {
            if (validarCliente(cliente))
            {
                if (_ClientesDALsp.GetBydui(cliente.id_cliente) == null)
                    _ClientesDALsp.Insert(cliente);
                else
                    _ClientesDALsp.Update(cliente);
            }
        }

        public bool Eliminar(int id_cliente)
        {
            return _ClientesDALsp.Delete(id_cliente);
        }

        public cliente ObtnerporDui(int id_cliente)
        {
            return _ClientesDALsp.GetBydui(id_cliente);
        }
        public List<cliente> ConsultarTodos()
        {
            return _ClientesDALsp.GetAll();
        }
    }
}
