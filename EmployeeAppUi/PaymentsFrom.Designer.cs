namespace EmployeeAppUi
{
    partial class PaymentsFrom
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
            this.UnitBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeesBox = new System.Windows.Forms.ListBox();
            this.BeginnigDate = new System.Windows.Forms.DateTimePicker();
            this.EndingDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.MakePaymentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnitBox
            // 
            this.UnitBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitBox.FormattingEnabled = true;
            this.UnitBox.Location = new System.Drawing.Point(28, 36);
            this.UnitBox.Name = "UnitBox";
            this.UnitBox.Size = new System.Drawing.Size(290, 27);
            this.UnitBox.TabIndex = 0;
            this.UnitBox.SelectedIndexChanged += new System.EventHandler(this.UnitBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отдел";
            // 
            // EmployeesBox
            // 
            this.EmployeesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeesBox.FormattingEnabled = true;
            this.EmployeesBox.ItemHeight = 19;
            this.EmployeesBox.Location = new System.Drawing.Point(28, 86);
            this.EmployeesBox.Name = "EmployeesBox";
            this.EmployeesBox.Size = new System.Drawing.Size(290, 175);
            this.EmployeesBox.TabIndex = 2;
            // 
            // BeginnigDate
            // 
            this.BeginnigDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BeginnigDate.Location = new System.Drawing.Point(28, 306);
            this.BeginnigDate.Name = "BeginnigDate";
            this.BeginnigDate.Size = new System.Drawing.Size(290, 26);
            this.BeginnigDate.TabIndex = 3;
            // 
            // EndingDate
            // 
            this.EndingDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndingDate.Location = new System.Drawing.Point(28, 373);
            this.EndingDate.Name = "EndingDate";
            this.EndingDate.Size = new System.Drawing.Size(290, 26);
            this.EndingDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Начало оплачиваемого периода";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Конец оплачиваемого периода";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(28, 432);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(290, 46);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MakePaymentButton
            // 
            this.MakePaymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MakePaymentButton.Location = new System.Drawing.Point(28, 521);
            this.MakePaymentButton.Name = "MakePaymentButton";
            this.MakePaymentButton.Size = new System.Drawing.Size(290, 46);
            this.MakePaymentButton.TabIndex = 8;
            this.MakePaymentButton.Text = "Расчитать и провести оплату";
            this.MakePaymentButton.UseVisualStyleBackColor = true;
            this.MakePaymentButton.Click += new System.EventHandler(this.MakePaymentButton_Click);
            // 
            // PaymentsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 614);
            this.Controls.Add(this.MakePaymentButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndingDate);
            this.Controls.Add(this.BeginnigDate);
            this.Controls.Add(this.EmployeesBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnitBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentsFrom";
            this.ShowIcon = false;
            this.Text = "Выплаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UnitBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EmployeesBox;
        private System.Windows.Forms.DateTimePicker BeginnigDate;
        private System.Windows.Forms.DateTimePicker EndingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button MakePaymentButton;
    }
}