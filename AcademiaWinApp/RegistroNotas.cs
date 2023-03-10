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
    public partial class RegistroNotas : Form
    {
        public RegistroNotas()
        {
            InitializeComponent();
        }

        private void cargarFormulario(object sender, EventArgs e)
        {
            dgvNotas.Rows.Clear();
            var listado = NotasBL.Listar();
            foreach (var notas in listado)
            {
                dgvNotas.Rows.Add(notas.IdAlumno, notas.IdCurso, notas.Eva1, notas.Parcial,notas.Eva2,notas.Final);
            }
        }

        private void nuevoRegistro(object sender, EventArgs e)
        {
            var frm = new RegistroAlumnoEdit();
            var nuvaNota = new Notas();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                var resultado = NotasBL.Insertar(nuvaNota);
            }
        }

        private void registroAlumno(object sender, EventArgs e)
        {
            var frm=new RegistroAlumno();
            frm.Show();
        }
    }
}
