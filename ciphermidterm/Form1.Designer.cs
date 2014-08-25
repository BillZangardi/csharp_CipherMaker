namespace CipherMidterm
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblResultHeader = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtLetterShift = new System.Windows.Forms.TextBox();
            this.lblLetterShift = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(54, 26);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(176, 13);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Enter a word to Encryhpt or Decrypt";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(12, 52);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(240, 20);
            this.txtWord.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(57, 88);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(117, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(180, 88);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(117, 23);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblResultHeader
            // 
            this.lblResultHeader.AutoSize = true;
            this.lblResultHeader.Location = new System.Drawing.Point(155, 114);
            this.lblResultHeader.Name = "lblResultHeader";
            this.lblResultHeader.Size = new System.Drawing.Size(35, 13);
            this.lblResultHeader.TabIndex = 4;
            this.lblResultHeader.Text = "label1";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(155, 136);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label1";
            // 
            // txtLetterShift
            // 
            this.txtLetterShift.Location = new System.Drawing.Point(275, 52);
            this.txtLetterShift.Name = "txtLetterShift";
            this.txtLetterShift.Size = new System.Drawing.Size(55, 20);
            this.txtLetterShift.TabIndex = 6;
            // 
            // lblLetterShift
            // 
            this.lblLetterShift.AutoSize = true;
            this.lblLetterShift.Location = new System.Drawing.Point(272, 26);
            this.lblLetterShift.Name = "lblLetterShift";
            this.lblLetterShift.Size = new System.Drawing.Size(58, 13);
            this.lblLetterShift.TabIndex = 7;
            this.lblLetterShift.Text = "Letter Shift";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 174);
            this.Controls.Add(this.lblLetterShift);
            this.Controls.Add(this.txtLetterShift);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultHeader);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblGreeting);
            this.Name = "Form1";
            this.Text = "Cipher Midterm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblResultHeader;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtLetterShift;
        private System.Windows.Forms.Label lblLetterShift;
    }
}

