using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Calculadora_Prosegur
{
    public partial class parametros_administrador : Form
    {
               
        

        public parametros_administrador()
        {
            InitializeComponent();
        }

        private void parametros_administrador_Load(object sender, EventArgs e)
        {

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
            StreamWriter configcosto = File.CreateText("config1.masi");

            configcosto.WriteLine(costo);
            configcosto.Close();

            StreamWriter configporcentaje = File.CreateText("config2.masi");

            configporcentaje.WriteLine(pocentaje);
            configporcentaje.Close();

            StreamWriter configmensaje = File.CreateText("config3.masi");

            configmensaje.Write(mensaje);
            configmensaje.Close();



            MessageBox.Show("Parámetros Modificados",  "Parámetros Aceptados" ,MessageBoxButtons.OK);
            this.Dispose();
            //btnSalir.Focus();
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtnum1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnum2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                System.Windows.Forms.SendKeys.Send("{TAB}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }
    }
}
