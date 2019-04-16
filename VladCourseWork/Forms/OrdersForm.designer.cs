namespace VladCourseWork.Forms
{
    partial class OrdersForm
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
            this.Delete = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employeer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.All = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            this.Filtr = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OnlyCan = new System.Windows.Forms.CheckBox();
            this.StatysList = new System.Windows.Forms.CheckedListBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.FiltrLabel = new System.Windows.Forms.Label();
            this.EmployeerList = new System.Windows.Forms.CheckedListBox();
            this.day = new System.Windows.Forms.DateTimePicker();
            this.CreateCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 107);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(81, 31);
            this.Delete.TabIndex = 31;
            this.Delete.Text = "Отменить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(422, 107);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(81, 31);
            this.Change.TabIndex = 30;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Orders
            // 
            this.Orders.AllowUserToAddRows = false;
            this.Orders.AllowUserToDeleteRows = false;
            this.Orders.AllowUserToResizeRows = false;
            this.Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names,
            this.DateGive,
            this.Employeer,
            this.Status,
            this.All});
            this.Orders.Location = new System.Drawing.Point(12, 148);
            this.Orders.Name = "Orders";
            this.Orders.RowHeadersVisible = false;
            this.Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Orders.Size = new System.Drawing.Size(502, 198);
            this.Orders.TabIndex = 26;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // Names
            // 
            this.Names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Names.HeaderText = "Заказчик";
            this.Names.Name = "Names";
            this.Names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Names.Width = 61;
            // 
            // DateGive
            // 
            this.DateGive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DateGive.HeaderText = "Дата сдачи";
            this.DateGive.Name = "DateGive";
            this.DateGive.ReadOnly = true;
            this.DateGive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateGive.Width = 71;
            // 
            // Employeer
            // 
            this.Employeer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Employeer.HeaderText = "Сотрудник";
            this.Employeer.Name = "Employeer";
            this.Employeer.ReadOnly = true;
            this.Employeer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Employeer.Width = 66;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Status.Width = 47;
            // 
            // All
            // 
            this.All.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.All.HeaderText = "Сумма";
            this.All.Name = "All";
            this.All.ReadOnly = true;
            this.All.Width = 66;
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 39;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Filtr
            // 
            this.Filtr.Location = new System.Drawing.Point(672, 148);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(99, 47);
            this.Filtr.TabIndex = 49;
            this.Filtr.Text = "Отфильтровать";
            this.Filtr.UseVisualStyleBackColor = true;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(683, 240);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 48;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OnlyCan
            // 
            this.OnlyCan.AutoSize = true;
            this.OnlyCan.Location = new System.Drawing.Point(641, 303);
            this.OnlyCan.Name = "OnlyCan";
            this.OnlyCan.Size = new System.Drawing.Size(15, 14);
            this.OnlyCan.TabIndex = 45;
            this.OnlyCan.UseVisualStyleBackColor = true;
            // 
            // StatysList
            // 
            this.StatysList.FormattingEnabled = true;
            this.StatysList.Location = new System.Drawing.Point(520, 148);
            this.StatysList.Name = "StatysList";
            this.StatysList.Size = new System.Drawing.Size(115, 64);
            this.StatysList.TabIndex = 43;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(517, 132);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(26, 13);
            this.TypeLabel.TabIndex = 42;
            this.TypeLabel.Text = "Тип";
            // 
            // FiltrLabel
            // 
            this.FiltrLabel.AutoSize = true;
            this.FiltrLabel.Location = new System.Drawing.Point(516, 119);
            this.FiltrLabel.Name = "FiltrLabel";
            this.FiltrLabel.Size = new System.Drawing.Size(50, 13);
            this.FiltrLabel.TabIndex = 41;
            this.FiltrLabel.Text = "Фильтр:";
            // 
            // EmployeerList
            // 
            this.EmployeerList.FormattingEnabled = true;
            this.EmployeerList.Location = new System.Drawing.Point(520, 218);
            this.EmployeerList.Name = "EmployeerList";
            this.EmployeerList.Size = new System.Drawing.Size(115, 64);
            this.EmployeerList.TabIndex = 50;
            // 
            // day
            // 
            this.day.CustomFormat = "yyyy-MM-dd";
            this.day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.day.Location = new System.Drawing.Point(519, 297);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(116, 20);
            this.day.TabIndex = 51;
            // 
            // CreateCheck
            // 
            this.CreateCheck.Location = new System.Drawing.Point(414, 12);
            this.CreateCheck.Name = "CreateCheck";
            this.CreateCheck.Size = new System.Drawing.Size(100, 44);
            this.CreateCheck.TabIndex = 52;
            this.CreateCheck.Text = "Создать чек";
            this.CreateCheck.UseVisualStyleBackColor = true;
            this.CreateCheck.Click += new System.EventHandler(this.CreateCheck_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(882, 363);
            this.Controls.Add(this.CreateCheck);
            this.Controls.Add(this.day);
            this.Controls.Add(this.EmployeerList);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OnlyCan);
            this.Controls.Add(this.StatysList);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.FiltrLabel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Orders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.DataGridView Orders;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateGive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employeer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn All;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox OnlyCan;
        private System.Windows.Forms.CheckedListBox StatysList;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label FiltrLabel;
        private System.Windows.Forms.CheckedListBox EmployeerList;
        private System.Windows.Forms.DateTimePicker day;
        private System.Windows.Forms.Button CreateCheck;
    }
}