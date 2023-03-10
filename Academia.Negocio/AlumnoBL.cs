using Academia.Data;
using Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Negocio
{
    public class AlumnoBL
    {
        public static List<Alumno> Listar()
        {
            var alumnoDB = new AlumnoDB();
            return alumnoDB.Listar();
        }
    }
}
