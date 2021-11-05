using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAnalisisDeDatos
{
    public partial class FrmOpcionesAgregar : Form
    {
        public FrmOpcionesAgregar()
        {
            InitializeComponent();
        }

        private void btn_estudiante_Click(object sender, EventArgs e)
        {
            FrmAgregarEstudiante frmEstudiante = new FrmAgregarEstudiante();
            frmEstudiante.Show();
            this.Close();
        }

        private void btn_ordenanza_Click(object sender, EventArgs e)
        {
            FrmAgregarOrdenanza frmOrdenanza = new FrmAgregarOrdenanza();
            frmOrdenanza.Show();
            this.Close();
        }

        private void btn_profesor_Click(object sender, EventArgs e)
        {
            FrmAgregarProfesor frmProfesor = new FrmAgregarProfesor();
            frmProfesor.Show();
            this.Close();
        }
    }
}
