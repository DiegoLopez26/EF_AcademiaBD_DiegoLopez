using Academia.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaWinApp
{
    public partial class RegistroAlumno : Form
    {
        public RegistroAlumno()
        {
            InitializeComponent();
        }

        private void cargarFormulario(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();
            var listado = AlumnoBL.Listar();
            foreach (var alumno in listado)
            {
                dgvDatos.Rows.Add(alumno.Id, alumno.Codigo, alumno.Apellidos, alumno.Nombres, alumno.Direccion, alumno.Email);
            }
        }
    }
}
