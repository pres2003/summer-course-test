namespace summer_course_test
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
            this.button1 = new System.Windows.Forms.Button();
            this.raw_text = new System.Windows.Forms.TextBox();
            this.rez_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // raw_text
            // 
            this.raw_text.Location = new System.Drawing.Point(12, 12);
            this.raw_text.Multiline = true;
            this.raw_text.Name = "raw_text";
            this.raw_text.Size = new System.Drawing.Size(226, 117);
            this.raw_text.TabIndex = 1;
            // 
            // rez_text
            // 
            this.rez_text.Location = new System.Drawing.Point(358, 55);
            this.rez_text.Name = "rez_text";
            this.rez_text.ReadOnly = true;
            this.rez_text.Size = new System.Drawing.Size(100, 20);
            this.rez_text.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rez_text);
            this.Controls.Add(this.raw_text);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox raw_text;
        private System.Windows.Forms.TextBox rez_text;
    }
}

