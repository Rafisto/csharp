namespace pcc_lang_recognizer
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
            this.text_reference = new System.Windows.Forms.RichTextBox();
            this.text_main = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.coefficient_answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_reference
            // 
            this.text_reference.Location = new System.Drawing.Point(12, 12);
            this.text_reference.Name = "text_reference";
            this.text_reference.Size = new System.Drawing.Size(356, 270);
            this.text_reference.TabIndex = 0;
            this.text_reference.Text = "";
            // 
            // text_main
            // 
            this.text_main.Location = new System.Drawing.Point(386, 12);
            this.text_main.Name = "text_main";
            this.text_main.Size = new System.Drawing.Size(386, 270);
            this.text_main.TabIndex = 1;
            this.text_main.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Main";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(760, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate Coefficient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coefficient_answer
            // 
            this.coefficient_answer.AutoSize = true;
            this.coefficient_answer.Location = new System.Drawing.Point(12, 327);
            this.coefficient_answer.Name = "coefficient_answer";
            this.coefficient_answer.Size = new System.Drawing.Size(57, 13);
            this.coefficient_answer.TabIndex = 5;
            this.coefficient_answer.Text = "Reference";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.coefficient_answer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_main);
            this.Controls.Add(this.text_reference);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text_reference;
        private System.Windows.Forms.RichTextBox text_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label coefficient_answer;
    }
}

