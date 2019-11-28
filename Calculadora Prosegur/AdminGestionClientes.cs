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
    public partial class AdminGestionClientes : Form
    {
        public AdminGestionClientes()
        {
            InitializeComponent();
        }

        private void btnsalirloguin_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnentrarloguin_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "adm" && txtcontrasenia.Text == "coco")
            {
                ParametrosAdmiGestion test = new ParametrosAdmiGestion();
                test.ShowDialog();
                this.Close();
                this.Dispose();


            }

            else
            {
                MessageBox.Show("Por favor Intente nuevamente", "Usuario o contraseña incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtusuario.Text = "";
                txtcontrasenia.Text = "";
                txtusuario.Focus();
            }
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                System.Windows.Forms.SendKeys.Send("{TAB}");
        }

        private void txtcontrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                System.Windows.Forms.SendKeys.Send("{TAB}" + "{Enter}");
        }
    }
}
