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
    public class CategoriaDALsp
    {

        public void Insert(categoria categoria)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("INSERTAR_CATEGORIA", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", categoria.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", categoria.descripcion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(categoria categoria)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE_CATEGORIA", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_categoria", categoria.id_categoria);
                    cmd.Parameters.AddWithValue("@nombre", categoria.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", categoria.descripcion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool Delete(int id_categoria)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE_CATEGORIA", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
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

        public List<categoria> GetAll()
        {
            List<categoria> categorias = new List<categoria>();
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                const string query = @"SELECT * FROM categoria";
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        categoria cat = new categoria
                        {
                            id_categoria = Convert.ToInt32(dataReader["id_categoria"]),
                            nombre = Convert.ToString(dataReader["nombre"]),
                            descripcion = Convert.ToString(dataReader["descripcion"])
                        };
                        categorias.Add(cat);
                    }
                }
            }
            return categorias;
        }
        public List<categoria> GetAllNames()
        {
            List<categoria> categorias = new List<categoria>();
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                const string query = @"SELECT nombre FROM categoria";
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        categoria cat = new categoria
                        {
                            nombre = Convert.ToString(dataReader["nombre"]),
                        };
                        categorias.Add(cat);
                    }
                }
            }
            return categorias;
        }

        public categoria GetByCategoria(int id_categoria)
        {
            using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
            {
                if (cnx.State != ConnectionState.Open) cnx.Open();
                const string query = @"SELECT * FROM categoria WHERE id_categoria=@id_categoria";
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        categoria cat = new categoria
                        {
                            id_categoria = Convert.ToInt32(dataReader["id_categoria"]),
                            nombre = Convert.ToString(dataReader["nombre"]),
                            descripcion = Convert.ToString(dataReader["descripcion"]),

                        };
                        return cat;
                    }
                }
            }
            return null;
        }

        //public List<SELECT_CATEGORIA_FULL_Result> GetNomCategoria()
        //{
        //    List<SELECT_CATEGORIA_FULL_Result> categorias = new List<SELECT_CATEGORIA_FULL_Result>();
        //    using (SqlConnection cnx = new SqlConnection(Properties.Settings.Default.cn))
        //    {
        //        if (cnx.State != ConnectionState.Open) cnx.Open();
        //        const string query = @"SELECT nombre FROM categoria";
        //        using (SqlCommand cmd = new SqlCommand(query, cnx))
        //        {
        //            cmd.CommandType = CommandType.Text;
        //            SqlDataReader dataReader = cmd.ExecuteReader();
        //            if (dataReader.Read())
        //            {
        //                SELECT_CATEGORIA_FULL_Result c = new SELECT_CATEGORIA_FULL_Result
        //                {
        //                    nombre = Convert.ToString(dataReader["nombre"])
        //                };
        //                categorias.Add(c);
        //                //return c;
        //            }
        //        }
        //    }
        //    return categorias;
        //    //return null;
        //}
    }
}
