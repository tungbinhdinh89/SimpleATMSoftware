namespace SimpleATMSoftware
{
    partial class ViewDetailForm
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
            btnViewBalance = new Button();
            btnWithdraw = new Button();
            btnLast5Transactions = new Button();
            lbGreeting = new Label();
            btnX = new Button();
            SuspendLayout();
            // 
            // btnViewBalance
            // 
            btnViewBalance.BackColor = SystemColors.ActiveCaption;
            btnViewBalance.FlatStyle = FlatStyle.Flat;
            btnViewBalance.Font = new Font("Calibri", 16.1194019F);
            btnViewBalance.Location = new Point(79, 159);
            btnViewBalance.Name = "btnViewBalance";
            btnViewBalance.Size = new Size(813, 56);
            btnViewBalance.TabIndex = 0;
            btnViewBalance.Text = "View Balance";
            btnViewBalance.UseVisualStyleBackColor = false;
            btnViewBalance.Click += btnViewBalance_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = SystemColors.ActiveCaption;
            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.Font = new Font("Calibri", 16.1194019F);
            btnWithdraw.Location = new Point(79, 259);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(813, 56);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnLast5Transactions
            // 
            btnLast5Transactions.BackColor = SystemColors.ActiveCaption;
            btnLast5Transactions.FlatStyle = FlatStyle.Flat;
            btnLast5Transactions.Font = new Font("Calibri", 16.1194019F);
            btnLast5Transactions.Location = new Point(79, 359);
            btnLast5Transactions.Name = "btnLast5Transactions";
            btnLast5Transactions.Size = new Size(813, 56);
            btnLast5Transactions.TabIndex = 2;
            btnLast5Transactions.Text = "Last 5 transactions";
            btnLast5Transactions.UseVisualStyleBackColor = false;
            btnLast5Transactions.Click += btnLast5Transactions_Click;
            // 
            // lbGreeting
            // 
            lbGreeting.AutoSize = true;
            lbGreeting.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGreeting.Location = new Point(79, 33);
            lbGreeting.Name = "lbGreeting";
            lbGreeting.Size = new Size(0, 30);
            lbGreeting.TabIndex = 3;
            // 
            // btnX
            // 
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Segoe UI", 13.970149F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnX.Location = new Point(903, 0);
            btnX.Name = "btnX";
            btnX.Size = new Size(68, 50);
            btnX.TabIndex = 8;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // ViewDetailForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(973, 829);
            ControlBox = false;
            Controls.Add(btnX);
            Controls.Add(lbGreeting);
            Controls.Add(btnLast5Transactions);
            Controls.Add(btnWithdraw);
            Controls.Add(btnViewBalance);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewDetailForm";
            Text = "ViewDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewBalance;
        private Button btnWithdraw;
        private Button btnLast5Transactions;
        private Label lbGreeting;
        private Button btnX;
    }
}