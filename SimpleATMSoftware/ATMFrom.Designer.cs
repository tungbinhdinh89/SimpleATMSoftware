﻿namespace SimpleATMSoftware
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
            txtCardNumber = new TextBox();
            txtPinNumber = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtCardNumber
            // 
            txtCardNumber.Font = new Font("Segoe UI", 13.970149F);
            txtCardNumber.Location = new Point(111, 194);
            txtCardNumber.Multiline = true;
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(715, 50);
            txtCardNumber.TabIndex = 0;
            txtCardNumber.Text = "Enter card number";
            // 
            // txtPinNumber
            // 
            txtPinNumber.Font = new Font("Segoe UI", 13.970149F);
            txtPinNumber.Location = new Point(111, 283);
            txtPinNumber.Multiline = true;
            txtPinNumber.Name = "txtPinNumber";
            txtPinNumber.Size = new Size(715, 50);
            txtPinNumber.TabIndex = 1;
            txtPinNumber.Text = "Enter Pin";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Calibri", 16.1194019F);
            btnLogin.Location = new Point(111, 378);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(715, 56);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(931, 802);
            Controls.Add(btnLogin);
            Controls.Add(txtPinNumber);
            Controls.Add(txtCardNumber);
            Name = "Form1";
            Text = "ATMForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCardNumber;
        private TextBox txtPinNumber;
        private Button btnLogin;
    }
}