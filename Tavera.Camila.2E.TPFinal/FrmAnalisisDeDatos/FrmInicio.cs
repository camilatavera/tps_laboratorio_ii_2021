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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            FrmImportarDatos frmImportarDatos = new FrmImportarDatos();
            frmImportarDatos.ShowDialog();
        }

        private void btn_agregarDatos_Click(object sender, EventArgs e)
        {
            FrmOpcionesAgregar frmOpciones = new FrmOpcionesAgregar();
            frmOpciones.Show();
        }

        private void btn_analisis_Click(object sender, EventArgs e)
        {
            FrmAnalisis frmAnalisis = new FrmAnalisis();
            frmAnalisis.Show();
        }

        private void btn_comparar_Click(object sender, EventArgs e)
        {
            FrmComparar frmComparar = new FrmComparar();
            frmComparar.ShowDialog();
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            FrmExportarDatos frmExportar = new FrmExportarDatos(ManejoArchivos.EtipoArchivoS.JSON);
            frmExportar.Show();
        }

        private void btn_exportarXml_Click(object sender, EventArgs e)
        {
            FrmExportarDatos frmExportar = new FrmExportarDatos(ManejoArchivos.EtipoArchivoS.XML);
            frmExportar.Show();

        }
    }
}
