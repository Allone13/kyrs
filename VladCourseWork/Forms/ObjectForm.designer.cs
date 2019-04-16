namespace VladCourseWork.Forms
{
    partial class ObjectForm
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
            this.Objects = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostTo = new System.Windows.Forms.NumericUpDown();
            this.CostFrom = new System.Windows.Forms.NumericUpDown();
            this.OnlyCan = new System.Windows.Forms.CheckBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.TypeList = new System.Windows.Forms.CheckedListBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.FiltrLabel = new System.Windows.Forms.Label();
            this.Sort_label = new System.Windows.Forms.Label();
            this.SortPanel = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.Filtr = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Categoryes = new System.Windows.Forms.Button();
            this.CostText = new System.Windows.Forms.NumericUpDown();
            this.TypeText = new System.Windows.Forms.ComboBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.CountText = new System.Windows.Forms.NumericUpDown();
            this.CountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Objects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).BeginInit();
            this.SuspendLayout();
            // 
            // Objects
            // 
            this.Objects.AllowUserToAddRows = false;
            this.Objects.AllowUserToDeleteRows = false;
            this.Objects.AllowUserToResizeRows = false;
            this.Objects.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Objects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Objects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Names,
            this.Type,
            this.Cost,
            this.Count,
            this.Description});
            this.Objects.Location = new System.Drawing.Point(12, 126);
            this.Objects.MultiSelect = false;
            this.Objects.Name = "Objects";
            this.Objects.RowHeadersVisible = false;
            this.Objects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Objects.Size = new System.Drawing.Size(589, 243);
            this.Objects.TabIndex = 1;
            this.Objects.Click += new System.EventHandler(this.Objects_Click);
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
            this.Names.HeaderText = "Название";
            this.Names.Name = "Names";
            this.Names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Names.Width = 63;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Type.Width = 32;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cost.HeaderText = "Стоимость";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cost.Width = 68;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Count.Width = 72;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Description.Width = 63;
            // 
            // CostTo
            // 
            this.CostTo.Location = new System.Drawing.Point(625, 292);
            this.CostTo.Name = "CostTo";
            this.CostTo.Size = new System.Drawing.Size(71, 22);
            this.CostTo.TabIndex = 33;
            this.CostTo.ValueChanged += new System.EventHandler(this.CostFrom_ValueChanged);
            // 
            // CostFrom
            // 
            this.CostFrom.Location = new System.Drawing.Point(625, 260);
            this.CostFrom.Name = "CostFrom";
            this.CostFrom.Size = new System.Drawing.Size(71, 22);
            this.CostFrom.TabIndex = 32;
            this.CostFrom.ValueChanged += new System.EventHandler(this.CostFrom_ValueChanged);
            // 
            // OnlyCan
            // 
            this.OnlyCan.AutoSize = true;
            this.OnlyCan.Location = new System.Drawing.Point(609, 333);
            this.OnlyCan.Name = "OnlyCan";
            this.OnlyCan.Size = new System.Drawing.Size(119, 20);
            this.OnlyCan.TabIndex = 31;
            this.OnlyCan.Text = "Только в наличии";
            this.OnlyCan.UseVisualStyleBackColor = true;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(621, 239);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(63, 16);
            this.CostLabel.TabIndex = 30;
            this.CostLabel.Text = "Стоимость";
            // 
            // TypeList
            // 
            this.TypeList.BackColor = System.Drawing.Color.Linen;
            this.TypeList.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeList.FormattingEnabled = true;
            this.TypeList.Location = new System.Drawing.Point(609, 147);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(133, 64);
            this.TypeList.TabIndex = 28;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(605, 126);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(28, 16);
            this.TypeLabel.TabIndex = 27;
            this.TypeLabel.Text = "Тип";
            // 
            // FiltrLabel
            // 
            this.FiltrLabel.AutoSize = true;
            this.FiltrLabel.Location = new System.Drawing.Point(604, 110);
            this.FiltrLabel.Name = "FiltrLabel";
            this.FiltrLabel.Size = new System.Drawing.Size(50, 16);
            this.FiltrLabel.TabIndex = 24;
            this.FiltrLabel.Text = "Фильтр:";
            // 
            // Sort_label
            // 
            this.Sort_label.AutoSize = true;
            this.Sort_label.Location = new System.Drawing.Point(149, 88);
            this.Sort_label.Name = "Sort_label";
            this.Sort_label.Size = new System.Drawing.Size(90, 16);
            this.Sort_label.TabIndex = 37;
            this.Sort_label.Text = "Сортировать по";
            // 
            // SortPanel
            // 
            this.SortPanel.DisplayMember = "0";
            this.SortPanel.FormattingEnabled = true;
            this.SortPanel.Items.AddRange(new object[] {
            "количеству от большего",
            "количеству от меньшего",
            "названию от большего",
            "названию от меньшего",
            "стоимости от большего",
            "стоимость от меньшего"});
            this.SortPanel.Location = new System.Drawing.Point(257, 85);
            this.SortPanel.Name = "SortPanel";
            this.SortPanel.Size = new System.Drawing.Size(221, 24);
            this.SortPanel.Sorted = true;
            this.SortPanel.TabIndex = 36;
            this.SortPanel.ValueMember = "0";
            this.SortPanel.SelectedIndexChanged += new System.EventHandler(this.SortPanel_SelectedIndexChanged);
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(12, 13);
            this.Back.Name = "Back";
            this.Back.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Back.Size = new System.Drawing.Size(87, 27);
            this.Back.TabIndex = 38;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // Filtr
            // 
            this.Filtr.BackColor = System.Drawing.Color.Beige;
            this.Filtr.Location = new System.Drawing.Point(786, 147);
            this.Filtr.Name = "Filtr";
            this.Filtr.Size = new System.Drawing.Size(115, 57);
            this.Filtr.TabIndex = 40;
            this.Filtr.Text = "Отфильтровать";
            this.Filtr.UseVisualStyleBackColor = false;
            this.Filtr.Click += new System.EventHandler(this.Filtr_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(799, 260);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 27);
            this.Cancel.TabIndex = 39;
            this.Cancel.Text = "Сбросить";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Categoryes
            // 
            this.Categoryes.Location = new System.Drawing.Point(267, 531);
            this.Categoryes.Name = "Categoryes";
            this.Categoryes.Size = new System.Drawing.Size(87, 27);
            this.Categoryes.TabIndex = 52;
            this.Categoryes.Text = "Категории";
            this.Categoryes.UseVisualStyleBackColor = true;
            this.Categoryes.Click += new System.EventHandler(this.Categoryes_Click);
            // 
            // CostText
            // 
            this.CostText.Location = new System.Drawing.Point(119, 472);
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
            this.CostText.Size = new System.Drawing.Size(140, 22);
            this.CostText.TabIndex = 50;
            this.CostText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TypeText
            // 
            this.TypeText.FormattingEnabled = true;
            this.TypeText.Location = new System.Drawing.Point(108, 526);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(140, 24);
            this.TypeText.TabIndex = 49;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(119, 404);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(116, 22);
            this.NameText.TabIndex = 48;
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(39, 531);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(31, 16);
            this.LabelType.TabIndex = 47;
            this.LabelType.Text = "Тип ";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(33, 476);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(69, 16);
            this.LabelCost.TabIndex = 45;
            this.LabelCost.Text = "Стоимость: ";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(39, 406);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(64, 16);
            this.LabelName.TabIndex = 44;
            this.LabelName.Text = "Название: ";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(421, 412);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(374, 98);
            this.DescriptionText.TabIndex = 53;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(341, 412);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(64, 16);
            this.LabelDescription.TabIndex = 54;
            this.LabelDescription.Text = "Описание:";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(36, 576);
            this.Clear.Name = "Clear";
            this.Clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Clear.Size = new System.Drawing.Size(87, 27);
            this.Clear.TabIndex = 55;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(377, 565);
            this.Update.Name = "Update";
            this.Update.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Update.Size = new System.Drawing.Size(147, 62);
            this.Update.TabIndex = 56;
            this.Update.Text = "Изменить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // CountText
            // 
            this.CountText.Enabled = false;
            this.CountText.Location = new System.Drawing.Point(120, 440);
            this.CountText.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(140, 22);
            this.CountText.TabIndex = 58;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(34, 444);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(72, 16);
            this.CountLabel.TabIndex = 57;
            this.CountLabel.Text = "Количество ";
            // 
            // ObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.Categoryes);
            this.Controls.Add(this.CostText);
            this.Controls.Add(this.TypeText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelCost);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.Filtr);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Sort_label);
            this.Controls.Add(this.SortPanel);
            this.Controls.Add(this.CostTo);
            this.Controls.Add(this.CostFrom);
            this.Controls.Add(this.OnlyCan);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.TypeList);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.FiltrLabel);
            this.Controls.Add(this.Objects);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты";
            ((System.ComponentModel.ISupportInitialize)(this.Objects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Objects;
        private System.Windows.Forms.NumericUpDown CostTo;
        private System.Windows.Forms.NumericUpDown CostFrom;
        private System.Windows.Forms.CheckBox OnlyCan;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.CheckedListBox TypeList;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label FiltrLabel;
        private System.Windows.Forms.Label Sort_label;
        private System.Windows.Forms.ComboBox SortPanel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Filtr;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button Categoryes;
        private System.Windows.Forms.NumericUpDown CostText;
        private System.Windows.Forms.ComboBox TypeText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.NumericUpDown CountText;
        private System.Windows.Forms.Label CountLabel;
    }
}