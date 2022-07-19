using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using biblioteca1;

namespace biblioteca2
{
    public class user
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable users(Logim obje)
        {
            SqlCommand cmd = new SqlCommand("Logeo", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@rol", obje.rol);
            cmd.Parameters.AddWithValue("@clave", obje.contraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



        public void InsertarUsuarios(Usuarios user)
        {

            SqlCommand cmd = new SqlCommand("CrearUsuario", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@nombre_completo", user.Nombre_Completo);
            cmd.Parameters.AddWithValue("@usuario", user.Usuario);
            cmd.Parameters.AddWithValue("@rol", user.Rol);
            cmd.Parameters.AddWithValue("@clave", user.Clave);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void Insertarprestamos(Prestamos user)
        {

            SqlCommand cmd = new SqlCommand("CrearPrestamo", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            conn.Open();
            cmd.Parameters.AddWithValue("@ClienteId", user.ClienteId);
            cmd.Parameters.AddWithValue("@CantidadSolicitada", user.CantidadSOlicitada);
            cmd.Parameters.AddWithValue("@Tasa", user.Tasa);
            cmd.Parameters.AddWithValue("@CantidadMeses", user.CantidadMeses);
            cmd.Parameters.AddWithValue("@Estado", user.Estado);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
