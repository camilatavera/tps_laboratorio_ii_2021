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

                    if(validarCoherencia())
                    {
                        nuevaPersona = new Ordenanza(txt_nombre.Text, txt_apellido.Text, (Esexo)cmb_sexo.SelectedItem,
                        (int)nud_plata.Value, (int)nud_pComprados.Value, (int)nud_compras.Value, (ETurno)cmb_turno.SelectedItem);
                        
                        BarColegio.Compradores.Add(nuevaPersona);
                        DB.AgregarOrdenanza(nuevaPersona);
                        this.Close();
                    }
                    

                }
                catch (ExceptionDB ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ExcepcionPersona ex)
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

      

       
        private void FrmAgregarOrdenanza_Load(object sender, EventArgs e)
        {
            this.cmb_turno.DataSource = Enum.GetValues(typeof(ETurno));
            this.cmb_turno.SelectedItem = null;

        }

        
    }
}
