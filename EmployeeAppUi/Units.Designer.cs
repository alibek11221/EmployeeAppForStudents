namespace EmployeeAppUi
{
    partial class Units
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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.UnitsList = new System.Windows.Forms.ListBox();
            this.AddUnitButton = new System.Windows.Forms.Button();
            this.UnitNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPositionButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PositionSalaryBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PositionNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UnitComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(17, 177);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(299, 34);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Обновить данные";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // UnitsList
            // 
            this.UnitsList.FormattingEnabled = true;
            this.UnitsList.ItemHeight = 19;
            this.UnitsList.Location = new System.Drawing.Point(17, 35);
            this.UnitsList.Name = "UnitsList";
            this.UnitsList.Size = new System.Drawing.Size(299, 118);
            this.UnitsList.TabIndex = 2;
            // 
            // AddUnitButton
            // 
            this.AddUnitButton.Location = new System.Drawing.Point(17, 326);
            this.AddUnitButton.Name = "AddUnitButton";
            this.AddUnitButton.Size = new System.Drawing.Size(299, 34);
            this.AddUnitButton.TabIndex = 3;
            this.AddUnitButton.Text = "Добавить отдел";
            this.AddUnitButton.UseVisualStyleBackColor = true;
            this.AddUnitButton.Click += new System.EventHandler(this.AddUnitButton_Click);
            // 
            // UnitNameTextBox
            // 
            this.UnitNameTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitNameTextBox.Location = new System.Drawing.Point(17, 262);
            this.UnitNameTextBox.Name = "UnitNameTextBox";
            this.UnitNameTextBox.Size = new System.Drawing.Size(299, 29);
            this.UnitNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название отдела";
            // 
            // AddPositionButton
            // 
            this.AddPositionButton.Location = new System.Drawing.Point(10, 326);
            this.AddPositionButton.Name = "AddPositionButton";
            this.AddPositionButton.Size = new System.Drawing.Size(295, 34);
            this.AddPositionButton.TabIndex = 7;
            this.AddPositionButton.Text = "Добавить должность";
            this.AddPositionButton.UseVisualStyleBackColor = true;
            this.AddPositionButton.Click += new System.EventHandler(this.AddPositionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnitsList);
            this.groupBox1.Controls.Add(this.RefreshButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddUnitButton);
            this.groupBox1.Controls.Add(this.UnitNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 398);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отделы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PositionSalaryBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PositionNameBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.UnitComboBox);
            this.groupBox2.Controls.Add(this.AddPositionButton);
            this.groupBox2.Location = new System.Drawing.Point(376, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 398);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Должности";
            // 
            // PositionSalaryBox
            // 
            this.PositionSalaryBox.Location = new System.Drawing.Point(6, 229);
            this.PositionSalaryBox.Name = "PositionSalaryBox";
            this.PositionSalaryBox.Size = new System.Drawing.Size(299, 26);
            this.PositionSalaryBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Оплата за один рабочий день\r\n";
            // 
            // PositionNameBox
            // 
            this.PositionNameBox.Location = new System.Drawing.Point(6, 143);
            this.PositionNameBox.Name = "PositionNameBox";
            this.PositionNameBox.Size = new System.Drawing.Size(299, 26);
            this.PositionNameBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Название должности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отдел";
            // 
            // UnitComboBox
            // 
            this.UnitComboBox.FormattingEnabled = true;
            this.UnitComboBox.Location = new System.Drawing.Point(6, 59);
            this.UnitComboBox.Name = "UnitComboBox";
            this.UnitComboBox.Size = new System.Drawing.Size(299, 27);
            this.UnitComboBox.TabIndex = 4;
            this.UnitComboBox.Text = "Выберите отдел";
            this.UnitComboBox.DropDown += new System.EventHandler(this.UnitComboBox_DropDown);
            this.UnitComboBox.Enter += new System.EventHandler(this.UnitComboBox_Enter);
            // 
            // Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Units";
            this.Text = "Units";
            this.Load += new System.EventHandler(this.Units_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ListBox UnitsList;
        private System.Windows.Forms.Button AddUnitButton;
        private System.Windows.Forms.TextBox UnitNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPositionButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PositionSalaryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PositionNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UnitComboBox;
    }
}