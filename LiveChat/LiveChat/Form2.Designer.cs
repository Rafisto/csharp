namespace LiveChat
{
    partial class Form2
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szyfrowanieWiadomościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.brakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encode2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encode3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szyfrowaniePojedyńczeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trybPrywatnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.włączToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyłączToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powrótToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Location = new System.Drawing.Point(12, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(576, 356);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(12, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(576, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(308, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Channel Number:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szyfrowanieWiadomościToolStripMenuItem,
            this.trybPrywatnyToolStripMenuItem,
            this.powrótToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(42, 23);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // szyfrowanieWiadomościToolStripMenuItem
            // 
            this.szyfrowanieWiadomościToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.brakToolStripMenuItem,
            this.encode2ToolStripMenuItem,
            this.encode3ToolStripMenuItem,
            this.aBToolStripMenuItem,
            this.szyfrowaniePojedyńczeToolStripMenuItem});
            this.szyfrowanieWiadomościToolStripMenuItem.Name = "szyfrowanieWiadomościToolStripMenuItem";
            this.szyfrowanieWiadomościToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.szyfrowanieWiadomościToolStripMenuItem.Text = "Szyfrowanie Wiadomości";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(217, 24);
            this.toolStripMenuItem3.Text = "Yjpxy (-5)";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // brakToolStripMenuItem
            // 
            this.brakToolStripMenuItem.Name = "brakToolStripMenuItem";
            this.brakToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.brakToolStripMenuItem.Text = "Tekst (0)";
            this.brakToolStripMenuItem.Click += new System.EventHandler(this.brakToolStripMenuItem_Click);
            // 
            // encode2ToolStripMenuItem
            // 
            this.encode2ToolStripMenuItem.Name = "encode2ToolStripMenuItem";
            this.encode2ToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.encode2ToolStripMenuItem.Text = "EV\\de (15)";
            this.encode2ToolStripMenuItem.Click += new System.EventHandler(this.encode2ToolStripMenuItem_Click);
            // 
            // encode3ToolStripMenuItem
            // 
            this.encode3ToolStripMenuItem.Name = "encode3ToolStripMenuItem";
            this.encode3ToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.encode3ToolStripMenuItem.Text = "@QW_` (20)";
            this.encode3ToolStripMenuItem.Click += new System.EventHandler(this.encode3ToolStripMenuItem_Click);
            // 
            // aBToolStripMenuItem
            // 
            this.aBToolStripMenuItem.Name = "aBToolStripMenuItem";
            this.aBToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.aBToolStripMenuItem.Text = "\"39AB (30)";
            this.aBToolStripMenuItem.Click += new System.EventHandler(this.aBToolStripMenuItem_Click);
            // 
            // szyfrowaniePojedyńczeToolStripMenuItem
            // 
            this.szyfrowaniePojedyńczeToolStripMenuItem.Name = "szyfrowaniePojedyńczeToolStripMenuItem";
            this.szyfrowaniePojedyńczeToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.szyfrowaniePojedyńczeToolStripMenuItem.Text = "Szyfrowanie Podwójne";
            // 
            // trybPrywatnyToolStripMenuItem
            // 
            this.trybPrywatnyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.włączToolStripMenuItem,
            this.wyłączToolStripMenuItem});
            this.trybPrywatnyToolStripMenuItem.Name = "trybPrywatnyToolStripMenuItem";
            this.trybPrywatnyToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.trybPrywatnyToolStripMenuItem.Text = "Ikonka na pasku zadań";
            // 
            // włączToolStripMenuItem
            // 
            this.włączToolStripMenuItem.Name = "włączToolStripMenuItem";
            this.włączToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.włączToolStripMenuItem.Text = "Włącz";
            this.włączToolStripMenuItem.Click += new System.EventHandler(this.włączToolStripMenuItem_Click);
            // 
            // wyłączToolStripMenuItem
            // 
            this.wyłączToolStripMenuItem.Name = "wyłączToolStripMenuItem";
            this.wyłączToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.wyłączToolStripMenuItem.Text = "Wyłącz";
            this.wyłączToolStripMenuItem.Click += new System.EventHandler(this.wyłączToolStripMenuItem_Click);
            // 
            // powrótToolStripMenuItem
            // 
            this.powrótToolStripMenuItem.Name = "powrótToolStripMenuItem";
            this.powrótToolStripMenuItem.Size = new System.Drawing.Size(231, 24);
            this.powrótToolStripMenuItem.Text = "Powrót";
            this.powrótToolStripMenuItem.Click += new System.EventHandler(this.powrótToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(600, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trybPrywatnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem włączToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyłączToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szyfrowanieWiadomościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encode2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encode3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szyfrowaniePojedyńczeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem powrótToolStripMenuItem;
    }
}