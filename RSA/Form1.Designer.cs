namespace RSA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtDecyrpt = new TextBox();
            txtPrivatKey1 = new TextBox();
            txtPrivatKey2 = new TextBox();
            txtPublicKey2 = new TextBox();
            txtPublicKey1 = new TextBox();
            txtEncrypt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btn_Decrypt = new Button();
            btn_Encrypt = new Button();
            label5 = new Label();
            label6 = new Label();
            lblDecrypt = new Label();
            lblEncrypt = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Verschlüsselter Text:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 9);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 1;
            label2.Text = "Privater Schlüssel:";
            // 
            // txtDecyrpt
            // 
            txtDecyrpt.Location = new Point(12, 32);
            txtDecyrpt.Name = "txtDecyrpt";
            txtDecyrpt.Size = new Size(445, 27);
            txtDecyrpt.TabIndex = 2;
            // 
            // txtPrivatKey1
            // 
            txtPrivatKey1.Location = new Point(480, 32);
            txtPrivatKey1.Name = "txtPrivatKey1";
            txtPrivatKey1.Size = new Size(63, 27);
            txtPrivatKey1.TabIndex = 3;
            // 
            // txtPrivatKey2
            // 
            txtPrivatKey2.Location = new Point(556, 32);
            txtPrivatKey2.Name = "txtPrivatKey2";
            txtPrivatKey2.Size = new Size(63, 27);
            txtPrivatKey2.TabIndex = 4;
            // 
            // txtPublicKey2
            // 
            txtPublicKey2.Location = new Point(556, 183);
            txtPublicKey2.Name = "txtPublicKey2";
            txtPublicKey2.Size = new Size(63, 27);
            txtPublicKey2.TabIndex = 9;
            // 
            // txtPublicKey1
            // 
            txtPublicKey1.Location = new Point(480, 183);
            txtPublicKey1.Name = "txtPublicKey1";
            txtPublicKey1.Size = new Size(63, 27);
            txtPublicKey1.TabIndex = 8;
            // 
            // txtEncrypt
            // 
            txtEncrypt.Location = new Point(12, 183);
            txtEncrypt.Name = "txtEncrypt";
            txtEncrypt.Size = new Size(445, 27);
            txtEncrypt.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 160);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 6;
            label3.Text = "Öffentlicher Schlüssel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 160);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 5;
            label4.Text = "Nachricht:";
            // 
            // btn_Decrypt
            // 
            btn_Decrypt.Location = new Point(625, 30);
            btn_Decrypt.Name = "btn_Decrypt";
            btn_Decrypt.Size = new Size(113, 29);
            btn_Decrypt.TabIndex = 10;
            btn_Decrypt.Text = "Entschlüsseln";
            btn_Decrypt.UseVisualStyleBackColor = true;
            btn_Decrypt.Click += btn_Decrypt_Click;
            // 
            // btn_Encrypt
            // 
            btn_Encrypt.Location = new Point(625, 181);
            btn_Encrypt.Name = "btn_Encrypt";
            btn_Encrypt.Size = new Size(113, 29);
            btn_Encrypt.TabIndex = 11;
            btn_Encrypt.Text = "Verschlüsseln";
            btn_Encrypt.UseVisualStyleBackColor = true;
            btn_Encrypt.Click += btn_Encrypt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 83);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 12;
            label5.Text = "Ergebnis:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 240);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 13;
            label6.Text = "Ergebnis:";
            // 
            // lblDecrypt
            // 
            lblDecrypt.AutoSize = true;
            lblDecrypt.Location = new Point(12, 116);
            lblDecrypt.Name = "lblDecrypt";
            lblDecrypt.Size = new Size(65, 20);
            lblDecrypt.TabIndex = 14;
            lblDecrypt.Text = "dsafasdf";
            // 
            // lblEncrypt
            // 
            lblEncrypt.AutoSize = true;
            lblEncrypt.Location = new Point(12, 274);
            lblEncrypt.Name = "lblEncrypt";
            lblEncrypt.Size = new Size(65, 20);
            lblEncrypt.TabIndex = 15;
            lblEncrypt.Text = "dsafasdf";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 308);
            Controls.Add(lblEncrypt);
            Controls.Add(lblDecrypt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_Encrypt);
            Controls.Add(btn_Decrypt);
            Controls.Add(txtPublicKey2);
            Controls.Add(txtPublicKey1);
            Controls.Add(txtEncrypt);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtPrivatKey2);
            Controls.Add(txtPrivatKey1);
            Controls.Add(txtDecyrpt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDecyrpt;
        private TextBox txtPrivatKey1;
        private TextBox txtPrivatKey2;
        private TextBox txtPublicKey2;
        private TextBox txtPublicKey1;
        private TextBox txtEncrypt;
        private Label label3;
        private Label label4;
        private Button btn_Decrypt;
        private Button btn_Encrypt;
        private Label label5;
        private Label label6;
        private Label lblDecrypt;
        private Label lblEncrypt;
    }
}