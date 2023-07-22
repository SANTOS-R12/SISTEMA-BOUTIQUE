using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class RolesDALsp
    {
        public void Insert(roles roles)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("INSERTAR_ROLES", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rol", roles.rol);
                    //cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(roles roles)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE_ROLES", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_rol", roles.id_rol);
                    cmd.Parameters.AddWithValue("@rol", roles.rol);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool Delete(int id_rol)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE_ROLES", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_rol", id_rol);
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

        public List<roles> GetAll()
        {
            List<roles> roless = new List<roles>();
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT_ROLES_FULL", cnx))
                {

                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        roles rol = new roles
                        {
                            id_rol = Convert.ToInt32(dataReader["id_rol"]),
                            rol = Convert.ToString(dataReader["rol"])
                        };
                        roless.Add(rol);
                    }
                }
            }
            return roless;
        }


        public roles GetByid_rol(int id_rol)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                const string query = @"SELECT * FROM roles WHERE id_rol=@id_rol";
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id_rol", id_rol);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        roles rol = new roles
                        {
                            id_rol = Convert.ToInt32(dataReader["id_rol"]),
                            rol = Convert.ToString(dataReader["rol"]),                       
                        };
                        return rol;
                    }
                }
            }
            return null;
        }

    }
}
