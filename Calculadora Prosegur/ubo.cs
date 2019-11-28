using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_Prosegur
{
    public partial class ubo : Form
    {
        //bool borrarcero = true;
        public ubo()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            string num1 = txtnum1.Text;
            //num1 = num1.Replace(".", ",");
            string num2 = txtnum2.Text ;
            num2 = num2.Replace(".", ",");
            num2 = num2.Replace("%", "");

            
            
            
           // num2 = num2.Replace("", "0");
            decimal num1dec = Convert.ToDecimal(num1);
            decimal numdec2 = Convert.ToDecimal(num2);
            


            decimal resultado = num1dec - num1dec * numdec2 / 100;
            decimal masiva = resultado + (resultado * 21) / 100;
            decimal coniva = num1dec + num1dec * 21 / 100;
            decimal nota = num1dec * numdec2 / 100;
            decimal unacuotas = masiva;
            decimal doscuotas = masiva / 2;
            decimal trescuotas = masiva / 3;
            decimal cuatrocuotas = masiva / 4;
            decimal cincocuotas = masiva / 5;
            decimal seiscuotas = masiva / 6;
            decimal sietecuotas = (masiva * 1332 / 1000) / 7;
            decimal ochocuotas = (masiva * 1346 / 1000) / 8;
            decimal nuevecuotas = (masiva * 1361 / 1000) / 9;
            decimal diezcuotas = (masiva * 1376 / 1000) / 10;
            decimal oncecuotas = (masiva * 1391 / 1000) / 11;
            decimal docecuotas = (masiva * 1407 / 1000) / 12;
            

            txtresultado.Text = resultado.ToString();
            txtmasiiva.Text = masiva.ToString();
            txtconiva.Text = coniva.ToString();
            txtnota.Text = nota.ToString();
            listcuotas.Text = ("1 Cuota  sin interes de = ") + unacuotas.ToString("N2") + System.Environment.NewLine
                + ("2 Cuotas sin interes de = ") + doscuotas.ToString("N2") + System.Environment.NewLine
                + ("3 Cuotas sin interes de = ") + trescuotas.ToString("N2") + System.Environment.NewLine
                + ("4 Cuotas sin interes de = ") + cuatrocuotas.ToString("N2") + System.Environment.NewLine
                + ("5 Cuotas sin interes de = ") + cincocuotas.ToString("N2") + System.Environment.NewLine
                + ("6 Cuotas sin interes de = ") + seiscuotas.ToString("N2") + System.Environment.NewLine
                + ("7 Cuotas CON interes de = ") + sietecuotas.ToString("N2") + System.Environment.NewLine
                + ("8 Cuotas CON interes de = ") + ochocuotas.ToString("N2") + System.Environment.NewLine
                + ("9 Cuotas CON interes de = ") + nuevecuotas.ToString("N2") + System.Environment.NewLine
                + ("10 Cuotas CON interes de = ") + diezcuotas.ToString("N2") + System.Environment.NewLine
                + ("11 Cuotas CON interes de = ") + oncecuotas.ToString("N2") + System.Environment.NewLine
                + ("12 Cuotas CON interes de = ") + docecuotas.ToString("N2") + System.Environment.NewLine;

            if (numdec2 > 99)
            {
                MessageBox.Show("El porcentaje maximo es 99,99", "El porcentaje maximo es 99,99", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnum2.Text = "0";
                txtnum2.Focus();
            }
            // AHORA PROBAR EL BORRACERO

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtnum1.Text, true);
        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
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

        private void txtnum2_TextChanged(object sender, EventArgs e)
        {
                   
        }

        private void listcuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtnum2.Text, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtresultado.Text, true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtnota.Text, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtconiva.Text, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtmasiiva.Text, true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtnum1.Text = Clipboard.GetText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtnum2.Text = Clipboard.GetText();
        }

        private void listcuotas_TextChanged(object sender, EventArgs e)
        {

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

        private void ubo_Load(object sender, EventArgs e)
        {

        }
    }
}
