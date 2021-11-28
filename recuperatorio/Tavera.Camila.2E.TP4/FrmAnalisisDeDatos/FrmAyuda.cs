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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Al presionar el boton IMPORTAR AUTOMATICAMENTE: " +
                " se mostrara por pantalla todos los compradores en el archivo compradoresAutoImportar.xml ubicado en el Base Directory de este proyecto (FrmAnalisisDeDatos -> bin -> Debug -> net 5.0-windows )");
            sb.AppendLine("\n");

            sb.AppendLine("Al presionar el boton ABRIR ARCHIVO: Puede seleccionar el archivo mencionado anteriormente" + 
                "CompradoresImportarManual.xml y en la misma carpeta hay otro xml llamado compradoresExportar.xml  ");

            sb.AppendLine("\n");

            sb.AppendLine("Al presionar el boton GUARDAR: Si hay compradores que se repiten por nombre y apellido" +
              "se guardaran estos mismo en un archivo txt llamado CompradoresRepetidos.txt ubicado en el mismo lugar ");

            this.txt_ayuda.Text = sb.ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
