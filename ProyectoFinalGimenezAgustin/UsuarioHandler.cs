using System.Data;
using System.Data.SqlClient;

namespace ProyectoCSharp
{
    public class UsuarioHandler : DbHandler
    {
        public List<Usuario> TraerUsuario()
        {
            List<Usuario> usuarioConDatos = new List<Usuario>();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Usuario WHERE Usuario=@NombreUsuario";

                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        Usuario usuario = new Usuario();

                        sqlCommand.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.nombreUsuario});


                    }
                }
            }

        }
        /*
        public List<Usuario> GetUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string queryUpdate = "SELECT * FROM Usuario WHERE NombreUsuario='tcasazza'";

                /*
                SqlParameter parametro = new SqlParameter("nombreUsuario", SqlDbType.VarChar) { Value = 1 };


                using (SqlCommand sqlCommand = new SqlCommand(queryUpdate, sqlConnection))
                {
                    
                    sqlConnection.Open();

                    using(SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var resultado = dataReader.GetString(3);
                                Console.WriteLine(resultado);
                            }
                        }
                    }
                    /*
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                Usuario usuario = new Usuario();

                                usuario.id = Convert.ToInt32(sqlDataReader["Id"]);
                                usuario.nombre = sqlDataReader["Nombre"].ToString();
                                usuario.apellido = sqlDataReader["Apellido"].ToString();
                                usuario.nombreUsuario = sqlDataReader["NombreUsuario"].ToString();
                                usuario.contraseña = sqlDataReader["Contraseña"].ToString();
                                usuario.mail = sqlDataReader["Mail"].ToString();
                            }
                        }
                    }
                    
                    sqlConnection.Close();
                }
            }

            return usuarios;
        }
        */

    }
}