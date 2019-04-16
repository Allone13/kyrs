namespace VladCourseWork.Forms
{
    partial class AddObject
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
            this.CountText = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.Categoryes = new System.Windows.Forms.Button();
            this.CostText = new System.Windows.Forms.NumericUpDown();
            this.TypeText = new System.Windows.Forms.ComboBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.NameText = new System.Windows.Forms.ComboBox();
            this.EmployeerText = new System.Windows.Forms.ComboBox();
            this.EmployeerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateShop = new System.Windows.Forms.DateTimePicker();
            this.StartShop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostText)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountText
            // 
            this.CountText.Location = new System.Drawing.Point(99, 47);
            this.CountText.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CountText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(120, 20);
            this.CountText.TabIndex = 71;
            this.CountText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(25, 49);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(69, 13);
            this.CountLabel.TabIndex = 70;
            this.CountLabel.Text = "Количество ";
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(12, 300);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(97, 23);
            this.Back.TabIndex = 69;
            this.Back.Text = "Выйти";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(19, 161);
            this.Clear.Name = "Clear";
            this.Clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 68;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(288, 23);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(57, 13);
            this.LabelDescription.TabIndex = 67;
            this.LabelDescription.Text = "Описание";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(346, 23);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(274, 77);
            this.DescriptionText.TabIndex = 66;
            // 
            // Categoryes
            // 
            this.Categoryes.Location = new System.Drawing.Point(224, 109);
            this.Categoryes.Name = "Categoryes";
            this.Categoryes.Size = new System.Drawing.Size(75, 23);
            this.Categoryes.TabIndex = 65;
            this.Categoryes.Text = "Категории";
            this.Categoryes.UseVisualStyleBackColor = true;
            this.Categoryes.Click += new System.EventHandler(this.Categoryes_Click);
            // 
            // CostText
            // 
            this.CostText.Location = new System.Drawing.Point(98, 73);
            this.CostText.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CostText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CostText.Name = "CostText";
            this.CostText.Size = new System.Drawing.Size(120, 20);
            this.CostText.TabIndex = 64;
            this.CostText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TypeText
            // 
            this.TypeText.FormattingEnabled = true;
            this.TypeText.Location = new System.Drawing.Point(97, 106);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(121, 21);
            this.TypeText.TabIndex = 63;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(29, 109);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(29, 13);
            this.LabelType.TabIndex = 61;
            this.LabelType.Text = "Тип ";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(24, 75);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(68, 13);
            this.LabelCost.TabIndex = 60;
            this.LabelCost.Text = "Стоимость: ";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(29, 19);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(63, 13);
            this.LabelName.TabIndex = 59;
            this.LabelName.Text = "Название: ";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(357, 154);
            this.Add.Name = "Add";
            this.Add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Add.Size = new System.Drawing.Size(95, 36);
            this.Add.TabIndex = 72;
            this.Add.Text = "Купить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // NameText
            // 
            this.NameText.FormattingEnabled = true;
            this.NameText.Location = new System.Drawing.Point(99, 15);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(121, 21);
            this.NameText.TabIndex = 75;
            this.NameText.SelectedIndexChanged += new System.EventHandler(this.NameText_SelectedIndexChanged);
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // EmployeerText
            // 
            this.EmployeerText.FormattingEnabled = true;
            this.EmployeerText.Location = new System.Drawing.Point(243, 128);
            this.EmployeerText.Name = "EmployeerText";
            this.EmployeerText.Size = new System.Drawing.Size(175, 21);
            this.EmployeerText.TabIndex = 77;
            // 
            // EmployeerLabel
            // 
            this.EmployeerLabel.AutoSize = true;
            this.EmployeerLabel.Location = new System.Drawing.Point(170, 131);
            this.EmployeerLabel.Name = "EmployeerLabel";
            this.EmployeerLabel.Size = new System.Drawing.Size(58, 13);
            this.EmployeerLabel.TabIndex = 76;
            this.EmployeerLabel.Text = "Дизайнер";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DateShop);
            this.panel1.Controls.Add(this.StartShop);
            this.panel1.Controls.Add(this.EmployeerText);
            this.panel1.Controls.Add(this.EmployeerLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 257);
            this.panel1.TabIndex = 78;
            // 
            // DateShop
            // 
            this.DateShop.CustomFormat = "yyyy-MM-dd-HH-mm";
            this.DateShop.Enabled = false;
            this.DateShop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateShop.Location = new System.Drawing.Point(166, 87);
            this.DateShop.Name = "DateShop";
            this.DateShop.Size = new System.Drawing.Size(200, 20);
            this.DateShop.TabIndex = 79;
            // 
            // StartShop
            // 
            this.StartShop.Location = new System.Drawing.Point(173, 171);
            this.StartShop.Name = "StartShop";
            this.StartShop.Size = new System.Drawing.Size(191, 23);
            this.StartShop.TabIndex = 78;
            this.StartShop.Text = "Начать закупку";
            this.StartShop.UseVisualStyleBackColor = true;
            this.StartShop.Click += new System.EventHandler(this.StartShop_Click);
            // 
            // AddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(632, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.Categoryes);
            this.Controls.Add(this.CostText);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelCost);
            this.Controls.Add(this.LabelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Закупка";
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostText)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CountText;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Button Categoryes;
        private System.Windows.Forms.NumericUpDown CostText;
        private System.Windows.Forms.ComboBox TypeText;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox NameText;
        private System.Windows.Forms.ComboBox EmployeerText;
        private System.Windows.Forms.Label EmployeerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartShop;
        private System.Windows.Forms.DateTimePicker DateShop;
    }
}