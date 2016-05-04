namespace TelephoneNumberConversion
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
            this.txtNumberToConvert = new System.Windows.Forms.TextBox();
            this.txtConvertedNumber = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtNumberToConvert
            // 
            this.txtNumberToConvert.Location = new System.Drawing.Point(64, 44);
            this.txtNumberToConvert.Name = "txtNumberToConvert";
            this.txtNumberToConvert.Size = new System.Drawing.Size(100, 20);
            this.txtNumberToConvert.TabIndex = 1;
            // 
            // txtConvertedNumber
            // 
            this.txtConvertedNumber.Location = new System.Drawing.Point(137, 220);
            this.txtConvertedNumber.Name = "txtConvertedNumber";
            this.txtConvertedNumber.ReadOnly = true;
            this.txtConvertedNumber.Size = new System.Drawing.Size(100, 20);
            this.txtConvertedNumber.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(64, 169);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "button1";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConvertedNumber);
            this.Controls.Add(this.txtNumberToConvert);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberToConvert;
        private System.Windows.Forms.TextBox txtConvertedNumber;
        private System.Windows.Forms.Button btnConvert;
    }
}

