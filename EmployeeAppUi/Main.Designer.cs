namespace EmployeeAppUi
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UnitsButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.PaymentsButton = new System.Windows.Forms.Button();
            this.ShowBaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UnitsButton
            // 
            this.UnitsButton.Location = new System.Drawing.Point(12, 42);
            this.UnitsButton.Name = "UnitsButton";
            this.UnitsButton.Size = new System.Drawing.Size(328, 52);
            this.UnitsButton.TabIndex = 0;
            this.UnitsButton.Text = "Отделы";
            this.UnitsButton.UseVisualStyleBackColor = true;
            this.UnitsButton.Click += new System.EventHandler(this.UnitsButton_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(12, 113);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(328, 52);
            this.EmployeesButton.TabIndex = 1;
            this.EmployeesButton.Text = "Сотрудники";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click);
            // 
            // PaymentsButton
            // 
            this.PaymentsButton.Location = new System.Drawing.Point(12, 187);
            this.PaymentsButton.Name = "PaymentsButton";
            this.PaymentsButton.Size = new System.Drawing.Size(328, 52);
            this.PaymentsButton.TabIndex = 2;
            this.PaymentsButton.Text = "Выплаты";
            this.PaymentsButton.UseVisualStyleBackColor = true;
            this.PaymentsButton.Click += new System.EventHandler(this.PaymentsButton_Click);
            // 
            // ShowBaseButton
            // 
            this.ShowBaseButton.Location = new System.Drawing.Point(12, 263);
            this.ShowBaseButton.Name = "ShowBaseButton";
            this.ShowBaseButton.Size = new System.Drawing.Size(328, 52);
            this.ShowBaseButton.TabIndex = 2;
            this.ShowBaseButton.Text = "База";
            this.ShowBaseButton.UseVisualStyleBackColor = true;
            this.ShowBaseButton.Click += new System.EventHandler(this.ShowBaseButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 359);
            this.Controls.Add(this.ShowBaseButton);
            this.Controls.Add(this.PaymentsButton);
            this.Controls.Add(this.EmployeesButton);
            this.Controls.Add(this.UnitsButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UnitsButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button PaymentsButton;
        private System.Windows.Forms.Button ShowBaseButton;
    }
}

