using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Bibloteca;
using ManejoArchivos;

namespace FrmAnalisisDeDatos
{
    public partial class FrmImportarDatos : Form
    { 
        OpenFileDialog openFileDialog;
        string archivo;
        List<Persona> listPrueba;
        List<Persona> listValidada;
        Serializador<List<Persona>> ser;

        public FrmImportarDatos()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            listPrueba = new List<Persona>();
            listValidada = new List<Persona>();
            ser = new Serializador<List<Persona>>(EtipoArchivoS.XML);


        }

        private void imprimirLista()
        {
            Persona per;
            StringBuilder sb = new StringBuilder();
            if (listValidada != null)
            {
                for(int i=0; i<listValidada.Count; i++)
                {
                    per = listValidada[i];
                    sb.AppendLine(per.mostrarDatos());
                   
                }
                this.rtb_datos.Text = sb.ToString();

            }
            else
            {
                this.rtb_datos.Text="Lista vacia";

            }
        }

      

        private void validarList()
        {
            Persona persona;

            if (listPrueba != null)
            {


                for (int i = 0; i < listPrueba.Count; i++)
                {
                    persona = listPrueba[i];
                    try
                    {
                        if (persona.validarExistencia() && persona.validarTodosLosCampos())
                        {
                            listValidada.Add(persona);
                        }

                    }
                    catch (ExcepcionPersona)
                    {
  
                    }

                }
            }

        }

        

        private void btn_abrirArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                archivo = openFileDialog.FileName;
                try
                {

                    listPrueba.Clear();
                    listValidada.Clear();

                    archivo = openFileDialog.FileName;
                    listPrueba = ser.Leer(archivo);

                    validarList();


                    if (listValidada!=null)
                    {
                            imprimirLista();
                            this.btn_guardar.Enabled = true;
                    }
                    
                }
                catch (ExceptionExtension)
                {
                    MessageBox.Show("Asegurese que el archivo elegido tenga la extension correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo salio mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           Persona per;
           for(int i=0; i<listValidada.Count; i++)
           {
                per = listValidada[i];
                BarColegio.AgregarCompradorSerializer(per);
           }
            MessageBox.Show($"val {listValidada.Count}\n bar{BarColegio.Compradores.Count}");
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            listPrueba.Clear();
            listValidada.Clear();

        }

        private void FrmImportarDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
