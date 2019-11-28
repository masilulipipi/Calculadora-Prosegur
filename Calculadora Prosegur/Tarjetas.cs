using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Calculadora_Prosegur
    {
        public partial class Tarjeta : Form

    {
        //double importe, porcentaje, resultado ,abona , puedeabonar ,porciento;

        public object ShowBalloonTip { get; private set; }

        public Tarjeta()
        {
            InitializeComponent();
        
        }
        
        private void Tarjetas_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void importe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnejecuta_Click(object sender, EventArgs e)
        {
            

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            
            txtnum1.Text = "";
            txtnum1.Focus();
            txtimpuesto.Text = "21";
            txtnum2.Text = "0";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            string porcentajemaximo, valormaximo;
            TextReader porciento;
            porciento = new StreamReader("config5.masi");
            porcentajemaximo = porciento.ReadLine();
            decimal porcentajemaximodecimal = Convert.ToDecimal(porcentajemaximo);

            TextReader valorm;
            valorm = new StreamReader("config4.masi");

            valormaximo = valorm.ReadLine();

            decimal valormaximodec = Convert.ToDecimal(valormaximo);


            

            string num1 = txtnum1.Text;
            //num1 = num1.Replace(".", ",");
            string num2 = txtnum2.Text;
            num2 = num2.Replace(".", ",");
            num2 = num2.Replace("%", "");
            decimal num1dec = Convert.ToDecimal(num1);
            decimal numdec2 = Convert.ToDecimal(num2);
            string impuestaso = txtimpuesto.Text;
            decimal impuesto = Convert.ToDecimal(impuestaso);
            

            decimal resultado = num1dec - num1dec * numdec2 / 100;
            decimal masiva = resultado + (resultado * impuesto) / 100;
            decimal coniva = num1dec + num1dec * impuesto / 100;
            decimal nota = num1dec * numdec2 / 100;
            decimal cinco = coniva - (coniva * 5 / 100)  ;
            decimal cincoI = num1dec - (num1dec * 5 /100);
            decimal diez = coniva - (coniva * 10 / 100);
            decimal quince = coniva - (coniva * 15 / 100);
            decimal veinte = coniva - (coniva * 20 / 100);
            decimal venticinco = coniva - (coniva * 25 / 100);
            decimal treinta = coniva - (coniva * 30 / 100);
            decimal treintaicinco = coniva - (coniva * 35 / 100);
            decimal cuarenta = coniva - (coniva * 40 / 100);
            decimal cuarentaycicnco = coniva - (coniva * 45 / 100);
            decimal cincuenta = coniva - (coniva * 50 / 100);
            decimal cincuentaycinco = coniva - (coniva * 55 / 100);
            decimal sesenta = coniva - (coniva * 60 / 100);
            decimal sesentaycinco = coniva - (coniva * 65 / 100);
            decimal setenta = coniva - (coniva * 70 / 100);
            decimal setentaycinco = coniva - (coniva * 75 / 100);
            decimal ochenta = coniva - (coniva * 80 / 100);
            decimal ochentaycinco = coniva - (coniva * 85 / 100);
            decimal noventa = coniva - (coniva * 90 / 100);
            decimal noventaycinco = coniva - (coniva * 95 / 100);

            
            decimal diezI = num1dec - (num1dec * 10 / 100);
            decimal quinceI = num1dec - (num1dec * 15 / 100);
            decimal veinteI = num1dec - (num1dec * 20 / 100);
            decimal venticincoI = num1dec - (num1dec * 25 / 100);
            decimal treintaI = num1dec - (num1dec * 30 / 100);
            decimal treintaicinoI = num1dec - (num1dec * 35 / 100);
            decimal cuarentaI = num1dec - (num1dec * 40 / 100);
            decimal cuarentaycicnoI = num1dec - (num1dec * 45 / 100);
            decimal cincuentaI = num1dec - (num1dec * 50 / 100);
            decimal cincuentaycincoI = num1dec - (num1dec * 55 / 100);
            decimal sesentaI = num1dec - (num1dec * 60 / 100);
            decimal sesentaycincoI = num1dec - (num1dec * 65 / 100);
            decimal setentaI = num1dec - (num1dec * 70 / 100);
            decimal setentaycincoI = num1dec - (num1dec * 75 / 100);
            decimal ochentaI = num1dec - (num1dec * 80 / 100);
            decimal ochentaycincoI = num1dec - (num1dec * 85 / 100);
            decimal noventaI = num1dec - (num1dec * 90 / 100);
            decimal noventaycincoI = num1dec - (num1dec * 95 / 100);



            txtresultado.Text = resultado.ToString("N2");
            txtmasiiva.Text = masiva.ToString("N2");
            txtconiva.Text = coniva.ToString("N2");
            txtnota.Text = nota.ToString("N2");
            listaporcentajes.Text = ("   5 % Menos = ") + cinco.ToString("N2") + ("     ") + cincoI.ToString("N2") + System.Environment.NewLine
                + (" 10 % Menos = ") + diez.ToString("N2") + ("     ") + diezI.ToString("N2") + System.Environment.NewLine
                + (" 15 % Menos = ") + quince.ToString("N2") + ("     ") + quinceI.ToString("N2") + System.Environment.NewLine
                + (" 20 % Menos = ") + veinte.ToString("N2") + ("     ") + veinteI.ToString("N2") + System.Environment.NewLine
                + (" 25 % Menos = ") + venticinco.ToString("N2") + ("     ") + venticincoI.ToString("N2") + System.Environment.NewLine
                + (" 30 % Menos = ") + treinta.ToString("N2") + ("     ") + treintaI.ToString("N2") + System.Environment.NewLine
                + (" 35 % Menos = ") + treintaicinco.ToString("N2") + ("     ") + treintaicinoI.ToString("N2") + System.Environment.NewLine
                + (" 40 % Menos = ") + cuarenta.ToString("N2") + ("     ") + cuarentaI.ToString("N2") + System.Environment.NewLine
                + (" 45 % Menos = ") + cuarentaycicnco.ToString("N2") + ("     ") + cuarentaycicnoI.ToString("N2") + System.Environment.NewLine
                + (" 50 % Menos = ") + cincuenta.ToString("N2") + ("     ") + cincuentaI.ToString("N2") + System.Environment.NewLine
                + (" 55 % Menos = ") + cincuentaycinco.ToString("N2") + ("     ") + cincuentaycincoI.ToString("N2") + System.Environment.NewLine
                + (" 60 % Menos = ") + sesenta.ToString("N2") + ("     ") + sesentaI.ToString("N2") + System.Environment.NewLine
            + (" 65 % Menos = ") + sesentaycinco.ToString("N2") + ("     ") + sesentaycincoI.ToString("N2") + System.Environment.NewLine
            + (" 70 % Menos = ") + setenta.ToString("N2") + ("     ") + setentaI.ToString("N2") + System.Environment.NewLine
            + (" 75 % Menos = ") + setentaycinco.ToString("N2") + ("     ") + setentaycincoI.ToString("N2") + System.Environment.NewLine
            + (" 80 % Menos = ") + ochenta.ToString("N2") + ("     ") + ochentaI.ToString("N2") + System.Environment.NewLine
            + (" 85 % Menos = ") + ochentaycinco.ToString("N2") + ("     ") + ochentaycincoI.ToString("N2") + System.Environment.NewLine
            + (" 90 % Menos = ") + noventa.ToString("N2") + ("     ") + noventaI.ToString("N2") + System.Environment.NewLine
            + (" 95 % Menos = ") + noventaycinco.ToString("N2") + ("     ") + noventaycincoI.ToString("N2") + System.Environment.NewLine;

            txtabona.Text = txtnum1.Text;
            textimporte.Text = txtnum1.Text;


            if (numdec2 > porcentajemaximodecimal)
            {
                MessageBox.Show("El Porcentaje no debe ser mayor a " + porcentajemaximo + "%", "Se Ha Excedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (resultado < valormaximodec)
            {
                MessageBox.Show("El importe sin impuestos no puede ser menor a " + valormaximodec + " $", "Se Ha Excedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                decimal sugerencia;

                sugerencia = (((valormaximodec / num1dec) - 1) * -1) * 100;

                MessageBox.Show("Se sugiere " + sugerencia.ToString("N2") + " %", "                   SUGERENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtnum1.Focus();

                txtnum2.Text = sugerencia.ToString("N2");
            }


            // esto genera 2 decimales
            // txtresultado.Text = resultado.ToString("N2");

            if (numdec2 > 99)
            {
                MessageBox.Show("El porcentaje maximo es 99,99" , "El porcentaje maximo es 99,99" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                txtnum2.Text = "0";
                txtnum2.Focus();
            }

            if (num1dec < 1 )
            {
                MessageBox.Show("Importe mínimo es $ 1", "Importe mínimo es $ 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum2.Focus();
                txtnum2.Text = "0";
            }

        }

        private void btnperro_Click(object sender, EventArgs e)
        {
            //string perro = "chuchero";
            //perro = perro.Replace("chuchero", "mordedura");

            //txtperro.Text = perro;

            //string num1 ="4.4";
            
            //num1 = num1.Replace(".", ",");

            //decimal num1dec = Convert.ToDecimal(num1);


            //txtperro.Text = num1dec.ToString();



        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtnum2_TextChanged(object sender, EventArgs e)
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

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                        
            try
            {
                Clipboard.SetDataObject(txtnum1.Text, true);
                //MessageBox.Show("Texto copiado al portapapeles de Windows.",
                 //   "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtmasiiva.Text);

        }



        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(txtconiva.Text, true);
                //MessageBox.Show("Texto copiado al portapapeles de Windows.",
                //   "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(txtnum2.Text, true);
                //MessageBox.Show("Texto copiado al portapapeles de Windows.",
                //   "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       /* private void button4_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Texto copiado al portapapeles de Windows.",
               "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        */


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(txtresultado.Text, true);
                //MessageBox.Show("Texto copiado al portapapeles de Windows.",
                //   "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Clipboard.SetDataObject(txtnum1.Text, true);
            txtnum1.Text = Clipboard.GetText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtnum2.Text = Clipboard.GetText();
        }

        private void puedepagar_Click(object sender, EventArgs e)
        {
            string abona = txtabona.Text;
            string pueabonar = txtpuedeabonar.Text;
            abona = abona.Replace(".", ",");
            pueabonar = pueabonar.Replace(".", ",");

            decimal abonad = Convert.ToDecimal(abona);
            decimal puedeab = Convert.ToDecimal(pueabonar);

            decimal porciento =(100 * puedeab / abonad -100) * -1;
            

            txtporciento.Text = porciento.ToString("N2");

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtabona.Text = "";
            txtpuedeabonar.Text = "";
            txtporciento.Text = "";
            txtabona.Focus();
        }

        private void txtconiva_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            float importe, dias ,resultado;
            importe = float.Parse(this.textimporte.Text);
            dias = float.Parse(this.textdias.Text);
            resultado = (importe / 30.4f) * dias;
            textdiasdev.Text = resultado.ToString();       


        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textdias.Text = "";
            textdiasdev.Text = "";
            textimporte.Text = "";
        }

        private void txtnum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                System.Windows.Forms.SendKeys.Send("{TAB}");
        }

        private void txtnum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                System.Windows.Forms.SendKeys.Send("{TAB}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(txtnota.Text, true);
                //MessageBox.Show("Texto copiado al portapapeles de Windows.",
                //   "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void abona_TextChanged(object sender, EventArgs e)
        {

        }

        private void coniva_SelectedIndexChanged(object sender, EventArgs e)
        {
            
    }

        private void porcentaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AdminGestionClientes test = new AdminGestionClientes();
            test.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string porcentajemaximo;
            string valormaximo;
            string mensaje;

            TextReader porciento;
            porciento = new StreamReader("config5.masi");

            porcentajemaximo = porciento.ReadLine();
            porciento.Close();


            decimal porcentajemaximodecimal = Convert.ToDecimal(porcentajemaximo);

            TextReader valorm;
            valorm = new StreamReader("config4.masi");

            valormaximo = valorm.ReadLine();
            valorm.Close();


            decimal valormaximodec = Convert.ToDecimal(valormaximo);



            TextReader mensajito;
            mensajito = new StreamReader("config6.masi");

            mensaje = mensajito.ReadToEnd();
            mensajito.Close();




            MessageBox.Show("Recuerde que el porcentaje máximo para descontar es " + porcentajemaximo + " % y el costo mínimo para poder realizar un descuento es $ " + valormaximo + " " + mensaje, "Tips del día", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void button14_Click(object sender, EventArgs e)
        {
           
        }
    }
    }
