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
    public partial class FrmOpciones : Form
    {
        private EAcciones accion;
        public FrmOpciones(EAcciones accion)
        {
            InitializeComponent();
            this.accion = accion;
        }

        private void btn_estudiante_Click(object sender, EventArgs e)
        {
            if (this.accion == EAcciones.agregar)
            {
                FrmAgregarEstudiante frmEstudiante = new FrmAgregarEstudiante();
                frmEstudiante.Show();
            }
            else
            {
                FrmBorrar frmBorrar = new FrmBorrar(EPersonas.estudiante);
                frmBorrar.Show();
            }
            
            
            this.Close();
        }

        private void btn_ordenanza_Click(object sender, EventArgs e)
        {
            if (this.accion == EAcciones.agregar)
            {
                FrmAgregarOrdenanza frmOrdenanza = new FrmAgregarOrdenanza();
                frmOrdenanza.Show();
            }
            else
            {
                FrmBorrar frmBorrar = new FrmBorrar(EPersonas.ordenanza);
                frmBorrar.Show();
            }

            this.Close();
        }

        private void btn_profesor_Click(object sender, EventArgs e)
        {
            if (this.accion == EAcciones.agregar)
            {
                FrmAgregarProfesor frmProfesor = new FrmAgregarProfesor();
                frmProfesor.Show();
            }
            else
            {
                FrmBorrar frmBorrar = new FrmBorrar(EPersonas.profesor);
                frmBorrar.Show();
            }

            this.Close();
        }

        
    }
}
