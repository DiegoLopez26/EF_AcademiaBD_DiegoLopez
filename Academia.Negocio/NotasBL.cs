using Academia.Data;
using Academia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Negocio
{
    public class NotasBL
    {
        public static List<Notas> Listar()
        {
            var notasDB = new NotasDB();
            return notasDB.Listar();
        }

        public static bool Insertar(Notas notas)
        {
            var notasDB= new NotasDB();
            return notasDB.Insertar(notas) > 0;
        }
        
    }
}
