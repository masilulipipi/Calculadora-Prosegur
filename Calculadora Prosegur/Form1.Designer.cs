namespace Calculadora_Prosegur
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUNCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobranzasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraBásicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaExternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugerenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Descuentos";
            this.toolTip1.SetToolTip(this.button1, "Calcula todos los descuentos con porcentajes con y sin IVA  en un solo clic...");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "U.B.O";
            this.toolTip1.SetToolTip(this.button2, "Calcula todos los descuentos con porcentajes con y sin IVA  en un solo clic...");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(933, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sugerencias";
            this.toolTip1.SetToolTip(this.button3, "Envíeme un Email con sugerencias para mejorar este programa ...");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(747, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Calculadora";
            this.toolTip1.SetToolTip(this.button4, "Calculadora simple ");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(828, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Calculadora WIN";
            this.toolTip1.SetToolTip(this.button5, "Calculadora original de windows");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "Cobranzas";
            this.toolTip1.SetToolTip(this.button6, "Calcula todos los descuentos con porcentajes con y sin IVA  en un solo clic...");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(897, 525);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.fUNCIONESToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // fUNCIONESToolStripMenuItem
            // 
            this.fUNCIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descuentosToolStripMenuItem,
            this.otrosToolStripMenuItem,
            this.cobranzasToolStripMenuItem,
            this.calculadoraBásicaToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.programaExternoToolStripMenuItem});
            this.fUNCIONESToolStripMenuItem.Name = "fUNCIONESToolStripMenuItem";
            this.fUNCIONESToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.fUNCIONESToolStripMenuItem.Text = "FUNCIONES";
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.descuentosToolStripMenuItem.Text = "Descuentos";
            this.descuentosToolStripMenuItem.Click += new System.EventHandler(this.descuentosToolStripMenuItem_Click);
            // 
            // otrosToolStripMenuItem
            // 
            this.otrosToolStripMenuItem.Name = "otrosToolStripMenuItem";
            this.otrosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.otrosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.otrosToolStripMenuItem.Text = "U.B.O";
            this.otrosToolStripMenuItem.Click += new System.EventHandler(this.otrosToolStripMenuItem_Click);
            // 
            // cobranzasToolStripMenuItem
            // 
            this.cobranzasToolStripMenuItem.Name = "cobranzasToolStripMenuItem";
            this.cobranzasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.cobranzasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.cobranzasToolStripMenuItem.Text = "Cobranzas";
            this.cobranzasToolStripMenuItem.Click += new System.EventHandler(this.cobranzasToolStripMenuItem_Click);
            // 
            // calculadoraBásicaToolStripMenuItem
            // 
            this.calculadoraBásicaToolStripMenuItem.Name = "calculadoraBásicaToolStripMenuItem";
            this.calculadoraBásicaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.calculadoraBásicaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.calculadoraBásicaToolStripMenuItem.Text = "Calculadora Básica";
            this.calculadoraBásicaToolStripMenuItem.Click += new System.EventHandler(this.calculadoraBásicaToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora WIN";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // programaExternoToolStripMenuItem
            // 
            this.programaExternoToolStripMenuItem.Name = "programaExternoToolStripMenuItem";
            this.programaExternoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.programaExternoToolStripMenuItem.Text = "Programa externo";
            this.programaExternoToolStripMenuItem.Click += new System.EventHandler(this.programaExternoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.sugerenciasToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De....";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // sugerenciasToolStripMenuItem
            // 
            this.sugerenciasToolStripMenuItem.Name = "sugerenciasToolStripMenuItem";
            this.sugerenciasToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sugerenciasToolStripMenuItem.Text = "Sugerencias...";
            this.sugerenciasToolStripMenuItem.Click += new System.EventHandler(this.sugerenciasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(972, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hora";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1107, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Prosegur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fUNCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programaExternoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugerenciasToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem cobranzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraBásicaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

