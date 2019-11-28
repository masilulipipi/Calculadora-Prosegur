namespace Calculadora_Prosegur
{
    partial class ParametrosAdmiGestion
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaximo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mensaje =";
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(125, 91);
            this.txtmensaje.Multiline = true;
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(281, 114);
            this.txtmensaje.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(160, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "+ Impuestos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "%";
            // 
            // txtmaximo
            // 
            this.txtmaximo.Location = new System.Drawing.Point(125, 56);
            this.txtmaximo.Name = "txtmaximo";
            this.txtmaximo.Size = new System.Drawing.Size(37, 20);
            this.txtmaximo.TabIndex = 10;
            this.txtmaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcosto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Porcentaje máximo =";
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(125, 15);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(58, 20);
            this.txtcosto.TabIndex = 9;
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcosto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Costo mínimo =";
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(44, 222);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(75, 23);
            this.btngrabar.TabIndex = 14;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // ParametrosAdmiGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 280);
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
            this.Name = "ParametrosAdmiGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros Administrador Gestión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaximo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngrabar;
    }
}