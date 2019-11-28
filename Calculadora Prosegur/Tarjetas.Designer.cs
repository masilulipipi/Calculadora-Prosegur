namespace Calculadora_Prosegur
{
    partial class Tarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarjeta));
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtmasiiva = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtconiva = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtabona = new System.Windows.Forms.TextBox();
            this.txtpuedeabonar = new System.Windows.Forms.TextBox();
            this.puedepagar = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textdias = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textimporte = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtporciento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.listaporcentajes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtimpuesto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textdiasdev = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(240, 38);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtnum1, "Ingrese el importe respetando las comas para decimales");
            this.txtnum1.TextChanged += new System.EventHandler(this.txtnum1_TextChanged);
            this.txtnum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnum1_KeyDown);
            this.txtnum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum1_KeyPress);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(240, 72);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(79, 20);
            this.txtnum2.TabIndex = 1;
            this.txtnum2.Text = "0";
            this.txtnum2.TextChanged += new System.EventHandler(this.txtnum2_TextChanged);
            this.txtnum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnum2_KeyDown);
            this.txtnum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum2_KeyPress);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(240, 183);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 4;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(30, 119);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 2;
            this.btnsuma.Text = "Ejecutar";
            this.toolTip1.SetToolTip(this.btnsuma, "Calcula automáticamente los descuentos");
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Abono actual Sin I.V.A =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(27, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Porcentaje a descontar =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(30, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Abono con descuento sin I.V.A =";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(124, 119);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnlimpiar, "Borra todos los datos ingresados");
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtmasiiva
            // 
            this.txtmasiiva.Location = new System.Drawing.Point(493, 182);
            this.txtmasiiva.Name = "txtmasiiva";
            this.txtmasiiva.ReadOnly = true;
            this.txtmasiiva.Size = new System.Drawing.Size(100, 20);
            this.txtmasiiva.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(346, 33);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 15;
            this.toolTip1.SetToolTip(this.button1, "Copiar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(603, 178);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(29, 28);
            this.button2.TabIndex = 16;
            this.toolTip1.SetToolTip(this.button2, "Copiar");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(415, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Con I.V.A =";
            // 
            // txtconiva
            // 
            this.txtconiva.Location = new System.Drawing.Point(497, 37);
            this.txtconiva.Name = "txtconiva";
            this.txtconiva.ReadOnly = true;
            this.txtconiva.Size = new System.Drawing.Size(100, 20);
            this.txtconiva.TabIndex = 7;
            this.txtconiva.TextChanged += new System.EventHandler(this.txtconiva_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 569);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Con descuentos incluidos";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(603, 35);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(29, 28);
            this.button3.TabIndex = 21;
            this.toolTip1.SetToolTip(this.button3, "Copiar");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(346, 66);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(29, 28);
            this.button4.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button4, "Copiar");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(350, 178);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(29, 28);
            this.button5.TabIndex = 23;
            this.toolTip1.SetToolTip(this.button5, "Copiar");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(381, 33);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(28, 29);
            this.button6.TabIndex = 24;
            this.toolTip1.SetToolTip(this.button6, "Pegar");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(381, 67);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(28, 29);
            this.button7.TabIndex = 25;
            this.toolTip1.SetToolTip(this.button7, "Pegar");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Para la nota de crédito";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(35, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Valor nota de crédito Sin I.V.A =";
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(240, 254);
            this.txtnota.Name = "txtnota";
            this.txtnota.ReadOnly = true;
            this.txtnota.Size = new System.Drawing.Size(100, 20);
            this.txtnota.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(350, 250);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(29, 28);
            this.button8.TabIndex = 29;
            this.toolTip1.SetToolTip(this.button8, "Copiar");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtabona
            // 
            this.txtabona.Location = new System.Drawing.Point(240, 313);
            this.txtabona.Name = "txtabona";
            this.txtabona.Size = new System.Drawing.Size(100, 20);
            this.txtabona.TabIndex = 33;
            this.toolTip1.SetToolTip(this.txtabona, "Ingrese el importe respetando las comas para decimales");
            this.txtabona.TextChanged += new System.EventHandler(this.abona_TextChanged);
            this.txtabona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum1_KeyPress);
            // 
            // txtpuedeabonar
            // 
            this.txtpuedeabonar.Location = new System.Drawing.Point(240, 342);
            this.txtpuedeabonar.Name = "txtpuedeabonar";
            this.txtpuedeabonar.Size = new System.Drawing.Size(100, 20);
            this.txtpuedeabonar.TabIndex = 34;
            this.toolTip1.SetToolTip(this.txtpuedeabonar, "Ingrese el importe respetando las comas para decimales");
            this.txtpuedeabonar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum2_KeyPress);
            // 
            // puedepagar
            // 
            this.puedepagar.Location = new System.Drawing.Point(35, 361);
            this.puedepagar.Name = "puedepagar";
            this.puedepagar.Size = new System.Drawing.Size(75, 23);
            this.puedepagar.TabIndex = 35;
            this.puedepagar.Text = "Ejecutar";
            this.toolTip1.SetToolTip(this.puedepagar, "Borra todos los datos ingresados");
            this.puedepagar.UseVisualStyleBackColor = true;
            this.puedepagar.Click += new System.EventHandler(this.puedepagar_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(134, 361);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 37;
            this.button9.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.button9, "Borra todos los datos ingresados");
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textdias
            // 
            this.textdias.Location = new System.Drawing.Point(240, 474);
            this.textdias.Name = "textdias";
            this.textdias.Size = new System.Drawing.Size(100, 20);
            this.textdias.TabIndex = 59;
            this.toolTip1.SetToolTip(this.textdias, "Ingrese el importe respetando las comas para decimales");
            this.textdias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum1_KeyPress);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(147, 534);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 63;
            this.button10.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.button10, "Borra todos los datos ingresados");
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(38, 534);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 62;
            this.button11.Text = "Ejecutar";
            this.toolTip1.SetToolTip(this.button11, "Borra todos los datos ingresados");
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textimporte
            // 
            this.textimporte.Location = new System.Drawing.Point(240, 448);
            this.textimporte.Name = "textimporte";
            this.textimporte.Size = new System.Drawing.Size(100, 20);
            this.textimporte.TabIndex = 64;
            this.toolTip1.SetToolTip(this.textimporte, "Ingrese el importe respetando las comas para decimales");
            this.textimporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum1_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(35, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Cliente abona =";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(35, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Puede abonar =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Porcentaje =";
            // 
            // txtporciento
            // 
            this.txtporciento.Location = new System.Drawing.Point(240, 383);
            this.txtporciento.Name = "txtporciento";
            this.txtporciento.ReadOnly = true;
            this.txtporciento.Size = new System.Drawing.Size(76, 20);
            this.txtporciento.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(322, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "%";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Propuesta Prosegur";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Propuesta Cliente";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(324, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 15);
            this.label15.TabIndex = 40;
            this.label15.Text = "%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(415, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "Con I.V.A =";
            // 
            // listaporcentajes
            // 
            this.listaporcentajes.Location = new System.Drawing.Point(441, 255);
            this.listaporcentajes.Multiline = true;
            this.listaporcentajes.Name = "listaporcentajes";
            this.listaporcentajes.ReadOnly = true;
            this.listaporcentajes.Size = new System.Drawing.Size(191, 261);
            this.listaporcentajes.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Con IVA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(578, 236);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 15);
            this.label17.TabIndex = 54;
            this.label17.Text = "Sin IVA";
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.Location = new System.Drawing.Point(240, 98);
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.Size = new System.Drawing.Size(29, 20);
            this.txtimpuesto.TabIndex = 55;
            this.txtimpuesto.Text = "21";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(275, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 15);
            this.label18.TabIndex = 56;
            this.label18.Text = "%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora_Prosegur.Properties.Resources.image001;
            this.pictureBox1.Location = new System.Drawing.Point(751, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 96);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(35, 475);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 16);
            this.label19.TabIndex = 58;
            this.label19.Text = "Dias de descuento  =";
            // 
            // textdiasdev
            // 
            this.textdiasdev.Location = new System.Drawing.Point(240, 500);
            this.textdiasdev.Name = "textdiasdev";
            this.textdiasdev.ReadOnly = true;
            this.textdiasdev.Size = new System.Drawing.Size(100, 20);
            this.textdiasdev.TabIndex = 60;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(35, 500);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(174, 16);
            this.label20.TabIndex = 61;
            this.label20.Text = "Importe a devolver sin IVA =";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(35, 448);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 16);
            this.label21.TabIndex = 65;
            this.label21.Text = "Importe Sin IVA  =";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(34, 418);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(142, 20);
            this.label22.TabIndex = 66;
            this.label22.Text = "Devolucion de días";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(768, 111);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 67;
            this.button12.Text = "Admin";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(683, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(667, 15);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(78, 29);
            this.button13.TabIndex = 94;
            this.button13.Text = "Tips...";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(868, 569);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textimporte);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textdiasdev);
            this.Controls.Add(this.textdias);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtimpuesto);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listaporcentajes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.puedepagar);
            this.Controls.Add(this.txtporciento);
            this.Controls.Add(this.txtpuedeabonar);
            this.Controls.Add(this.txtabona);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtconiva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmasiiva);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tarjeta";
            this.Text = "Descuentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtmasiiva;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtconiva;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtabona;
        private System.Windows.Forms.TextBox txtpuedeabonar;
        private System.Windows.Forms.TextBox txtporciento;
        private System.Windows.Forms.Button puedepagar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox listaporcentajes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtimpuesto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textdias;
        private System.Windows.Forms.TextBox textdiasdev;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textimporte;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button13;
    }
}