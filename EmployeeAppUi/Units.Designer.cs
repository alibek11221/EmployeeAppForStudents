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
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(12, 301);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(365, 34);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Обновить данные";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // UnitsList
            // 
            this.UnitsList.FormattingEnabled = true;
            this.UnitsList.ItemHeight = 19;
            this.UnitsList.Location = new System.Drawing.Point(12, 12);
            this.UnitsList.Name = "UnitsList";
            this.UnitsList.Size = new System.Drawing.Size(365, 270);
            this.UnitsList.TabIndex = 2;
            // 
            // AddUnitButton
            // 
            this.AddUnitButton.Location = new System.Drawing.Point(12, 466);
            this.AddUnitButton.Name = "AddUnitButton";
            this.AddUnitButton.Size = new System.Drawing.Size(365, 34);
            this.AddUnitButton.TabIndex = 3;
            this.AddUnitButton.Text = "Добавить отдел";
            this.AddUnitButton.UseVisualStyleBackColor = true;
            this.AddUnitButton.Click += new System.EventHandler(this.AddUnitButton_Click);
            // 
            // UnitNameTextBox
            // 
            this.UnitNameTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UnitNameTextBox.Location = new System.Drawing.Point(12, 414);
            this.UnitNameTextBox.Name = "UnitNameTextBox";
            this.UnitNameTextBox.Size = new System.Drawing.Size(365, 29);
            this.UnitNameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название отдела";
            // 
            // Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnitNameTextBox);
            this.Controls.Add(this.AddUnitButton);
            this.Controls.Add(this.UnitsList);
            this.Controls.Add(this.RefreshButton);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Units";
            this.Text = "Units";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ListBox UnitsList;
        private System.Windows.Forms.Button AddUnitButton;
        private System.Windows.Forms.TextBox UnitNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}