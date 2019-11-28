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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnsalirloguin_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            /*
            Admin Cerrarlo = new Admin();
            Admin.
                */

        }

        private void btnentrarloguin_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "adm" && txtcontrasenia.Text == "coco")
            {
                parametros_administrador test = new parametros_administrador();
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

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnum1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcontrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                System.Windows.Forms.SendKeys.Send("{TAB}" + "{Enter}");
            //System.Windows.Forms.SendKeys.Send("{Enter}");
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                System.Windows.Forms.SendKeys.Send("{TAB}");
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
