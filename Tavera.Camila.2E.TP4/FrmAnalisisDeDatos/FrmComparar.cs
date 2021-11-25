using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibloteca;
using ManejoArchivos;

namespace FrmAnalisisDeDatos
{
    public partial class FrmComparar : Form
    {


        SaveFileDialog saveFileDialog;
        ArchivoTxt archivoTxt;
                
        string archivo;

        public FrmComparar()
        {
            InitializeComponent();
            archivoTxt = new ArchivoTxt();
            saveFileDialog = new SaveFileDialog();
        }

        

        private void FrmComparar_Load(object sender, EventArgs e)
        {
            cmb_grupo1.Items.Add(typeof(Estudiante).Name.ToString());
            cmb_grupo1.Items.Add(typeof(Profesor).Name.ToString());
            cmb_grupo1.Items.Add(typeof(Ordenanza).Name.ToString());
            cmb_grupo2.Items.Add(typeof(Estudiante).Name.ToString());
            cmb_grupo2.Items.Add(typeof(Profesor).Name.ToString());
            cmb_grupo2.Items.Add(typeof(Ordenanza).Name.ToString());

            cmb_grupo1.SelectedItem = null;
            cmb_grupo2.SelectedItem = null;
        }


        /// <summary>
        /// Genera la comparacion en un archivo.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_generar_Click(object sender, EventArgs e)
        {
            string informe;
            
            if(cmb_grupo1.SelectedItem!=null && cmb_grupo2.SelectedItem != null &&
                cmb_grupo1.SelectedItem != cmb_grupo2.SelectedItem)
            {
                informe=generarTxt();
               

                if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    archivo = saveFileDialog.FileName;

                    try
                    {
                        if (string.IsNullOrEmpty(informe))
                        {
                            archivoTxt.Escribir(archivo, $"Informe vacio. Chequear que los grupos tengan integrantes y que sean distintos entre si", false);
                        }
                        else
                        {
                            archivoTxt.Escribir(archivo, informe, false);
                        }
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        archivoTxt.Escribir(archivo, $"Hubo un error al realizar el informe {ex.Message}", false);
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();

                    }
                }
                
            }
        }


        /// <summary>
        /// Instancia la clase generica AnalisisEntreDosGrupos segun haya elegido el usuario y genera el analisis
        /// </summary>
        /// <returns>string</returns>
        private string generarTxt()
        {
            if ((cmb_grupo1.SelectedItem.ToString() == typeof(Ordenanza).Name.ToString() ||
                cmb_grupo2.SelectedItem.ToString() == typeof(Ordenanza).Name.ToString()) &&
                (cmb_grupo1.SelectedItem.ToString() == typeof(Profesor).Name.ToString() ||
                cmb_grupo2.SelectedItem.ToString() == typeof(Profesor).Name.ToString()))
            {
                AnalisisEntreDosGrupos<Ordenanza, Profesor> analisis = new AnalisisEntreDosGrupos<Ordenanza, Profesor>
                    (BarColegio.Ordenanzas, BarColegio.Profesores);
                return analisis.generarAnalisis();
            }
            else if ((cmb_grupo1.SelectedItem.ToString() == typeof(Ordenanza).Name.ToString() ||
                cmb_grupo2.SelectedItem.ToString() == typeof(Ordenanza).Name.ToString()) &&
                (cmb_grupo1.SelectedItem.ToString() == typeof(Estudiante).Name.ToString() ||
                cmb_grupo2.SelectedItem.ToString() == typeof(Estudiante).Name.ToString()))
            {
                AnalisisEntreDosGrupos<Ordenanza, Estudiante>  analisis = new AnalisisEntreDosGrupos<Ordenanza, Estudiante>
                     (BarColegio.Ordenanzas, BarColegio.Estudiantes);
                return analisis.generarAnalisis();

            }
           else if((cmb_grupo1.SelectedItem.ToString() == typeof(Profesor).Name.ToString() ||
                cmb_grupo2.SelectedItem.ToString() == typeof(Profesor).Name.ToString()) &&
                (cmb_grupo1.SelectedItem.ToString() == typeof(Estudiante).Name.ToString() ||
                cmb_grupo2.SelectedItem.ToString() == typeof(Estudiante).Name.ToString())) 
           {
                AnalisisEntreDosGrupos<Profesor, Estudiante> analisis = new AnalisisEntreDosGrupos<Profesor, Estudiante>
                  (BarColegio.Profesores, BarColegio.Estudiantes);
                return analisis.generarAnalisis();

           }
           return null;



        }

      
    }
}
