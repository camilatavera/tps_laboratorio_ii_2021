using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAnalisisDeDatos
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            this.txt_ayuda.Text = "Al presionar el boton IMPORTAR AUTOMATICAMENTE: " +
                "se mostrara por pantalla todos los compradores en el archivo CompradoresIniciales.xml" +
                "ubicado en el Base Directory de este proyecto (FrmAnalisisDeDatos -> bin -> Debug -> net 5.0-windows" ;

            

                
        }
    }
}
