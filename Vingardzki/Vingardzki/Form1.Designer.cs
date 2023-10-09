namespace Vingardzki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.polskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czasownikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rzeczownkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przymiotnikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liczebnikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaimkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.słowoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxvinlmn = new System.Windows.Forms.TextBox();
            this.txtboxvinlpoj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxvinprzysz = new System.Windows.Forms.TextBox();
            this.txtboxvintraz = new System.Windows.Forms.TextBox();
            this.txtboxvinprzesz = new System.Windows.Forms.TextBox();
            this.txtboxpl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polskiToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1003, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // polskiToolStripMenuItem
            // 
            this.polskiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czasownikiToolStripMenuItem,
            this.rzeczownkiToolStripMenuItem,
            this.przymiotnikiToolStripMenuItem,
            this.liczebnikiToolStripMenuItem,
            this.zaimkiToolStripMenuItem});
            this.polskiToolStripMenuItem.Name = "polskiToolStripMenuItem";
            this.polskiToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.polskiToolStripMenuItem.Text = "Polski";
            // 
            // czasownikiToolStripMenuItem
            // 
            this.czasownikiToolStripMenuItem.Name = "czasownikiToolStripMenuItem";
            this.czasownikiToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.czasownikiToolStripMenuItem.Text = "Czasowniki";
            this.czasownikiToolStripMenuItem.Click += new System.EventHandler(this.czasownikiToolStripMenuItem_Click);
            // 
            // rzeczownkiToolStripMenuItem
            // 
            this.rzeczownkiToolStripMenuItem.Name = "rzeczownkiToolStripMenuItem";
            this.rzeczownkiToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.rzeczownkiToolStripMenuItem.Text = "Rzeczownki";
            this.rzeczownkiToolStripMenuItem.Click += new System.EventHandler(this.rzeczownkiToolStripMenuItem_Click);
            // 
            // przymiotnikiToolStripMenuItem
            // 
            this.przymiotnikiToolStripMenuItem.Name = "przymiotnikiToolStripMenuItem";
            this.przymiotnikiToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.przymiotnikiToolStripMenuItem.Text = "Przymiotniki";
            // 
            // liczebnikiToolStripMenuItem
            // 
            this.liczebnikiToolStripMenuItem.Name = "liczebnikiToolStripMenuItem";
            this.liczebnikiToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.liczebnikiToolStripMenuItem.Text = "Liczebniki";
            // 
            // zaimkiToolStripMenuItem
            // 
            this.zaimkiToolStripMenuItem.Name = "zaimkiToolStripMenuItem";
            this.zaimkiToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.zaimkiToolStripMenuItem.Text = "Zaimki";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.słowoToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // słowoToolStripMenuItem
            // 
            this.słowoToolStripMenuItem.Name = "słowoToolStripMenuItem";
            this.słowoToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.słowoToolStripMenuItem.Text = "Słowo";
            this.słowoToolStripMenuItem.Click += new System.EventHandler(this.słowoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtboxvinlmn);
            this.panel1.Controls.Add(this.txtboxvinlpoj);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtboxvinprzysz);
            this.panel1.Controls.Add(this.txtboxvintraz);
            this.panel1.Controls.Add(this.txtboxvinprzesz);
            this.panel1.Controls.Add(this.txtboxpl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(233, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 444);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "- Liczba Mnoga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "- Liczba Pojedyńcza";
            // 
            // txtboxvinlmn
            // 
            this.txtboxvinlmn.Location = new System.Drawing.Point(306, 230);
            this.txtboxvinlmn.Name = "txtboxvinlmn";
            this.txtboxvinlmn.ReadOnly = true;
            this.txtboxvinlmn.Size = new System.Drawing.Size(200, 26);
            this.txtboxvinlmn.TabIndex = 10;
            // 
            // txtboxvinlpoj
            // 
            this.txtboxvinlpoj.Location = new System.Drawing.Point(306, 198);
            this.txtboxvinlpoj.Name = "txtboxvinlpoj";
            this.txtboxvinlpoj.ReadOnly = true;
            this.txtboxvinlpoj.Size = new System.Drawing.Size(200, 26);
            this.txtboxvinlpoj.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "- Czas Przyszły";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "- Czas Traźniejszy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "- Czas Przeszły";
            // 
            // txtboxvinprzysz
            // 
            this.txtboxvinprzysz.Location = new System.Drawing.Point(306, 166);
            this.txtboxvinprzysz.Name = "txtboxvinprzysz";
            this.txtboxvinprzysz.ReadOnly = true;
            this.txtboxvinprzysz.Size = new System.Drawing.Size(200, 26);
            this.txtboxvinprzysz.TabIndex = 5;
            // 
            // txtboxvintraz
            // 
            this.txtboxvintraz.Location = new System.Drawing.Point(306, 134);
            this.txtboxvintraz.Name = "txtboxvintraz";
            this.txtboxvintraz.ReadOnly = true;
            this.txtboxvintraz.Size = new System.Drawing.Size(200, 26);
            this.txtboxvintraz.TabIndex = 4;
            // 
            // txtboxvinprzesz
            // 
            this.txtboxvinprzesz.Location = new System.Drawing.Point(306, 102);
            this.txtboxvinprzesz.Name = "txtboxvinprzesz";
            this.txtboxvinprzesz.ReadOnly = true;
            this.txtboxvinprzesz.Size = new System.Drawing.Size(200, 26);
            this.txtboxvinprzesz.TabIndex = 3;
            // 
            // txtboxpl
            // 
            this.txtboxpl.Location = new System.Drawing.Point(17, 102);
            this.txtboxpl.Name = "txtboxpl";
            this.txtboxpl.Size = new System.Drawing.Size(200, 26);
            this.txtboxpl.TabIndex = 2;
            this.txtboxpl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxpl_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(810, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tłumaczenie\r\n____________________________________________________________________" +
    "_____________________\r\nPOLSKI                                                   " +
    "       VINGARD";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 444);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 487);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Vingardzki";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem polskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czasownikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rzeczownkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przymiotnikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liczebnikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaimkiToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtboxvinprzesz;
        private System.Windows.Forms.TextBox txtboxpl;
        private System.Windows.Forms.TextBox txtboxvinprzysz;
        private System.Windows.Forms.TextBox txtboxvintraz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxvinlmn;
        private System.Windows.Forms.TextBox txtboxvinlpoj;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem słowoToolStripMenuItem;
    }
}

