namespace SimpleATMSoftware
{
    partial class BalanceForm
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
            panel1 = new Panel();
            label3 = new Label();
            btnX = new Button();
            label1 = new Label();
            btnClose1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(btnClose1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnX);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 218);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18.2686558F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 23);
            label3.Name = "label3";
            label3.Size = new Size(128, 41);
            label3.TabIndex = 3;
            label3.Text = "Balance";
            // 
            // btnX
            // 
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Segoe UI", 13.970149F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnX.Location = new Point(901, 3);
            btnX.Name = "btnX";
            btnX.Size = new Size(68, 50);
            btnX.TabIndex = 7;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 84);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 8;
            label1.Text = "Your balance is";
            // 
            // btnClose1
            // 
            btnClose1.BackColor = SystemColors.GradientActiveCaption;
            btnClose1.FlatStyle = FlatStyle.Flat;
            btnClose1.Font = new Font("Microsoft Sans Serif", 10.2089548F, FontStyle.Bold);
            btnClose1.Location = new Point(819, 143);
            btnClose1.Name = "btnClose1";
            btnClose1.Size = new Size(132, 50);
            btnClose1.TabIndex = 9;
            btnClose1.Text = "Close";
            btnClose1.UseVisualStyleBackColor = false;
            // 
            // BalanceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(993, 219);
            Controls.Add(panel1);
            Name = "BalanceForm";
            Text = "BalanceForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Button btnX;
        private Label label1;
        private Button btnClose1;
    }
}