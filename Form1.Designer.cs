namespace Temperature_Conversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.CelsiusTextBox = new System.Windows.Forms.TextBox();
            this.FahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KelvinTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // CelsiusTextBox
            // 
            this.CelsiusTextBox.Location = new System.Drawing.Point(236, 48);
            this.CelsiusTextBox.Name = "CelsiusTextBox";
            this.CelsiusTextBox.Size = new System.Drawing.Size(100, 22);
            this.CelsiusTextBox.TabIndex = 1;
            // 
            // FahrenheitTextBox
            // 
            this.FahrenheitTextBox.Location = new System.Drawing.Point(236, 109);
            this.FahrenheitTextBox.Name = "FahrenheitTextBox";
            this.FahrenheitTextBox.Size = new System.Drawing.Size(100, 22);
            this.FahrenheitTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fahrenheit";
            // 
            // KelvinTextBox
            // 
            this.KelvinTextBox.Location = new System.Drawing.Point(236, 166);
            this.KelvinTextBox.Name = "KelvinTextBox";
            this.KelvinTextBox.Size = new System.Drawing.Size(100, 22);
            this.KelvinTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 251);
            this.Controls.Add(this.KelvinTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FahrenheitTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CelsiusTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CelsiusTextBox;
        private System.Windows.Forms.TextBox FahrenheitTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KelvinTextBox;
        private System.Windows.Forms.Label label3;
    }
}

