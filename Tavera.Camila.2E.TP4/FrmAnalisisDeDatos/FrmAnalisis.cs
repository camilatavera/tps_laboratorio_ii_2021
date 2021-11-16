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
    public partial class FrmAnalisis : Form
    {
        AnalisisDeDatosGeneral analisis;

        SaveFileDialog saveFileDialog;
        ArchivoTxt archivoTxt;
        string archivo;
        
        public FrmAnalisis()
        {
            InitializeComponent();
            analisis = new AnalisisDeDatosGeneral(BarColegio.Compradores);
            archivoTxt = new ArchivoTxt();
            saveFileDialog = new SaveFileDialog();

        }

        private void Excepcion(string ex)
        {
            MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_ver1_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                txt_1.Text = analisis.masProductosComprados();
                
            }
            catch (Exception ex)
            {
                Excepcion(ex.Message);
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
                Excepcion(ex.Message);
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
                Excepcion(ex.Message);
            }


        }

        private void btn_ver4_Click(object sender, EventArgs e)
        {

            try
            {
                txt_4.Text = analisis.masProductosPorCompra();

            }
            catch (Exception ex)
            {
                Excepcion(ex.Message);
            }
            


        }

        private void btn_ver5_Click(object sender, EventArgs e)
        {

            try
            {
                txt_5.Text = analisis.SexoMasPlataGastada();

            }
            catch (Exception ex)
            {
                Excepcion(ex.Message);
            }
            
        }

        private void btn_ver6_Click(object sender, EventArgs e)
        {


            try
            {
                txt_6.Text = analisis.MasHorasMasPlataGastada();

            }
            catch (Exception ex)
            {
                Excepcion(ex.Message);
            }


        }

        private void btn_ver7_Click(object sender, EventArgs e)
        {
            try
            {
                txt_7.Text = analisis.turnoOrdenanzaMasGastador();
                
            }
            catch (Exception ex)
            {
                Excepcion(ex.Message);
            }

        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            string analisisTxt = analisis.generarAnalisis();

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
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

        private void btn_ver8_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.txt_8.Text = analisis.EstudiantesGastanMas();

            }
            catch (Exception ex)
            {
                Excepcion(ex.Message);
            }
        }

        private void FrmAnalisis_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Profesores {analisis.countProfesores()}, Estudiantes: {analisis.countEstudiantes()} y Ordenanza: {analisis.countOrdenanza()} ");
            this.lbl_integrantes.Text = sb.ToString();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.txt_9.Text = analisis.promedioBajoMasCompras();

            }
            catch (Exception ex)
            {
                Excepcion(ex.Message);
            }
        }
    }
}
