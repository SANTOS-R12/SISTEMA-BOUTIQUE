using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class ClienteDALsp
    {
        public void Insert(cliente cliente)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("INSERTAR_CLIENTE", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);
                    cmd.Parameters.AddWithValue("@nombre", cliente.nombre);                  
                    cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                    cmd.Parameters.AddWithValue("@email", cliente.email);
                    cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
             
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(cliente cliente)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE_CLIENTE", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);
                    cmd.Parameters.AddWithValue("@nombre", cliente.nombre);                  
                    cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                    cmd.Parameters.AddWithValue("@email", cliente.email);
                    cmd.Parameters.AddWithValue("@telefono", cliente.telefono);                  
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool Delete(int id_cliente)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE_CLIENTE", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1) return true;
                    }
                    catch (Exception ex)
                    {
                        
                        return false;
                    }
                }
            }
            return false;
        }

        public List<cliente> GetAll()
        {
            List<cliente> clientes = new List<cliente>();
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT_CLIENTE_FULL", cnx))
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        cliente cli = new cliente
                        {
                            id_cliente = Convert.ToInt32(dataReader["id_cliente"]),
                            nombre = Convert.ToString(dataReader["nombre"]),                           
                            direccion = Convert.ToString(dataReader["direccion"]),
                            email = Convert.ToString(dataReader["email"]),
                            telefono = Convert.ToString(dataReader["telefono"])                        
                           
                        };
                        clientes.Add(cli);
                    }
                }
            }
            return clientes;
        }
     

        public cliente GetBydui(int id_cliente)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                const string query = @"SELECT * FROM cliente WHERE id_cliente=@id_cliente";
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        cliente cli = new cliente
                        {
                            id_cliente = Convert.ToInt32(dataReader["id_cliente"]),
                            nombre = Convert.ToString(dataReader["nombre"]),                     
                            direccion = Convert.ToString(dataReader["direccion"]),
                            email = Convert.ToString(dataReader["email"]),
                            telefono = Convert.ToString(dataReader["telefono"])              
                         
                        };
                        return cli;
                    }
                }
            }
            return null;
        }
    }
}
