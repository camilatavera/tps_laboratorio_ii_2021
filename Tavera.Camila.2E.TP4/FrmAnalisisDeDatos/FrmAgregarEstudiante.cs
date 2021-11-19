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

namespace FrmAnalisisDeDatos
{
    public partial class FrmAgregarEstudiante : FrmAgregarPersona
    {
        Estudiante nuevaPersona;
        public FrmAgregarEstudiante()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int anio=0;
            float promedio;

            
            if (validarCamposLlenos() &&  int.TryParse(nud_anio.Value.ToString(), out anio) && float.TryParse(txt_promedio.Text, out promedio))
            {
                try
                {
                    if(validarCoherencia() && validarRangos())
                    {

                        nuevaPersona = new Estudiante(txt_nombre.Text, txt_apellido.Text, (Esexo)cmb_sexo.SelectedItem,
                        (int)nud_plata.Value, (int)nud_pComprados.Value, (int)nud_compras.Value, float.Parse(txt_promedio.Text), (int)nud_anio.Value);



                        if (BarColegio.AgregarComprador(nuevaPersona))
                        {
                            DB.AgregarEstudiante(nuevaPersona);
                            this.Close();
                        }
                    }

                }
                catch (ExceptionDB ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ExcepcionPersona ex)
                {
                    MessageBox.Show($"{ex.Message}\nChequee que la base de datos se este actualizando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"Chequee que todos los campos esten llenos o que el promedio y el curso sean validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        

        private bool validarRangos()
        {
           
            float promedio = float.Parse(txt_promedio.Text);
            int anio = (int)nud_anio.Value;

            if(!(promedio >= 1 && promedio <= 10)){
                throw new ExcepcionPersona("Promedio fuera de rango");
            }
            else if(!(anio>=1 && anio <= 5))
            {
                throw new ExcepcionPersona("Curso fuera de rango");
            }
            else
            {
                return true;
            }

        }
    }
}
