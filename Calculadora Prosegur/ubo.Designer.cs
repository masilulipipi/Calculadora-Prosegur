namespace Calculadora_Prosegur
{
    partial class ubo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ubo));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtconiva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmasiiva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listcuotas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(156, 105);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 29;
            this.btnlimpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnlimpiar, "Borra todos los datos ingresados");
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(39, 105);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 28;
            this.btnsuma.Text = "Ejecutar";
            this.toolTip1.SetToolTip(this.btnsuma, "Calcula automáticamente los descuentos");
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(256, 41);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 26;
            this.txtnum1.Text = "0";
            this.toolTip1.SetToolTip(this.txtnum1, "Ingrese el importe respetando las comas para decimales");
            this.txtnum1.TextChanged += new System.EventHandler(this.txtnum1_TextChanged);
            this.txtnum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnum1_KeyDown);
            this.txtnum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum1_KeyPress);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(397, 65);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(28, 29);
            this.button7.TabIndex = 38;
            this.toolTip1.SetToolTip(this.button7, "Pegar");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(397, 33);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(28, 29);
            this.button6.TabIndex = 37;
            this.toolTip1.SetToolTip(this.button6, "Pegar");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(362, 65);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(29, 28);
            this.button4.TabIndex = 36;
            this.toolTip1.SetToolTip(this.button4, "Copiar");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(631, 39);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(29, 28);
            this.button3.TabIndex = 35;
            this.toolTip1.SetToolTip(this.button3, "Copiar");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(362, 33);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 33;
            this.toolTip1.SetToolTip(this.button1, "Copiar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(362, 257);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(29, 28);
            this.button8.TabIndex = 49;
            this.toolTip1.SetToolTip(this.button8, "Copiar");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(362, 181);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(29, 28);
            this.button5.TabIndex = 46;
            this.toolTip1.SetToolTip(this.button5, "Copiar");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(631, 176);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(29, 28);
            this.button2.TabIndex = 44;
            this.toolTip1.SetToolTip(this.button2, "Copiar");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtconiva
            // 
            this.txtconiva.Location = new System.Drawing.Point(525, 41);
            this.txtconiva.Name = "txtconiva";
            this.txtconiva.ReadOnly = true;
            this.txtconiva.Size = new System.Drawing.Size(100, 20);
            this.txtconiva.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(447, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Con I.V.A =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(36, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Porcentaje a descontar =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Importe total de los anexos =";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(256, 65);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 27;
            this.txtnum2.Text = "0";
            this.txtnum2.TextChanged += new System.EventHandler(this.txtnum2_TextChanged);
            this.txtnum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnum2_KeyDown);
            this.txtnum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum2_KeyPress);
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(256, 262);
            this.txtnota.Name = "txtnota";
            this.txtnota.ReadOnly = true;
            this.txtnota.Size = new System.Drawing.Size(100, 20);
            this.txtnota.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(41, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "Descuento Sin I.V.A =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Para descontar en Siebel ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Con descuentos incluidos";
            // 
            // txtmasiiva
            // 
            this.txtmasiiva.Location = new System.Drawing.Point(525, 181);
            this.txtmasiiva.Name = "txtmasiiva";
            this.txtmasiiva.ReadOnly = true;
            this.txtmasiiva.Size = new System.Drawing.Size(100, 20);
            this.txtmasiiva.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(36, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Importe con descuento y sin I.V.A =";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(256, 186);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(446, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "En cuotas con tarjeta";
            // 
            // listcuotas
            // 
            this.listcuotas.Location = new System.Drawing.Point(450, 266);
            this.listcuotas.Multiline = true;
            this.listcuotas.Name = "listcuotas";
            this.listcuotas.ReadOnly = true;
            this.listcuotas.Size = new System.Drawing.Size(191, 176);
            this.listcuotas.TabIndex = 51;
            this.listcuotas.TextChanged += new System.EventHandler(this.listcuotas_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(447, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "Con I.V.A =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Venta de anexos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora_Prosegur.Properties.Resources.image001;
            this.pictureBox1.Location = new System.Drawing.Point(702, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 96);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // ubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listcuotas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtmasiiva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtconiva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Name = "ubo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "U.B.O";
            this.Load += new System.EventHandler(this.ubo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtconiva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtmasiiva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox listcuotas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}