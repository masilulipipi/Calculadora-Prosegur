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
    public partial class Form1 : Form
    {
        public void Mensajito()
        {
            //MessageBox.Show("nnnnnnnnnnnnnnnnn");
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro que desea salir ?", "Salir Del Programa ?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarjeta test = new Tarjeta();
            test.ShowDialog();

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Acerca test = new Acerca();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void linklavelbtn_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            /* ProcessStartInfo info = new ProcessStartInfo();

             info.UseShellExecute = true;
             info.FileName = "Calculator.exe";
             info.WorkingDirectory = "C:\\Calculator.exe";

             Process.Start(info);*/
        }
        Tarjeta aver;
        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aver == null)
            {
                aver = new Tarjeta();
                aver.MdiParent = this;
                aver.FormClosed += new FormClosedEventHandler(aver_FormClosed);
                aver.Show();

            }
            else
                aver.Activate();


        }
        private void aver_FormClosed(object sender, FormClosedEventArgs e)
        {
            aver = null;
        }
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca test = new Acerca();
            test.ShowDialog();
            if (test.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void programaExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* ProcessStartInfo info = new ProcessStartInfo();

            info.UseShellExecute = true;
            info.FileName = "Calculator.exe";
            info.WorkingDirectory = "C:\\Calculator.exe";

            Process.Start(info);*/
        }
        Tarjeta  f2;

        private void button1_Click_1(object sender, EventArgs e)
        {
            Mensajito();


            if (f2 == null)
            {
                f2 = new Tarjeta();
                f2.MdiParent = this;
                f2.FormClosed += new FormClosedEventHandler(f3_FormClosed);
                f2.Show();

            }
            else
                f2.Activate();
            

            



            


            /*Tarjeta Nuevo = new Tarjeta();
            Nuevo.MdiParent = this;
            Nuevo.Show();*/

        }

        private void f3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }
        ubo fubo;
        private void button2_Click_1(object sender, EventArgs e)
        {

            if (fubo == null)
            {
                fubo = new ubo();
                fubo.MdiParent = this;
                fubo.FormClosed += new FormClosedEventHandler(fubo_FormClosed);
                fubo.Show();

            }
            else
                fubo.Activate();

             



            /*ubo Nuevo = new ubo();
            Nuevo.MdiParent = this;
            Nuevo.Show();*/
        }
        private void fubo_FormClosed(object sender, FormClosedEventArgs e)
        {
            fubo = null;
        }

        ubo superubo;
        private void otrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (superubo == null)
            {
                superubo = new ubo();
                superubo.MdiParent = this;
                superubo.FormClosed += new FormClosedEventHandler(superubo_FormClosed);
                superubo.Show();

            }
            else
                superubo.Activate();
        }

        private void superubo_FormClosed(object sender, FormClosedEventArgs e)
        {
            superubo = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Esta seguro que quiere salir ?", "Salir Del Programa ?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                
            }
        }

        private void sugerenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:" + "maximiliano.resch@prosegur.com");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process.Start("mailto:" + "maximiliano.resch@prosegur.com");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Calculadora_de_masi Nuevo = new Calculadora_de_masi();
            Nuevo.MdiParent = this;
            Nuevo.Show();
                        
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
        cobranzas fcobra;

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (fcobra == null)
            {
                fcobra = new cobranzas();
                fcobra.MdiParent = this;
                fcobra.FormClosed += new FormClosedEventHandler(fcobra_FormClosed);
                fcobra.Show();

            }
            else
                fcobra.Activate();

            

            
            
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
            



            MessageBox.Show("Recuerde que el porcentaje máximo para descontar es " + porcentajemaximo + " % y el costo mínimo para poder realizar un descuento es $ " + valormaximo + " " + mensaje, "Tips del día",MessageBoxButtons.OK,MessageBoxIcon.Question);

        }
        private void fcobra_FormClosed(object sender, FormClosedEventArgs e)
        {
            fcobra = null;
        }

        cobranzas f74;
        private void cobranzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f74 == null)
            {
                f74 = new cobranzas();
                f74.MdiParent = this;
                f74.FormClosed += new FormClosedEventHandler(f74_FormClosed);
                f74.Show();

            }
            else
                f74.Activate();
        }
        private void f74_FormClosed(object sender, FormClosedEventArgs e)
        {
            f74 = null;
        }
        private void calculadoraBásicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora_de_masi Nuevo = new Calculadora_de_masi();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Mensajito();
        }
    }
}
