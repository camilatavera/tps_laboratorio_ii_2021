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

        InicioDB db;
        PersonaInicioXML xmlInicio;
        Task taskdb;
        Task taskxml;
        OpenFileDialog openFileDialog;
        string archivo;

       

        public FrmInicioDescarga()
        {
            InitializeComponent();


        }

       

        private void FrmDescargaPrincipal_Load(object sender, EventArgs e)
        {

            db = new InicioDB();
            xmlInicio = new PersonaInicioXML();
            db.eventoInicio += msj_DB;
            db.eventoFinal += msj_DB;

        }

        private void IniciarProcesoCompleto()
        {           
            xmlInicio.eventoAviso += msj_XML;
            xmlInicio.EventAgregarLista += DB.AgregarPersonas;
            taskxml = xmlInicio.inicioTask(archivo);
            taskdb = db.inicioTask();
      
        }

        private void IniciarDB()
        {
            taskdb = db.inicioTask();
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
            IniciarDB();
            lbl_xml.Text = "No hay archivos xml para serializar";
            btn_xml.Enabled = false;
            btn_db.Enabled = false;
        }



       

        private void btn_xml_Click(object sender, EventArgs e)
        {

            openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                archivo = openFileDialog.FileName;
                Action<string> del = new Action<string>(msj_XML);
                xmlInicio.eventoAviso += del;
                btn_xml.Enabled = false;
                btn_db.Enabled = false;
                IniciarProcesoCompleto();
            }
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            if (((taskdb != null && !taskdb.IsCompleted) || (taskxml!=null && !taskxml.IsCompleted)))
            {
                MessageBox.Show("Todavia no se cargaron los datos");
            }
            else if (taskdb == null)
            {
                MessageBox.Show("Cargue la base de datos");
            }
            else
            {

                try
                {
                    if (this.xmlInicio.listNueva != null)
                    {
                        for (int i = 0; i < this.xmlInicio.listNueva.Count; i++)
                        {
                            if (this.xmlInicio.listNueva[i].GetType() == typeof(Ordenanza))
                            {
                                try
                                {
                                    DB.AgregarOrdenanza((Ordenanza)this.xmlInicio.listNueva[i]);
                                }
                                catch (ExcepcionPersona) { }
                                
                            }
                            else if (this.xmlInicio.listNueva[i].GetType() == typeof(Profesor))
                            {
                                try
                                {
                                    DB.AgregarProfesor((Profesor)this.xmlInicio.listNueva[i]);
                                }
                                catch (ExcepcionPersona) { }

                            }
                            else if (this.xmlInicio.listNueva[i].GetType() == typeof(Estudiante))
                            {
                                try
                                {
                                    DB.AgregarEstudiante((Estudiante)this.xmlInicio.listNueva[i]);
                                }
                                catch (ExcepcionPersona) { }
                                
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

        }
    }
}
