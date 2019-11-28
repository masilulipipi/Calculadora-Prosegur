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
    public partial class Calculadora_de_masi : Form
    {
        double primero, segundo, resultado;
        string operacion;
        bool borrarcero = true;

        public Calculadora_de_masi()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "0")
            {
                return;
            }

            else
            {
                pantalla.Text = pantalla.Text + "0";

            }

            if (pantalla.Text == "0")
            {
                return;
            }

            else
            {
                historial.Text = historial.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (borrarcero)
            {
                pantalla.Text = "";
                pantalla.Text = "1";
                historial.Text = "";
                historial.Text = "1";
                borrarcero = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "1";
                historial.Text = historial.Text + "1";
            }


        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (borrarcero)
            {
                pantalla.Text = "";
                pantalla.Text = "2";
                historial.Text = "";
                historial.Text = "2";
                borrarcero = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "2";
                historial.Text = historial.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (borrarcero)
            {
                pantalla.Text = "";
                pantalla.Text = "3";
                historial.Text = "";
                historial.Text = "3";
                borrarcero = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "3";
                historial.Text = historial.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (borrarcero)
            {
                pantalla.Text = "";
                pantalla.Text = "4";
                historial.Text = "";
                historial.Text = "4";
                borrarcero = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "4";
                historial.Text = historial.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (borrarcero)
            {
                pantalla.Text = "";
                pantalla.Text = "5";
                historial.Text = "";
                historial.Text = "5";
                borrarcero = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "5";
                historial.Text = historial.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (borrarcero)
            {
                pantalla.Text = "";
                pantalla.Text = "6";
                historial.Text = "";
                historial.Text = "6";
                borrarcero = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "6";
                historial.Text = historial.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (borrarcero)
            {
                pantalla.Text = "";
                pantalla.Text = "7";
                historial.Text = "";
                historial.Text = "7";
                borrarcero = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "7";
                historial.Text = historial.Text + "7";
            }
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            //borrarcero = true;
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
            historial.Text = historial.Text + " + ";

        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
            historial.Text = historial.Text + " - ";
        }

        private void btnpor_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
            historial.Text = historial.Text + " * ";
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
            historial.Text = historial.Text + " / ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length == 1)
            {
                pantalla.Text = "0";
            }
            else
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
            }
            if (historial.Text.Length == 1)
            {
                historial.Text = "0";
            }
            else
            {
                historial.Text = historial.Text.Substring(0, historial.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnporcentaje_Click_1(object sender, EventArgs e)
        {
            operacion = "%";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
            historial.Text = historial.Text + System.Environment.NewLine + "%" + System.Environment.NewLine;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    pantalla.Text = resultado.ToString();
                    historial.Text = historial.Text + " = " + resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();
                    historial.Text = historial.Text + " = " + resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();
                    historial.Text = historial.Text + " = " + resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();
                    historial.Text = historial.Text + " = " + resultado.ToString();
                    break;
                case "%":
                    resultado = primero * segundo / 100;
                    pantalla.Text = resultado.ToString();
                    historial.Text = historial.Text + " = " + resultado.ToString();
                    break;

            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            pantalla.Text = "0";
            historial.Text = historial.Text + System.Environment.NewLine + "------0------" + System.Environment.NewLine;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion = "Raiz";
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla.Text = Math.Sqrt(primero).ToString();
            historial.Text = historial.Text + " Raiz = " + Math.Sqrt(primero).ToString();
        }

        private void btncoma_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Contains(","))
            {

            }

            else {

                pantalla.Text = pantalla.Text + ",";
                historial.Text = historial.Text + ",";
            }
        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (borrarcero)
            {
                pantalla.Text = "";
                pantalla.Text = "8";
                historial.Text = "";
                historial.Text = "8";
                borrarcero = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "8";
                historial.Text = historial.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (borrarcero)
            {
                pantalla.Text = "";
                pantalla.Text = "9";
                historial.Text = "";
                historial.Text = "9";
                borrarcero = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "9";
                historial.Text = historial.Text + "9";
            }
        }
    }
}
