namespace SimpleATMSoftware
{
    partial class WithdrawForm
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
            txtAmount = new TextBox();
            label1 = new Label();
            lbBalance = new Label();
            btnClose1 = new Button();
            btnAccept = new Button();
            panel1 = new Panel();
            btnX = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Microsoft Sans Serif", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(46, 85);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(925, 50);
            txtAmount.TabIndex = 0;
            txtAmount.Text = "Enter your amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18.2686558F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 12);
            label1.Name = "label1";
            label1.Size = new Size(158, 41);
            label1.TabIndex = 1;
            label1.Text = "Withdraw";
            // 
            // lbBalance
            // 
            lbBalance.AutoSize = true;
            lbBalance.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBalance.Location = new Point(46, 162);
            lbBalance.Name = "lbBalance";
            lbBalance.Size = new Size(0, 30);
            lbBalance.TabIndex = 2;
            // 
            // btnClose1
            // 
            btnClose1.BackColor = SystemColors.GradientActiveCaption;
            btnClose1.FlatStyle = FlatStyle.Flat;
            btnClose1.Font = new Font("Microsoft Sans Serif", 10.2089548F, FontStyle.Bold);
            btnClose1.Location = new Point(684, 187);
            btnClose1.Name = "btnClose1";
            btnClose1.Size = new Size(132, 50);
            btnClose1.TabIndex = 3;
            btnClose1.Text = "Close";
            btnClose1.UseVisualStyleBackColor = false;
            btnClose1.Click += btnClose1_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = SystemColors.GradientActiveCaption;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Font = new Font("Microsoft Sans Serif", 10.2089548F, FontStyle.Bold);
            btnAccept.Location = new Point(839, 187);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(132, 50);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(btnX);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(btnAccept);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClose1);
            panel1.Controls.Add(lbBalance);
            panel1.Location = new Point(12, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 271);
            panel1.TabIndex = 5;
            // 
            // btnX
            // 
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Segoe UI", 13.970149F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnX.Location = new Point(931, 3);
            btnX.Name = "btnX";
            btnX.Size = new Size(68, 50);
            btnX.TabIndex = 6;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1023, 268);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WithdrawForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "WithdrawForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtAmount;
        private Label label1;
        private Label lbBalance;
        private Button btnClose1;
        private Button btnAccept;
        private Panel panel1;
        private Button btnX;
    }
}