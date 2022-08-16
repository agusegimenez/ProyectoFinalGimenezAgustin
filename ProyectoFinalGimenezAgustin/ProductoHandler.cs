using System.Data;
using System.Data.SqlClient;

namespace ProyectoCSharp
{
        public class ProductoHandler : DbHandler
        {
            public List<string> GetDescripciones()
            {
                List<string> descripciones = new List<string>();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Producto", sqlConnection))
                    {
                        sqlConnection.Open();

                        using(SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            if (dataReader.HasRows)
                            {
                                while (dataReader.Read())
                                {
                                    descripciones.Add(dataReader.GetString(1));
                                }
                            }
                        }

                        sqlConnection.Close();
                    }
                }
                return descripciones;
            }
        }
}