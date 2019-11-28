namespace Calculadora_Prosegur
{
    partial class cobranzas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cobranzas));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtimportecobranza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtporcencobranza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtimporteconivaincluidocobranza = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.txtnotacredito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcondescuentos = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsinimpuestos = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.txtnose = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "Administrador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ejecutar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Importe actual sin impuestos =";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora_Prosegur.Properties.Resources.image001;
            this.pictureBox1.Location = new System.Drawing.Point(768, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 96);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 62;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtimportecobranza
            // 
            this.txtimportecobranza.Location = new System.Drawing.Point(172, 46);
            this.txtimportecobranza.Name = "txtimportecobranza";
            this.txtimportecobranza.Size = new System.Drawing.Size(69, 20);
            this.txtimportecobranza.TabIndex = 0;
            this.txtimportecobranza.Text = "0";
            this.txtimportecobranza.TextChanged += new System.EventHandler(this.txtimportecobranza_TextChanged);
            this.txtimportecobranza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtimportecobranza_KeyDown);
            this.txtimportecobranza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimportecobranza_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Porcentaje =";
            // 
            // txtporcencobranza
            // 
            this.txtporcencobranza.Location = new System.Drawing.Point(172, 74);
            this.txtporcencobranza.Name = "txtporcencobranza";
            this.txtporcencobranza.Size = new System.Drawing.Size(55, 20);
            this.txtporcencobranza.TabIndex = 1;
            this.txtporcencobranza.Text = "0";
            this.txtporcencobranza.TextChanged += new System.EventHandler(this.txtporcencobranza_TextChanged);
            this.txtporcencobranza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtporcencobranza_KeyDown);
            this.txtporcencobranza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimportecobranza_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(408, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Con impuestos =";
            // 
            // txtimporteconivaincluidocobranza
            // 
            this.txtimporteconivaincluidocobranza.Location = new System.Drawing.Point(499, 46);
            this.txtimporteconivaincluidocobranza.Name = "txtimporteconivaincluidocobranza";
            this.txtimporteconivaincluidocobranza.ReadOnly = true;
            this.txtimporteconivaincluidocobranza.Size = new System.Drawing.Size(100, 20);
            this.txtimporteconivaincluidocobranza.TabIndex = 69;
            this.txtimporteconivaincluidocobranza.TextChanged += new System.EventHandler(this.txtimporteconivaincluidocobranza_TextChanged);
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(339, 325);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(29, 28);
            this.button8.TabIndex = 81;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtnotacredito
            // 
            this.txtnotacredito.Location = new System.Drawing.Point(233, 330);
            this.txtnotacredito.Name = "txtnotacredito";
            this.txtnotacredito.ReadOnly = true;
            this.txtnotacredito.Size = new System.Drawing.Size(100, 20);
            this.txtnotacredito.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(12, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Descuento Sin I.V.A =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Para la nota de crédito ";
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(339, 214);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(29, 28);
            this.button5.TabIndex = 78;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Con descuentos incluidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(13, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Con Impuestos =";
            // 
            // txtcondescuentos
            // 
            this.txtcondescuentos.Location = new System.Drawing.Point(233, 219);
            this.txtcondescuentos.Name = "txtcondescuentos";
            this.txtcondescuentos.ReadOnly = true;
            this.txtcondescuentos.Size = new System.Drawing.Size(100, 20);
            this.txtcondescuentos.TabIndex = 74;
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(374, 73);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(28, 29);
            this.button7.TabIndex = 73;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(374, 41);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(28, 29);
            this.button6.TabIndex = 72;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(339, 73);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(29, 28);
            this.button4.TabIndex = 71;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(339, 41);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button9.Size = new System.Drawing.Size(29, 28);
            this.button9.TabIndex = 70;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(605, 41);
            this.button10.Name = "button10";
            this.button10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button10.Size = new System.Drawing.Size(29, 28);
            this.button10.TabIndex = 82;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(233, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 15);
            this.label18.TabIndex = 84;
            this.label18.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 15);
            this.label9.TabIndex = 85;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(247, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 15);
            this.label10.TabIndex = 86;
            this.label10.Text = "+";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(13, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "Sin Impuestos =";
            // 
            // txtsinimpuestos
            // 
            this.txtsinimpuestos.Location = new System.Drawing.Point(233, 249);
            this.txtsinimpuestos.Name = "txtsinimpuestos";
            this.txtsinimpuestos.ReadOnly = true;
            this.txtsinimpuestos.Size = new System.Drawing.Size(100, 20);
            this.txtsinimpuestos.TabIndex = 88;
            // 
            // button11
            // 
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(339, 248);
            this.button11.Name = "button11";
            this.button11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button11.Size = new System.Drawing.Size(29, 28);
            this.button11.TabIndex = 89;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // txtnose
            // 
            this.txtnose.Location = new System.Drawing.Point(268, 47);
            this.txtnose.Name = "txtnose";
            this.txtnose.Size = new System.Drawing.Size(39, 20);
            this.txtnose.TabIndex = 90;
            this.txtnose.Text = "21";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Importe para ofrecer";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(684, 9);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(78, 29);
            this.button12.TabIndex = 92;
            this.button12.Text = "Tips...";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(700, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cobranzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(886, 607);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnose);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.txtsinimpuestos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtnotacredito);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcondescuentos);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.txtimporteconivaincluidocobranza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtporcencobranza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtimportecobranza);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cobranzas";
            this.Text = "Cobranzas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.cobranzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtimportecobranza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtporcencobranza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtimporteconivaincluidocobranza;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtnotacredito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcondescuentos;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsinimpuestos;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox txtnose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}