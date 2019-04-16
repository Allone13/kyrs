namespace VladCourseWork.Forms
{
    partial class CheckCreateForm
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
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.Employeer = new System.Windows.Forms.ComboBox();
            this.EmployeerLabel = new System.Windows.Forms.Label();
            this.TimeOrder = new System.Windows.Forms.DateTimePicker();
            this.TimeOrderLabel = new System.Windows.Forms.Label();
            this.DateGive = new System.Windows.Forms.DateTimePicker();
            this.DateGiveLabel = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Statys = new System.Windows.Forms.ComboBox();
            this.StatysLabel = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.AllMoney = new System.Windows.Forms.TextBox();
            this.AllLabel = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.ComboBox();
            this.ShablonText = new System.Windows.Forms.ComboBox();
            this.ShablonLabel = new System.Windows.Forms.Label();
            this.MainObjects = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalObjects = new System.Windows.Forms.DataGridView();
            this.d1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddObjects = new System.Windows.Forms.ComboBox();
            this.AdditionalLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionalObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(12, 28);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(59, 13);
            this.CustomerLabel.TabIndex = 0;
            this.CustomerLabel.Text = "Закащик: ";
            // 
            // Employeer
            // 
            this.Employeer.FormattingEnabled = true;
            this.Employeer.Location = new System.Drawing.Point(77, 63);
            this.Employeer.Name = "Employeer";
            this.Employeer.Size = new System.Drawing.Size(126, 21);
            this.Employeer.TabIndex = 5;
            // 
            // EmployeerLabel
            // 
            this.EmployeerLabel.AutoSize = true;
            this.EmployeerLabel.Location = new System.Drawing.Point(12, 66);
            this.EmployeerLabel.Name = "EmployeerLabel";
            this.EmployeerLabel.Size = new System.Drawing.Size(60, 13);
            this.EmployeerLabel.TabIndex = 4;
            this.EmployeerLabel.Text = "Сотрудник";
            // 
            // TimeOrder
            // 
            this.TimeOrder.CustomFormat = "yyyy-MM-dd";
            this.TimeOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeOrder.Location = new System.Drawing.Point(470, 35);
            this.TimeOrder.Name = "TimeOrder";
            this.TimeOrder.Size = new System.Drawing.Size(200, 20);
            this.TimeOrder.TabIndex = 27;
            // 
            // TimeOrderLabel
            // 
            this.TimeOrderLabel.AutoSize = true;
            this.TimeOrderLabel.Location = new System.Drawing.Point(372, 35);
            this.TimeOrderLabel.Name = "TimeOrderLabel";
            this.TimeOrderLabel.Size = new System.Drawing.Size(82, 13);
            this.TimeOrderLabel.TabIndex = 26;
            this.TimeOrderLabel.Text = "Время заказа:";
            // 
            // DateGive
            // 
            this.DateGive.CustomFormat = "yyyy-MM-dd";
            this.DateGive.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateGive.Location = new System.Drawing.Point(470, 71);
            this.DateGive.Name = "DateGive";
            this.DateGive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateGive.Size = new System.Drawing.Size(200, 20);
            this.DateGive.TabIndex = 29;
            // 
            // DateGiveLabel
            // 
            this.DateGiveLabel.AutoSize = true;
            this.DateGiveLabel.Location = new System.Drawing.Point(372, 71);
            this.DateGiveLabel.Name = "DateGiveLabel";
            this.DateGiveLabel.Size = new System.Drawing.Size(83, 13);
            this.DateGiveLabel.TabIndex = 28;
            this.DateGiveLabel.Text = "Время выдачи:";
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(27, 522);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(121, 27);
            this.Back.TabIndex = 31;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Statys
            // 
            this.Statys.FormattingEnabled = true;
            this.Statys.Items.AddRange(new object[] {
            "Принят",
            "Готовится",
            "Доставляется",
            "Выдан"});
            this.Statys.Location = new System.Drawing.Point(77, 109);
            this.Statys.Name = "Statys";
            this.Statys.Size = new System.Drawing.Size(126, 21);
            this.Statys.TabIndex = 34;
            this.Statys.SelectedIndexChanged += new System.EventHandler(this.Statys_SelectedIndexChanged);
            // 
            // StatysLabel
            // 
            this.StatysLabel.AutoSize = true;
            this.StatysLabel.Location = new System.Drawing.Point(12, 112);
            this.StatysLabel.Name = "StatysLabel";
            this.StatysLabel.Size = new System.Drawing.Size(41, 13);
            this.StatysLabel.TabIndex = 33;
            this.StatysLabel.Text = "Статус";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(652, 522);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(121, 27);
            this.Create.TabIndex = 42;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // AllMoney
            // 
            this.AllMoney.Location = new System.Drawing.Point(533, 522);
            this.AllMoney.Name = "AllMoney";
            this.AllMoney.ReadOnly = true;
            this.AllMoney.Size = new System.Drawing.Size(97, 20);
            this.AllMoney.TabIndex = 44;
            this.AllMoney.Text = "0";
            // 
            // AllLabel
            // 
            this.AllLabel.AutoSize = true;
            this.AllLabel.Location = new System.Drawing.Point(478, 529);
            this.AllLabel.Name = "AllLabel";
            this.AllLabel.Size = new System.Drawing.Size(37, 13);
            this.AllLabel.TabIndex = 43;
            this.AllLabel.Text = "Всего";
            // 
            // Customer
            // 
            this.Customer.FormattingEnabled = true;
            this.Customer.Location = new System.Drawing.Point(77, 25);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(126, 21);
            this.Customer.TabIndex = 46;
            // 
            // ShablonText
            // 
            this.ShablonText.FormattingEnabled = true;
            this.ShablonText.Items.AddRange(new object[] {
            "Принят",
            "Готовится",
            "Доставляется",
            "Выдан"});
            this.ShablonText.Location = new System.Drawing.Point(117, 155);
            this.ShablonText.Name = "ShablonText";
            this.ShablonText.Size = new System.Drawing.Size(656, 21);
            this.ShablonText.TabIndex = 48;
            this.ShablonText.SelectedIndexChanged += new System.EventHandler(this.ShablonText_SelectedIndexChanged);
            // 
            // ShablonLabel
            // 
            this.ShablonLabel.AutoSize = true;
            this.ShablonLabel.Location = new System.Drawing.Point(12, 158);
            this.ShablonLabel.Name = "ShablonLabel";
            this.ShablonLabel.Size = new System.Drawing.Size(99, 13);
            this.ShablonLabel.TabIndex = 47;
            this.ShablonLabel.Text = "Готовые шаблоны";
            // 
            // MainObjects
            // 
            this.MainObjects.AllowUserToAddRows = false;
            this.MainObjects.AllowUserToDeleteRows = false;
            this.MainObjects.AllowUserToResizeColumns = false;
            this.MainObjects.AllowUserToResizeRows = false;
            this.MainObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names,
            this.Count,
            this.Cost,
            this.Description});
            this.MainObjects.Enabled = false;
            this.MainObjects.Location = new System.Drawing.Point(27, 199);
            this.MainObjects.Name = "MainObjects";
            this.MainObjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.MainObjects.ShowCellErrors = false;
            this.MainObjects.ShowCellToolTips = false;
            this.MainObjects.ShowEditingIcon = false;
            this.MainObjects.ShowRowErrors = false;
            this.MainObjects.Size = new System.Drawing.Size(746, 151);
            this.MainObjects.TabIndex = 49;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Names.HeaderText = "Название";
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Width = 82;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 91;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cost.HeaderText = "Стоимость";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 87;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 82;
            // 
            // AdditionalObjects
            // 
            this.AdditionalObjects.AllowUserToAddRows = false;
            this.AdditionalObjects.AllowUserToDeleteRows = false;
            this.AdditionalObjects.AllowUserToResizeColumns = false;
            this.AdditionalObjects.AllowUserToResizeRows = false;
            this.AdditionalObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdditionalObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d1,
            this.d2,
            this.d3,
            this.d4,
            this.d5});
            this.AdditionalObjects.Location = new System.Drawing.Point(15, 409);
            this.AdditionalObjects.Name = "AdditionalObjects";
            this.AdditionalObjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.AdditionalObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdditionalObjects.ShowCellErrors = false;
            this.AdditionalObjects.ShowCellToolTips = false;
            this.AdditionalObjects.ShowEditingIcon = false;
            this.AdditionalObjects.ShowRowErrors = false;
            this.AdditionalObjects.Size = new System.Drawing.Size(603, 89);
            this.AdditionalObjects.TabIndex = 50;
            // 
            // d1
            // 
            this.d1.HeaderText = "Id";
            this.d1.Name = "d1";
            this.d1.ReadOnly = true;
            this.d1.Visible = false;
            // 
            // d2
            // 
            this.d2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.d2.HeaderText = "Название";
            this.d2.Name = "d2";
            this.d2.ReadOnly = true;
            this.d2.Width = 82;
            // 
            // d3
            // 
            this.d3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.d3.HeaderText = "Количество";
            this.d3.Name = "d3";
            this.d3.ReadOnly = true;
            this.d3.Width = 91;
            // 
            // d4
            // 
            this.d4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.d4.HeaderText = "Стоимость";
            this.d4.Name = "d4";
            this.d4.ReadOnly = true;
            this.d4.Width = 87;
            // 
            // d5
            // 
            this.d5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.d5.HeaderText = "Описание";
            this.d5.Name = "d5";
            this.d5.ReadOnly = true;
            this.d5.Width = 82;
            // 
            // AddObjects
            // 
            this.AddObjects.FormattingEnabled = true;
            this.AddObjects.Items.AddRange(new object[] {
            "Принят",
            "Готовится",
            "Доставляется",
            "Выдан"});
            this.AddObjects.Location = new System.Drawing.Point(117, 382);
            this.AddObjects.Name = "AddObjects";
            this.AddObjects.Size = new System.Drawing.Size(192, 21);
            this.AddObjects.TabIndex = 52;
            this.AddObjects.SelectedIndexChanged += new System.EventHandler(this.AddObjects_SelectedIndexChanged);
            // 
            // AdditionalLabel
            // 
            this.AdditionalLabel.AutoSize = true;
            this.AdditionalLabel.Location = new System.Drawing.Point(12, 385);
            this.AdditionalLabel.Name = "AdditionalLabel";
            this.AdditionalLabel.Size = new System.Drawing.Size(87, 13);
            this.AdditionalLabel.TabIndex = 51;
            this.AdditionalLabel.Text = "Дополнительно";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(325, 382);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1.TabIndex = 53;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(423, 378);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(121, 27);
            this.Add.TabIndex = 54;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(624, 409);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 27);
            this.delete.TabIndex = 55;
            this.delete.Text = "Убрать";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 27);
            this.button1.TabIndex = 56;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckCreateForm
            // 
            this.AcceptButton = this.Create;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.AddObjects);
            this.Controls.Add(this.AdditionalLabel);
            this.Controls.Add(this.AdditionalObjects);
            this.Controls.Add(this.MainObjects);
            this.Controls.Add(this.ShablonText);
            this.Controls.Add(this.ShablonLabel);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.AllMoney);
            this.Controls.Add(this.AllLabel);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Statys);
            this.Controls.Add(this.StatysLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DateGive);
            this.Controls.Add(this.DateGiveLabel);
            this.Controls.Add(this.TimeOrder);
            this.Controls.Add(this.TimeOrderLabel);
            this.Controls.Add(this.Employeer);
            this.Controls.Add(this.EmployeerLabel);
            this.Controls.Add(this.CustomerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckCreateForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать чек";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckCreateForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MainObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionalObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.ComboBox Employeer;
        private System.Windows.Forms.Label EmployeerLabel;
        private System.Windows.Forms.DateTimePicker TimeOrder;
        private System.Windows.Forms.Label TimeOrderLabel;
        private System.Windows.Forms.DateTimePicker DateGive;
        private System.Windows.Forms.Label DateGiveLabel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox Statys;
        private System.Windows.Forms.Label StatysLabel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox AllMoney;
        private System.Windows.Forms.Label AllLabel;
        private System.Windows.Forms.ComboBox Customer;
        private System.Windows.Forms.ComboBox ShablonText;
        private System.Windows.Forms.Label ShablonLabel;
        private System.Windows.Forms.DataGridView MainObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridView AdditionalObjects;
        private System.Windows.Forms.ComboBox AddObjects;
        private System.Windows.Forms.Label AdditionalLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1;
        private System.Windows.Forms.DataGridViewTextBoxColumn d2;
        private System.Windows.Forms.DataGridViewTextBoxColumn d3;
        private System.Windows.Forms.DataGridViewTextBoxColumn d4;
        private System.Windows.Forms.DataGridViewTextBoxColumn d5;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
    }
}