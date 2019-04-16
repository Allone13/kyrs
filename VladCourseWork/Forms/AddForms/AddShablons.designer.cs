namespace VladCourseWork.Forms
{
    partial class AddShablons
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
            this.LabelName = new System.Windows.Forms.Label();
            this.DishName = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.AddIng = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.NumericUpDown();
            this.Product = new System.Windows.Forms.ComboBox();
            this.Ingredients = new System.Windows.Forms.ListBox();
            this.IngerientsLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(27, 38);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(63, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Название: ";
            // 
            // DishName
            // 
            this.DishName.Location = new System.Drawing.Point(96, 35);
            this.DishName.Name = "DishName";
            this.DishName.Size = new System.Drawing.Size(100, 20);
            this.DishName.TabIndex = 7;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(571, 375);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(81, 33);
            this.Add.TabIndex = 14;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(438, 385);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(34, 257);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(61, 23);
            this.Delete.TabIndex = 45;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddIng
            // 
            this.AddIng.Location = new System.Drawing.Point(288, 342);
            this.AddIng.Name = "AddIng";
            this.AddIng.Size = new System.Drawing.Size(61, 23);
            this.AddIng.TabIndex = 44;
            this.AddIng.Text = "+";
            this.AddIng.UseVisualStyleBackColor = true;
            this.AddIng.Click += new System.EventHandler(this.AddIng_Click);
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(225, 342);
            this.Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(57, 20);
            this.Count.TabIndex = 43;
            this.Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Product
            // 
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(101, 342);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(109, 21);
            this.Product.TabIndex = 42;
            this.Product.SelectedIndexChanged += new System.EventHandler(this.Product_SelectedIndexChanged);
            // 
            // Ingredients
            // 
            this.Ingredients.FormattingEnabled = true;
            this.Ingredients.Location = new System.Drawing.Point(101, 231);
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.Size = new System.Drawing.Size(257, 95);
            this.Ingredients.TabIndex = 41;
            this.Ingredients.SelectedIndexChanged += new System.EventHandler(this.Ingredients_SelectedIndexChanged);
            // 
            // IngerientsLabel
            // 
            this.IngerientsLabel.AutoSize = true;
            this.IngerientsLabel.Location = new System.Drawing.Point(20, 231);
            this.IngerientsLabel.Name = "IngerientsLabel";
            this.IngerientsLabel.Size = new System.Drawing.Size(53, 13);
            this.IngerientsLabel.TabIndex = 40;
            this.IngerientsLabel.Text = "Объекты";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(96, 110);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(379, 61);
            this.Description.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Описание: ";
            // 
            // AddShablons
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(664, 420);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AddIng);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Ingredients);
            this.Controls.Add(this.IngerientsLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DishName);
            this.Controls.Add(this.LabelName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddShablons";
            this.Text = "Добавить шаблон";
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox DishName;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button AddIng;
        private System.Windows.Forms.NumericUpDown Count;
        private System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.ListBox Ingredients;
        private System.Windows.Forms.Label IngerientsLabel;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label1;
    }
}