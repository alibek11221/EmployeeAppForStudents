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
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.PaymentsButton = new System.Windows.Forms.Button();
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
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(12, 123);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(328, 52);
            this.EmployeeButton.TabIndex = 1;
            this.EmployeeButton.Text = "Сотрудники";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // PaymentsButton
            // 
            this.PaymentsButton.Location = new System.Drawing.Point(12, 211);
            this.PaymentsButton.Name = "PaymentsButton";
            this.PaymentsButton.Size = new System.Drawing.Size(328, 52);
            this.PaymentsButton.TabIndex = 2;
            this.PaymentsButton.Text = "Выплаты";
            this.PaymentsButton.UseVisualStyleBackColor = true;
            this.PaymentsButton.Click += new System.EventHandler(this.PaymentsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 314);
            this.Controls.Add(this.PaymentsButton);
            this.Controls.Add(this.EmployeeButton);
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
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button PaymentsButton;
    }
}

