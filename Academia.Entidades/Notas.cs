using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Entidades
{
    public class Notas
    {
        public int IdAlumno { get; set; }
        public int IdCurso { get; set; }
        public decimal Eva1 { get; set; }
        public decimal Parcial { get; set;}
        public decimal Eva2 { get; set;}
        public decimal Final { get; set;}
    }
}
