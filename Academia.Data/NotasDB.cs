using Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Data
{
    public class NotasDB
    {
        public List<Notas> Listar()
        {
            var listado = new List<Notas>();
            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Notas", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Notas notas;
                            while (lector.Read())
                            {
                                // CREAR UN NUEVO OBJETO Alumno
                                notas = new Notas();
                                notas.IdAlumno = (int)lector["IdAlumno"];
                                notas.IdCurso = (int)lector["IdCurso"];
                                notas.Eva1 = decimal.Parse(lector["Eva1"].ToString());
                                notas.Eva2 = decimal.Parse(lector["Eva2"].ToString());
                                notas.Parcial = decimal.Parse(lector["Parcial"].ToString());
                                notas.Final = decimal.Parse(lector["Final"].ToString());
                                listado.Add(notas);
                            }
                        }
                    }
                }
            }
            return listado;
        }

        public int Insertar(Notas notas)
        {
            int filas = 0;
            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                var query = "INSERT INTO [dbo].[Notas] " +
                    "([IdAlumno],[IdCurso],[Eva1],[Eva2],[Parcial]," +
                    "[Final])" +
                    "VALUES(@IdAlumno,@IdCurso,@Eva1,@Eva2,@Parcial," +
                    "@Final)";
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IdAlumno", notas.IdAlumno);
                    comando.Parameters.AddWithValue("@IdCurso", notas.IdCurso);
                    comando.Parameters.AddWithValue("@Eva1", notas.Eva1);
                    comando.Parameters.AddWithValue("@Eva2", notas.Eva2);
                    comando.Parameters.AddWithValue("@Parcial", notas.Parcial);
                    comando.Parameters.AddWithValue("@Final", notas.Final);

                    filas = comando.ExecuteNonQuery();
                }
            }
            return filas;
        }

    }
}
