namespace VladCourseWork.Forms
{
    partial class StatisticForm
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
            this.Statist = new System.Windows.Forms.DataGridView();
            this.Filtr = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.DateWith = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AllCount = new System.Windows.Forms.TextBox();
            this.AllMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employeer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dategive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Statist)).BeginInit();
            this.SuspendLayout();
            // 
            // Statist
            // 
            this.Statist.AllowUserToAddRows = false;
            this.Statist.AllowUserToDeleteRows = false;
            this.Statist.AllowUserToResizeRows = false;
            this.Statist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Statist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Employeer,
            this.DateOrder,
            this.Dategive,
            this.Cost});
            this.Statist.Location = new System.Drawing.Point(12, 12);
            this.Statist.Name = "Statist";
            this.Statist.RowHeadersVisible = false;
            this.Statist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Statist.Size = new System.Drawing.Size(559, 258);
            this.Statist.TabIndex = 2;
            // 
            // Filtr
            // 
            this.Filtr.Location = new System.Drawing.Point(691, 218);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(99, 47);
            this.Filtr.TabIndex = 42;
            this.Filtr.Text = "Отфильтровать";
            this.Filtr.UseVisualStyleBackColor = true;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(589, 230);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 41;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(12, 315);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 45;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // DateTo
            // 
            this.DateTo.CustomFormat = "yyyy-MM-dd";
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTo.Location = new System.Drawing.Point(622, 121);
            this.DateTo.Name = "DateTo";
            this.DateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateTo.Size = new System.Drawing.Size(139, 20);
            this.DateTo.TabIndex = 47;
            this.DateTo.ValueChanged += new System.EventHandler(this.DateWith_ValueChanged);
            // 
            // DateWith
            // 
            this.DateWith.CustomFormat = "yyyy-MM-dd";
            this.DateWith.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateWith.Location = new System.Drawing.Point(622, 85);
            this.DateWith.Name = "DateWith";
            this.DateWith.Size = new System.Drawing.Size(139, 20);
            this.DateWith.TabIndex = 46;
            this.DateWith.ValueChanged += new System.EventHandler(this.DateWith_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "по";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Период";
            // 
            // AllCount
            // 
            this.AllCount.Location = new System.Drawing.Point(333, 276);
            this.AllCount.Name = "AllCount";
            this.AllCount.Size = new System.Drawing.Size(55, 20);
            this.AllCount.TabIndex = 51;
            // 
            // AllMoney
            // 
            this.AllMoney.Location = new System.Drawing.Point(516, 276);
            this.AllMoney.Name = "AllMoney";
            this.AllMoney.Size = new System.Drawing.Size(55, 20);
            this.AllMoney.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Всего выполненых контрактов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Всего заработано";
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            // DateOrder
            // 
            this.DateOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DateOrder.HeaderText = "Дата принятия";
            this.DateOrder.Name = "DateOrder";
            this.DateOrder.ReadOnly = true;
            this.DateOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateOrder.Width = 80;
            // 
            // Dategive
            // 
            this.Dategive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Dategive.HeaderText = "Дата сдачи";
            this.Dategive.Name = "Dategive";
            this.Dategive.ReadOnly = true;
            this.Dategive.Width = 83;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cost.HeaderText = "Сумма";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 66;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AllMoney);
            this.Controls.Add(this.AllCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateWith);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Statist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.Statist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Statist;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.DateTimePicker DateWith;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AllCount;
        private System.Windows.Forms.TextBox AllMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employeer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dategive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}