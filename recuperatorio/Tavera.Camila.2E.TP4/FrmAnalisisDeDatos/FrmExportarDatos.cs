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
    public partial class FrmExportarDatos : Form
    {
        EtipoArchivoS tipo;
        public FrmExportarDatos(EtipoArchivoS tipoSerializacion)
        {
            InitializeComponent();
            tipo = tipoSerializacion;
        }

        private void FrmExportarDatos_Load(object sender, EventArgs e)
        {
            Persona per;
            StringBuilder sb = new StringBuilder();
            List<Persona> compradores = new List<Persona>();
            compradores.AddRange(BarColegio.Estudiantes);
            compradores.AddRange(BarColegio.Ordenanzas);
            compradores.AddRange(BarColegio.Profesores);

            if (tipo == EtipoArchivoS.XML)
            {
                for (int i = 0; i < compradores.Count; i++)
                {
                    per = compradores[i];
                    sb.AppendLine(per.mostrarDatos());

                }
            }
            else
            {
                for (int i = 0; i < compradores.Count; i++)
                {
                    per = compradores[i];
                    sb.AppendLine(per.mostrarDatosGenerales());
                }

            }

            this.rtb_datos.Text = sb.ToString();


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string path;
           


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (BarColegio.contarCompradores() == 0)
            {
                MessageBox.Show("No Hay compradores que serializar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<Persona> listCompradores = BarColegio.listaCompradores();
                path = saveFileDialog.FileName;
               
                try
                {
                    if (tipo == EtipoArchivoS.JSON)
                    {
                        Serializador<List<Persona>> ser = new Serializador<List<Persona>>(EtipoArchivoS.JSON);
                        ser.Escribir(path, listCompradores, true);
                    }
                    else
                    {
                        Serializador<List<Persona>> ser = new Serializador<List<Persona>>(EtipoArchivoS.XML);
                        ser.Escribir(path, listCompradores, true);

                    }
                    this.Close();           
                        
                }
                catch (ExceptionExtension)
                {
                    MessageBox.Show($"Asegurese que el archivo elegido tenga la extension correcta {tipo}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                     MessageBox.Show($"Algo salio mal {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
                       
        }

       

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       

        }
    }
    

