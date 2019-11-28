namespace Calculadora_Prosegur
{
    partial class parametros_administrador
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
            this.btngrabar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtmaximo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(42, 258);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(75, 23);
            this.btngrabar.TabIndex = 3;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Costo mínimo =";
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(123, 51);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(58, 20);
            this.txtcosto.TabIndex = 0;
            this.txtcosto.TextChanged += new System.EventHandler(this.txtcosto_TextChanged);
            this.txtcosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcosto_KeyDown);
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum1_KeyPress);
            // 
            // txtmaximo
            // 
            this.txtmaximo.Location = new System.Drawing.Point(123, 92);
            this.txtmaximo.Name = "txtmaximo";
            this.txtmaximo.Size = new System.Drawing.Size(37, 20);
            this.txtmaximo.TabIndex = 1;
            this.txtmaximo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcosto_KeyDown);
            this.txtmaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porcentaje máximo =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "+ Impuestos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(158, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(123, 127);
            this.txtmensaje.Multiline = true;
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(281, 114);
            this.txtmensaje.TabIndex = 2;
            this.txtmensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcosto_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mensaje =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Grabar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // parametros_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaximo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngrabar);
            this.Name = "parametros_administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parámetors Administrador";
            this.Load += new System.EventHandler(this.parametros_administrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtmaximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}