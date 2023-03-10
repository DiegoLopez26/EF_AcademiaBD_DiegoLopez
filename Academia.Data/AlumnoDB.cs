using Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Data
{
    public class AlumnoDB
    {
        public List<Alumno> Listar()
        {
            var listado= new List<Alumno>();
            using (var conexion = new SqlConnection(UtilDB.CadenaConexion()))
            {
                conexion.Open();
                using (var comando = new SqlCommand("SELECT * FROM Alumnos", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Alumno alumno;
                            while (lector.Read())
                            {
                                // CREAR UN NUEVO OBJETO Alumno
                                alumno = new Alumno();
                                alumno.Id = (int)lector["Id"];
                                alumno.Codigo= lector["Codigo"].ToString();
                                alumno.Nombres = lector["Nombres"].ToString();
                                alumno.Apellidos = lector["Apellidos"].ToString();
                                alumno.Direccion = lector["Direccion"].ToString();
                                alumno.Email = lector["Email"].ToString();
                                listado.Add(alumno);
                            }
                        }
                    }
                }
            }
            return listado;
        }
    }
}
