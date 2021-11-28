using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejoDB;
using Bibloteca;

namespace FrmAnalisisDeDatos
{
    public partial class FrmBorrar : Form
    {
        EPersonas tipoPersona;
        string nombre;
        string apellido;

        public FrmBorrar(EPersonas tipoPersona)
        {
            InitializeComponent();
            this.tipoPersona = tipoPersona;
            this.Text = $"Borrar {tipoPersona}";
        }

        EPersonas TipoPersona
        {
            get => tipoPersona; 
        }
        string Apellido
        {
            get => apellido;
        }
        string Nombre
        {
            get => nombre;
        }



        private bool validarCampos()
        {
            string nombreAux = txt_nombre.Text;
            string apellidoAux = txt_apellido.Text;

            if(!string.IsNullOrEmpty(nombreAux) && !string.IsNullOrEmpty(apellidoAux))
            {
                this.nombre = nombreAux.Trim();
                this.apellido = apellidoAux.Trim();
                return true;

            }
            else
            {
                return false;
            }

        }

        

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    if (TipoPersona == EPersonas.estudiante)
                    {
                        DB.DeteleEstudiantes(Nombre, Apellido);
                        BarColegio.BorrarEstudiante(Nombre, Apellido);
                    }
                    else if (TipoPersona == EPersonas.ordenanza)
                    {
                        DB.DeleteOrdenanza(Nombre, Apellido);
                        BarColegio.BorrarOrdenanza(Nombre, Apellido);
                    }
                    else if (TipoPersona == EPersonas.profesor)
                    {
                        DB.DeleteProfesor(Nombre, Apellido);
                        BarColegio.BorrarProfesor(Nombre, Apellido);
                    }

                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.nombre = "";
                    this.apellido = "";
                }
                


            }
           
        }
    } 
}
