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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 16.1194019F);
            button1.Location = new Point(79, 159);
            button1.Name = "button1";
            button1.Size = new Size(813, 56);
            button1.TabIndex = 0;
            button1.Text = "View Balance";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 16.1194019F);
            button2.Location = new Point(79, 259);
            button2.Name = "button2";
            button2.Size = new Size(813, 56);
            button2.TabIndex = 1;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 16.1194019F);
            button3.Location = new Point(79, 359);
            button3.Name = "button3";
            button3.Size = new Size(813, 56);
            button3.TabIndex = 2;
            button3.Text = "Last 5 transactions";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 33);
            label1.Name = "label1";
            label1.Size = new Size(159, 30);
            label1.TabIndex = 3;
            label1.Text = "Hi! User name";
            // 
            // ViewDetailForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(973, 829);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ViewDetailForm";
            Text = "ViewDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}