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

namespace FrmAnalisisDeDatos
{
    public partial class FrmAgregarOrdenanza : FrmAgregarPersona
    {
        Ordenanza nuevaPersona; 
        public FrmAgregarOrdenanza()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (validarCamposLlenos() && cmb_turno.SelectedItem != null )
            {
                try
                {

                    if(validarCoherencia() && validarRangos())
                    {
                        nuevaPersona = new Ordenanza(txt_nombre.Text, txt_apellido.Text, (int)nud_edad.Value, (Esexo)cmb_sexo.SelectedItem,
                        (int)nud_plata.Value, (int)nud_pComprados.Value, (int)nud_compras.Value, (ETurno)cmb_turno.SelectedItem);
                        
                        BarColegio.Compradores.Add(nuevaPersona);
                        this.Close();
                    }
                    

                }
                catch(ExcepcionPersona ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Algo salio mal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show($"Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

                   
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void FrmAgregarOrdenanza_Load(object sender, EventArgs e)
        {
            this.cmb_turno.DataSource = Enum.GetValues(typeof(ETurno));
            this.cmb_turno.SelectedItem = null;

        }

        /// <summary>
        /// valida el campo edad no este fuera de rango y arroja una excepcion si esto sucede
        /// </summary>
        /// <returns>bool</returns>
        private bool validarRangos()
        {
            if (!((int)nud_edad.Value >= 18))
            {
                throw new ExcepcionPersona("Edad fuera de rango");
            }
            else
            {
                return true;
            }

        }
    }
}
