namespace EmployeeAppUi
{
    partial class EmployeesForm
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
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MiddlenameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BornYearDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.FemaleRadio = new System.Windows.Forms.RadioButton();
            this.HasKidsCheckBox = new System.Windows.Forms.CheckBox();
            this.KidsAmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.UnitComboBox = new System.Windows.Forms.ComboBox();
            this.PositionListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IsMarried = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.KidsAmountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(16, 399);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(565, 43);
            this.AddEmployeeButton.TabIndex = 0;
            this.AddEmployeeButton.Text = "Добавить сотрудника";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(16, 31);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(257, 26);
            this.SurnameBox.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(16, 86);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(257, 26);
            this.NameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // MiddlenameBox
            // 
            this.MiddlenameBox.Location = new System.Drawing.Point(16, 139);
            this.MiddlenameBox.Name = "MiddlenameBox";
            this.MiddlenameBox.Size = new System.Drawing.Size(257, 26);
            this.MiddlenameBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // BornYearDate
            // 
            this.BornYearDate.Location = new System.Drawing.Point(16, 197);
            this.BornYearDate.Name = "BornYearDate";
            this.BornYearDate.Size = new System.Drawing.Size(257, 26);
            this.BornYearDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата рождения";
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Location = new System.Drawing.Point(16, 270);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(41, 23);
            this.MaleRadio.TabIndex = 9;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "М";
            this.MaleRadio.UseVisualStyleBackColor = true;
            // 
            // FemaleRadio
            // 
            this.FemaleRadio.AutoSize = true;
            this.FemaleRadio.Location = new System.Drawing.Point(84, 270);
            this.FemaleRadio.Name = "FemaleRadio";
            this.FemaleRadio.Size = new System.Drawing.Size(41, 23);
            this.FemaleRadio.TabIndex = 10;
            this.FemaleRadio.TabStop = true;
            this.FemaleRadio.Text = "Ж";
            this.FemaleRadio.UseVisualStyleBackColor = true;
            // 
            // HasKidsCheckBox
            // 
            this.HasKidsCheckBox.AutoSize = true;
            this.HasKidsCheckBox.Location = new System.Drawing.Point(178, 330);
            this.HasKidsCheckBox.Name = "HasKidsCheckBox";
            this.HasKidsCheckBox.Size = new System.Drawing.Size(93, 23);
            this.HasKidsCheckBox.TabIndex = 11;
            this.HasKidsCheckBox.Text = "Есть дети";
            this.HasKidsCheckBox.UseVisualStyleBackColor = true;
            this.HasKidsCheckBox.CheckedChanged += new System.EventHandler(this.HasKidsCheckBox_CheckedChanged);
            // 
            // KidsAmountNumeric
            // 
            this.KidsAmountNumeric.Enabled = false;
            this.KidsAmountNumeric.Location = new System.Drawing.Point(178, 270);
            this.KidsAmountNumeric.Name = "KidsAmountNumeric";
            this.KidsAmountNumeric.Size = new System.Drawing.Size(45, 26);
            this.KidsAmountNumeric.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Кол-во детей";
            // 
            // UnitComboBox
            // 
            this.UnitComboBox.FormattingEnabled = true;
            this.UnitComboBox.Location = new System.Drawing.Point(324, 31);
            this.UnitComboBox.Name = "UnitComboBox";
            this.UnitComboBox.Size = new System.Drawing.Size(257, 27);
            this.UnitComboBox.TabIndex = 15;
            this.UnitComboBox.Text = "Отдел";
            this.UnitComboBox.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectedIndexChanged);
            // 
            // PositionListBox
            // 
            this.PositionListBox.FormattingEnabled = true;
            this.PositionListBox.ItemHeight = 19;
            this.PositionListBox.Location = new System.Drawing.Point(324, 64);
            this.PositionListBox.Name = "PositionListBox";
            this.PositionListBox.Size = new System.Drawing.Size(257, 289);
            this.PositionListBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Пол";
            // 
            // IsMarried
            // 
            this.IsMarried.AutoSize = true;
            this.IsMarried.Location = new System.Drawing.Point(16, 330);
            this.IsMarried.Name = "IsMarried";
            this.IsMarried.Size = new System.Drawing.Size(133, 23);
            this.IsMarried.TabIndex = 18;
            this.IsMarried.Text = "Женат/замужем";
            this.IsMarried.UseVisualStyleBackColor = true;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 474);
            this.Controls.Add(this.IsMarried);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PositionListBox);
            this.Controls.Add(this.UnitComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KidsAmountNumeric);
            this.Controls.Add(this.HasKidsCheckBox);
            this.Controls.Add(this.FemaleRadio);
            this.Controls.Add(this.MaleRadio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BornYearDate);
            this.Controls.Add(this.MiddlenameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddEmployeeButton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeesForm";
            this.ShowIcon = false;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KidsAmountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MiddlenameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker BornYearDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton MaleRadio;
        private System.Windows.Forms.RadioButton FemaleRadio;
        private System.Windows.Forms.CheckBox HasKidsCheckBox;
        private System.Windows.Forms.NumericUpDown KidsAmountNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox UnitComboBox;
        private System.Windows.Forms.ListBox PositionListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox IsMarried;
    }
}