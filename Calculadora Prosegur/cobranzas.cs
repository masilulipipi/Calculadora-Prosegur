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


    
    public partial class cobranzas : Form
    {
        //decimal perro = 0;

        public cobranzas()
        {
            InitializeComponent();
        }
        //decimal sinimpuestos;
        private void button1_Click(object sender, EventArgs e)
        {
            Admin test = new Admin();
            test.ShowDialog();
                            
        }

        private void cobranzas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            decimal coniva, conimpuestos, sinimpuestos, siebel;
            string porcentajemaximo;
            string valormaximo;

            TextReader porciento;
            porciento = new StreamReader("config2.masi");

            porcentajemaximo = porciento.ReadLine();

            decimal porcentajemaximodecimal = Convert.ToDecimal(porcentajemaximo);

            TextReader valorm;
            valorm = new StreamReader("config1.masi");

            valormaximo = valorm.ReadLine();

            decimal valormaximodec = Convert.ToDecimal(valormaximo);



            decimal importe = Convert.ToDecimal(txtimportecobranza.Text);
            decimal iva = Convert.ToDecimal(txtnose.Text);
            decimal porcentaje = Convert.ToDecimal(txtporcencobranza.Text);

            coniva = importe * iva / 100 + importe;                         // CON IMPUESTOS
            txtimporteconivaincluidocobranza.Text = coniva.ToString("N2"); // CON IMPUESTOS

            conimpuestos = coniva - (coniva * porcentaje / 100); // CON DESCUENTOS Y CON IMPUESTOS
            txtcondescuentos.Text = conimpuestos.ToString("N2"); // CON DESCUENTOS Y CON IMPUESTOS

            sinimpuestos = importe - (importe * porcentaje / 100); // CON DESCUENTOS Y sin IMPUESTOS
            txtsinimpuestos.Text = sinimpuestos.ToString("N2");    // CON DESCUENTOS Y sin IMPUESTOS

            siebel = importe - sinimpuestos;                        // siebel
            txtnotacredito.Text = siebel.ToString("N2");           // siebel

            //decimal resultado_fina = sinimpuestos;

            if (porcentaje > porcentajemaximodecimal)
            {
                MessageBox.Show( "El Porcentaje no debe ser mayor a " + porcentajemaximo + "%", "Se Ha Excedido" , MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtporcencobranza.Focus();
                txtporcencobranza.Text = "";
                txtporcencobranza.Text = porcentajemaximo;
            }

            if (porcentaje > 99)
            {
                
                
                MessageBox.Show("El porcentaje maximo es 99,99", "El porcentaje maximo es 99,99", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
            if (sinimpuestos < valormaximodec)
            {
                MessageBox.Show("El importe sin impuestos no puede ser menor a " + valormaximodec + " $", "Se Ha Excedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                decimal sugerencia;

                sugerencia = (((valormaximodec/importe)-1)*-1)*100;

                MessageBox.Show("Se sugiere " + sugerencia.ToString("N2") + " %" , "                   SUGERENCIA", MessageBoxButtons.OK ,MessageBoxIcon.Information);

                txtimportecobranza.Focus();
                
                txtporcencobranza.Text = sugerencia.ToString("N2");
            }

            string abona = txtimportecobranza.Text;
            string puedeabonar = valormaximo;



            
            
           /* coniva = importe * iva /100 + importe;                         // CON IMPUESTOS
            txtimporteconivaincluidocobranza.Text = coniva.ToString("N2"); // CON IMPUESTOS

            conimpuestos = coniva - (coniva * porcentaje / 100); // CON DESCUENTOS Y CON IMPUESTOS
            txtcondescuentos.Text = conimpuestos.ToString("N2"); // CON DESCUENTOS Y CON IMPUESTOS

            sinimpuestos = importe - (importe * porcentaje / 100); // CON DESCUENTOS Y sin IMPUESTOS
            txtsinimpuestos.Text = sinimpuestos.ToString("N2");    // CON DESCUENTOS Y sin IMPUESTOS

            siebel = importe - sinimpuestos;                        // siebel
            txtnotacredito.Text = siebel.ToString("N2");           // siebel*/

        }

        private void txtimportecobranza_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtporcencobranza_TextChanged(object sender, EventArgs e)
        {
           
                       
        }

        private void txtimporteconivaincluidocobranza_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtimportecobranza_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtimportecobranza.Text, true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtimportecobranza.Text = Clipboard.GetText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtimporteconivaincluidocobranza.Text, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtsinimpuestos.Text, true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtnotacredito.Text, true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtporcencobranza.Text = Clipboard.GetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtimportecobranza.Text = "";
            txtporcencobranza.Text = "0";
            txtnose.Text = "21";
            txtimportecobranza.Focus();

        }

        private void txtimportecobranza_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                System.Windows.Forms.SendKeys.Send("{TAB}");
        }

        private void txtporcencobranza_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                System.Windows.Forms.SendKeys.Send("{TAB}");
        }

        private void txtcomentarios_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            

            string porcentajemaximo;
            string valormaximo;
            string mensaje;

            TextReader porciento;
            porciento = new StreamReader("config2.masi");

            porcentajemaximo = porciento.ReadLine();
            porciento.Close();
            

            decimal porcentajemaximodecimal = Convert.ToDecimal(porcentajemaximo);

            TextReader valorm;
            valorm = new StreamReader("config1.masi");
            
            valormaximo = valorm.ReadLine();
            valorm.Close();


            decimal valormaximodec = Convert.ToDecimal(valormaximo);

            

            TextReader mensajito;
            mensajito = new StreamReader("config3.masi");

            mensaje = mensajito.ReadToEnd();
            mensajito.Close();




            MessageBox.Show("Recuerde que el porcentaje máximo para descontar es " + porcentajemaximo + " % y el costo mínimo para poder realizar un descuento es $ " + valormaximo + " " + mensaje, "Tips del día", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
