namespace SimpleATMSoftware
{
    partial class TransactionsForm
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
            label1 = new Label();
            lvTransaction = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel1 = new Panel();
            btnX = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.1194019F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(284, 36);
            label1.TabIndex = 0;
            label1.Text = "Last 5 transactions";
            label1.UseWaitCursor = true;
            // 
            // lvTransaction
            // 
            lvTransaction.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvTransaction.GridLines = true;
            lvTransaction.Location = new Point(-1, 129);
            lvTransaction.Name = "lvTransaction";
            lvTransaction.Size = new Size(805, 510);
            lvTransaction.TabIndex = 1;
            lvTransaction.UseCompatibleStateImageBehavior = false;
            lvTransaction.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Transaction date";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Amount";
            columnHeader2.Width = 600;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnX);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 129);
            panel1.TabIndex = 2;
            panel1.UseWaitCursor = true;
            // 
            // btnX
            // 
            btnX.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnX.FlatAppearance.BorderSize = 0;
            btnX.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnX.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            btnX.FlatStyle = FlatStyle.Flat;
            btnX.Font = new Font("Calibri", 13.970149F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnX.Location = new Point(748, 3);
            btnX.Name = "btnX";
            btnX.Size = new Size(45, 42);
            btnX.TabIndex = 3;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.UseWaitCursor = true;
            btnX.Click += btnX_Click;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 638);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(lvTransaction);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TransactionsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListView lvTransaction;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel1;
        private Button btnX;

    }
}