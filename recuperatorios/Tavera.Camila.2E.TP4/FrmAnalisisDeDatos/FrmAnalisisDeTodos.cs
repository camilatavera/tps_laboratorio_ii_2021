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
using ManejoArchivos;

namespace FrmAnalisisDeDatos
{
    public partial class FrmAnalisisDeTodos : Form
    {
        AnalisisGeneral analisis = new AnalisisGeneral();
        SaveFileDialog saveFileDialog;


        public FrmAnalisisDeTodos()
        {
            saveFileDialog = new SaveFileDialog();
            InitializeComponent();
        }

        private void btn_ver1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_1.Text = analisis.MasProductosComprados();
            }
            catch (Exception ex)
            {
                txt_1.Text = ex.Message;
            }

        }

        private void btn_ver2_Click(object sender, EventArgs e)
        {
            try
            {
                txt_2.Text = analisis.QuienMasCompras();
            }
            catch (Exception ex)
            {
                txt_2.Text = ex.Message;
            }
        }

        private void btn_ver3_Click(object sender, EventArgs e)
        {
            try
            {
               txt_3.Text = analisis.QuienGastaMas();
            }
            catch (Exception ex)
            {
                txt_3.Text = ex.Message;
            }

        }

        private void btn_ver4_Click(object sender, EventArgs e)
        {
            try
            {
                txt_4.Text = analisis.QuienGastaMas();
            }
            catch (Exception ex)
            {
                txt_4.Text = ex.Message;
            }

        }

        private void btn_ver5_Click(object sender, EventArgs e)
        {
            try
            {
                txt_5.Text = analisis.MasHorasMasPlataGastada();
            }
            catch (Exception ex)
            {
                txt_5.Text = ex.Message;
            }
            
        }

        private void btn_ver6_Click(object sender, EventArgs e)
        {
            try
            {
                txt_6.Text = analisis.turnoOrdenanzaMasGastador();
            }
            catch (Exception ex)
            {
                txt_6.Text = ex.Message;
            }

           
        }

        private void btn_ver7_Click(object sender, EventArgs e)
        {
            try
            {
                txt_7.Text = analisis.EstudiantesCompranMas();
            }
            catch (Exception ex)
            {
                txt_7.Text = ex.Message;
            }

        }

        private void btn_ver8_Click(object sender, EventArgs e)
        {
            try
            {
                txt_8.Text = analisis.MasHorasMasPlataGastada();
            }
            catch (Exception ex)
            {
                txt_8.Text = ex.Message;
            }

        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            string analisisTxt = analisis.generarAnalisis();
            string archivo;
            ArchivoTxt archivoTxt = new ArchivoTxt();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFileDialog.FileName;

                try
                {
                    archivoTxt.Escribir(archivo, analisisTxt, false);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Algo salio mal {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
