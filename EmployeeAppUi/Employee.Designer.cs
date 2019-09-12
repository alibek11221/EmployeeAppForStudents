namespace EmployeeAppUi
{
    partial class Employee
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.PositionsComboBox = new System.Windows.Forms.ComboBox();
            this.UnitComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.KidsAmountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.BornYearDate.Location = new System.Drawing.Point(16, 203);
            this.BornYearDate.Name = "BornYearDate";
            this.BornYearDate.Size = new System.Drawing.Size(257, 26);
            this.BornYearDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата рождения";
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Location = new System.Drawing.Point(16, 254);
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
            this.FemaleRadio.Location = new System.Drawing.Point(84, 254);
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
            this.HasKidsCheckBox.Location = new System.Drawing.Point(16, 293);
            this.HasKidsCheckBox.Name = "HasKidsCheckBox";
            this.HasKidsCheckBox.Size = new System.Drawing.Size(93, 23);
            this.HasKidsCheckBox.TabIndex = 11;
            this.HasKidsCheckBox.Text = "Есть дети";
            this.HasKidsCheckBox.UseVisualStyleBackColor = true;
            // 
            // KidsAmountNumeric
            // 
            this.KidsAmountNumeric.Location = new System.Drawing.Point(16, 346);
            this.KidsAmountNumeric.Name = "KidsAmountNumeric";
            this.KidsAmountNumeric.Size = new System.Drawing.Size(45, 26);
            this.KidsAmountNumeric.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Кол-во детей";
            // 
            // PositionsComboBox
            // 
            this.PositionsComboBox.FormattingEnabled = true;
            this.PositionsComboBox.Location = new System.Drawing.Point(12, 447);
            this.PositionsComboBox.Name = "PositionsComboBox";
            this.PositionsComboBox.Size = new System.Drawing.Size(257, 27);
            this.PositionsComboBox.TabIndex = 14;
            this.PositionsComboBox.Text = "Должность";
            // 
            // UnitComboBox
            // 
            this.UnitComboBox.FormattingEnabled = true;
            this.UnitComboBox.Location = new System.Drawing.Point(12, 394);
            this.UnitComboBox.Name = "UnitComboBox";
            this.UnitComboBox.Size = new System.Drawing.Size(257, 27);
            this.UnitComboBox.TabIndex = 15;
            this.UnitComboBox.Text = "Отдел";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 608);
            this.Controls.Add(this.UnitComboBox);
            this.Controls.Add(this.PositionsComboBox);
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
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee";
            this.ShowIcon = false;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KidsAmountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.ComboBox PositionsComboBox;
        private System.Windows.Forms.ComboBox UnitComboBox;
    }
}