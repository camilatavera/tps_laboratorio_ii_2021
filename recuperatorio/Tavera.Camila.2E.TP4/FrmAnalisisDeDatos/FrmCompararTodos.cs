using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteca;


namespace FrmAnalisisDeDatos
{
    public partial class FrmCompararTodos : Form
    {
        AnalisisEntreDosGrupos<Profesor,Ordenanza> profesorOrdenanza;
        AnalisisEntreDosGrupos<Profesor, Estudiante> profesorEstudiante;
        AnalisisEntreDosGrupos<Estudiante, Ordenanza> estudianteOrdenanza;


        public FrmCompararTodos()
        {
            InitializeComponent();
            

        }

        private void FrmCompararTodos_Load(object sender, EventArgs e)
        {
            profesorOrdenanza = new AnalisisEntreDosGrupos<Profesor, Ordenanza>(BarColegio.Profesores, BarColegio.Ordenanzas);
            profesorEstudiante = new AnalisisEntreDosGrupos<Profesor, Estudiante>(BarColegio.Profesores, BarColegio.Estudiantes);
            estudianteOrdenanza = new AnalisisEntreDosGrupos<Estudiante, Ordenanza>(BarColegio.Estudiantes, BarColegio.Ordenanzas);

            profesorOrdenanza.EventoComparar += comparar1;
            profesorEstudiante.EventoComparar += comparar2;
            estudianteOrdenanza.EventoComparar += comparar3;

            profesorOrdenanza.generarTask();
            profesorEstudiante.generarTask();
            estudianteOrdenanza.generarTask();

        }



        private void comparar1 (string informe)
        {
            if (richTextBox1.InvokeRequired)
            {
                PasarInforme delegadoComparar1 = comparar1;
                object[] parametros = new object[] { informe };
                richTextBox1.Invoke(delegadoComparar1, parametros);
            }
            else
            {
                richTextBox1.Text = informe;
            }

        }

        private void comparar2(string informe)
        {
            if (richTextBox1.InvokeRequired)
            {
                PasarInforme delegadoComparar1 = comparar2;
                object[] parametros = new object[] { informe };
                richTextBox2.Invoke(delegadoComparar1, parametros);
            }
            else
            {
                richTextBox2.Text = informe;
            }

        }

        private void comparar3(string informe)
        {
            if (richTextBox1.InvokeRequired)
            {
                PasarInforme delegadoComparar1 = comparar3;
                object[] parametros = new object[] { informe };
                richTextBox3.Invoke(delegadoComparar1, parametros);
            }
            else
            {
                richTextBox3.Text = informe;
            }

        }






    }
}
