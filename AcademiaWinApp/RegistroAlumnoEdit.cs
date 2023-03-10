using Academia.Entidades;
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
    public partial class RegistroAlumnoEdit : Form
    {
        public RegistroAlumnoEdit()
        {
            InitializeComponent();
        }

        private void agregarDatos(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }

        private void cargarDatos(object sender, EventArgs e)
        {
            var listadoCursos = CursosBL.Listar();
            cboTaller.DataSource= listadoCursos;
        }
    }
}
