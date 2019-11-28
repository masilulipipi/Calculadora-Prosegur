using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadora_Prosegur
{
    public partial class ParametrosAdmiGestion : Form
    {
        public ParametrosAdmiGestion()
        {
            InitializeComponent();
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            string costo = "";
            string pocentaje = "";
            string mensaje = "";

            costo = txtcosto.Text;
            pocentaje = txtmaximo.Text;
            mensaje = txtmensaje.Text;

            //costo = txtcosto.Text;

            //fijamos dondevamos a crear el archivo
            StreamWriter configcosto = File.CreateText("config4.masi");

            configcosto.WriteLine(costo);
            configcosto.Close();

            StreamWriter configporcentaje = File.CreateText("config5.masi");

            configporcentaje.WriteLine(pocentaje);
            configporcentaje.Close();

            StreamWriter configmensaje = File.CreateText("config6.masi");

            configmensaje.Write(mensaje);
            configmensaje.Close();



            MessageBox.Show("Parámetros Modificados", "Parámetros Aceptados", MessageBoxButtons.OK);
            this.Dispose();
            //btnSalir.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Introduzca solo números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
