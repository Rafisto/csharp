namespace Joystick_Connection_Agent
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.south = new System.Windows.Forms.Panel();
            this.east = new System.Windows.Forms.Panel();
            this.west = new System.Windows.Forms.Panel();
            this.north = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.joy_switch = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Space Shooter - Joystick agent";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 115);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Połącz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 6);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 30);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz port COM:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.joy_switch);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.south);
            this.panel3.Controls.Add(this.east);
            this.panel3.Controls.Add(this.west);
            this.panel3.Controls.Add(this.north);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(318, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 171);
            this.panel3.TabIndex = 3;
            // 
            // south
            // 
            this.south.BackColor = System.Drawing.Color.Red;
            this.south.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.south.Cursor = System.Windows.Forms.Cursors.Default;
            this.south.Location = new System.Drawing.Point(105, 106);
            this.south.Name = "south";
            this.south.Size = new System.Drawing.Size(30, 27);
            this.south.TabIndex = 4;
            // 
            // east
            // 
            this.east.BackColor = System.Drawing.Color.Red;
            this.east.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.east.Cursor = System.Windows.Forms.Cursors.Default;
            this.east.Location = new System.Drawing.Point(215, 71);
            this.east.Name = "east";
            this.east.Size = new System.Drawing.Size(30, 27);
            this.east.TabIndex = 3;
            // 
            // west
            // 
            this.west.BackColor = System.Drawing.Color.Red;
            this.west.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.west.Cursor = System.Windows.Forms.Cursors.Default;
            this.west.Location = new System.Drawing.Point(8, 71);
            this.west.Name = "west";
            this.west.Size = new System.Drawing.Size(30, 27);
            this.west.TabIndex = 2;
            // 
            // north
            // 
            this.north.BackColor = System.Drawing.Color.Red;
            this.north.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.north.Location = new System.Drawing.Point(105, 38);
            this.north.Name = "north";
            this.north.Size = new System.Drawing.Size(30, 27);
            this.north.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ustaw joystick poprawnie...";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(556, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "5 Zielonych uruchamia gre";
            // 
            // joy_switch
            // 
            this.joy_switch.BackColor = System.Drawing.Color.Red;
            this.joy_switch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.joy_switch.Location = new System.Drawing.Point(105, 73);
            this.joy_switch.Name = "joy_switch";
            this.joy_switch.Size = new System.Drawing.Size(30, 27);
            this.joy_switch.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 226);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Space Shooter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel north;
        private System.Windows.Forms.Panel west;
        private System.Windows.Forms.Panel south;
        private System.Windows.Forms.Panel east;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel joy_switch;
    }
}

