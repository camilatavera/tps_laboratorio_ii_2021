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
    public partial class FrmAgregarPersona : Form
    {
        public FrmAgregarPersona()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Valida que los campos no esten vacios
        /// </summary>
        /// <returns>bool</returns>
        protected bool validarCamposLlenos()
        {
            int aux;
            if (txt_apellido.Text != null && txt_nombre.Text != null && nud_edad.Value != 0 &&
                cmb_sexo.SelectedItem != null && int.TryParse(nud_edad.Value.ToString(), out aux) &&
                int.TryParse(nud_plata.Value.ToString(), out aux) &&
                int.TryParse(nud_pComprados.Value.ToString(), out aux) &&
                int.TryParse(nud_compras.Value.ToString(), out aux))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// valida la coherencia de los campos plata gastada, cantidad de compras y cantidad de productos 
        /// arrojando una excepcion si no se cumple 
        /// </summary>
        /// <returns>bool</returns>
        protected bool validarCoherencia()
        {
            int plata = (int)nud_plata.Value;
            int compras = (int)nud_compras.Value;
            int productos = (int)nud_pComprados.Value;

            if ((plata > 0 && compras > 0 && productos >= compras && compras!=0) ||
                                  (plata == 0 && compras == 0 && productos == 0))
            {
                return true;
            }
            else
            {
                throw new ExcepcionPersona("Incongruencia de datos");
            }



        }

        protected void FrmAgregarPersona_Load(object sender, EventArgs e)
        {
            this.cmb_sexo.DataSource = Enum.GetValues(typeof(Esexo));
            this.cmb_sexo.SelectedItem = null;

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
