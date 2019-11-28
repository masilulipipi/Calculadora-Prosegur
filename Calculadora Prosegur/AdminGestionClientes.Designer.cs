namespace Calculadora_Prosegur
{
    partial class AdminGestionClientes
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
            this.btnsalirloguin = new System.Windows.Forms.Button();
            this.btnentrarloguin = new System.Windows.Forms.Button();
            this.txtcontrasenia = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalirloguin
            // 
            this.btnsalirloguin.Location = new System.Drawing.Point(139, 224);
            this.btnsalirloguin.Name = "btnsalirloguin";
            this.btnsalirloguin.Size = new System.Drawing.Size(75, 23);
            this.btnsalirloguin.TabIndex = 74;
            this.btnsalirloguin.Text = "Salir";
            this.btnsalirloguin.UseVisualStyleBackColor = true;
            this.btnsalirloguin.Click += new System.EventHandler(this.btnsalirloguin_Click);
            // 
            // btnentrarloguin
            // 
            this.btnentrarloguin.Location = new System.Drawing.Point(15, 224);
            this.btnentrarloguin.Name = "btnentrarloguin";
            this.btnentrarloguin.Size = new System.Drawing.Size(75, 23);
            this.btnentrarloguin.TabIndex = 69;
            this.btnentrarloguin.Text = "Iniciar";
            this.btnentrarloguin.UseVisualStyleBackColor = true;
            this.btnentrarloguin.Click += new System.EventHandler(this.btnentrarloguin_Click);
            // 
            // txtcontrasenia
            // 
            this.txtcontrasenia.Location = new System.Drawing.Point(114, 187);
            this.txtcontrasenia.Name = "txtcontrasenia";
            this.txtcontrasenia.PasswordChar = '*';
            this.txtcontrasenia.Size = new System.Drawing.Size(100, 20);
            this.txtcontrasenia.TabIndex = 68;
            this.txtcontrasenia.UseSystemPasswordChar = true;
            this.txtcontrasenia.TextChanged += new System.EventHandler(this.txtcontrasenia_TextChanged);
            this.txtcontrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontrasenia_KeyDown);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(114, 150);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 67;
            this.txtusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusuario_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Usuario:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calculadora_Prosegur.Properties.Resources.padlock_154684_960_720;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora_Prosegur.Properties.Resources.image001;
            this.pictureBox1.Location = new System.Drawing.Point(124, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 96);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // AdminGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 269);
            this.Controls.Add(this.btnsalirloguin);
            this.Controls.Add(this.btnentrarloguin);
            this.Controls.Add(this.txtcontrasenia);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminGestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGestionClientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnsalirloguin;
        public System.Windows.Forms.Button btnentrarloguin;
        public System.Windows.Forms.TextBox txtcontrasenia;
        public System.Windows.Forms.TextBox txtusuario;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}