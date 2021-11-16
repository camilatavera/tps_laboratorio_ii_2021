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
using ManejoDB;
using ManejoArchivos;
using System.Threading;

namespace FrmAnalisisDeDatos
{
    public partial class FrmInicioDescarga : Form
    {

        Serializador<List<Persona>> ser;
        InicioDB db;
        PersonaInicioXML xmlInicio;
        CancellationTokenSource tokenSource;
        Task taskdb;
        Task taskxml;



        public FrmInicioDescarga()
        {
            InitializeComponent();


        }

        private void FrmDescargaPrincipal_Load(object sender, EventArgs e)
        {

            db = new InicioDB();
            db.eventoInicio += msj_DB;
            db.eventoFinal += msj_DB;

            ser = new Serializador<List<Persona>>(EtipoArchivoS.XML);
            xmlInicio = new PersonaInicioXML();
            Action<string> del = new Action<string>(msj_XML);
            xmlInicio.eventoAviso += del;

            this.tokenSource = new CancellationTokenSource();

            IniciarProceso();



        }

        private void IniciarProceso()
        {
            
            CancellationToken token = this.tokenSource.Token;
             taskdb=db.inicioTask(token);
             //taskdb = Task.Run(() => db.traerDatosIniciales(token));

             taskxml = xmlInicio.inicioTask(token);
             //taskxml = Task.Run(() => xmlInicio.traerXMLiniciales(token));

        

        }



        private void msj_DB(string mensaje)
        {
            if (lbl_db.InvokeRequired)
            {
                Action<string> delegadoIniciar = msj_DB;
                object[] parametros = new object[] { mensaje };
                lbl_db.Invoke(delegadoIniciar, parametros);
            }
            else
            {
                lbl_db.Text = mensaje;
            }

        }

        private void msj_XML(string mensaje)
        {
            if (lbl_xml.InvokeRequired)
            {
                Action<string> delegadoIniciar = msj_XML;
                object[] parametros = new object[] { mensaje };
                lbl_db.Invoke(delegadoIniciar, parametros);
            }
            else
            {
                lbl_xml.Text = mensaje;
            }

        }

        

        private void FrmDescargaPrincipal_Paint(object sender, PaintEventArgs e)
        {
            lbl_db.Visible = true;
            this.Visible = true;
            lbl_xml.Visible = true;
        }

       

        private void btn_inicio_Click(object sender, EventArgs e)
        {
           
            if(taskdb!=null && taskxml!=null && !taskdb.IsCompleted && !taskxml.IsCompleted) 
            {
                MessageBox.Show("Todavia no se cargaron los datos");
                return;
            }

            try
            {
                if (this.xmlInicio.listNueva != null)
                {
                    for (int i = 0; i < this.xmlInicio.listNueva.Count; i++)
                    {
                        if (this.xmlInicio.listNueva[i].GetType() == typeof(Ordenanza))
                        {
                            DB.AgregarOrdenanza((Ordenanza)this.xmlInicio.listNueva[i]);
                        }
                        else if (this.xmlInicio.listNueva[i].GetType() == typeof(Profesor))
                        {
                            DB.AgregarProfesor((Profesor)this.xmlInicio.listNueva[i]);
                        }
                        else if (this.xmlInicio.listNueva[i].GetType() == typeof(Estudiante))
                        {
                            DB.AgregarEstudiante((Estudiante)this.xmlInicio.listNueva[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(!taskdb.IsCompleted && !taskxml.IsCompleted)
            {
                tokenSource.Cancel();
                this.lbl_db.Text = "Descarga de la base de datos cancelada";
                this.lbl_xml.Text = "Serializacion cancelada";
            }
            else
            {
                MessageBox.Show("Ya se realizo la tarea, no se puede cancelar");
            }
            
        }


    }
}
