﻿using System;
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
    public partial class FrmAgregarProfesor : FrmAgregarPersona
    {
        Profesor nuevaPersona;
        public FrmAgregarProfesor()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int horasCatedras;
            if (validarCamposLlenos() && nud_hCatedra!=null && int.TryParse(nud_hCatedra.Value.ToString(), out horasCatedras))
            {
                try
                {
                    if (validarCoherencia() && validarRangos())
                    {
                        nuevaPersona = new Profesor(txt_nombre.Text, txt_apellido.Text, (int)nud_edad.Value, (Esexo)cmb_sexo.SelectedItem,
                        (int)nud_plata.Value, (int)nud_pComprados.Value, (int)nud_compras.Value, horasCatedras);

                        BarColegio.Compradores.Add(nuevaPersona);
                        this.Close();
                    }

                }
                catch (ExcepcionPersona ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Algo salio mal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show($"Faltan completar datos o chequee las horas catedras ingresadas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        /// <summary>
        /// Valida que los campos de la edad y las horas catedra no esten fuera de rango, y arroja una excepcion si esto sucede
        /// </summary>
        /// <returns>bool</returns>
        private bool validarRangos()
        {
            if (!((int)nud_edad.Value >= 22))
            {
                throw new ExcepcionPersona("Edad fuera de rango");
            }
            else if (!((int)nud_hCatedra.Value>=8))
            {
                throw new ExcepcionPersona("Horas catedra fuera de rango");
            }
            else
            {
                return true;
            }

        }
    }
}
