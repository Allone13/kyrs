namespace VladCourseWork.Forms
{
    partial class AddEmployerForm
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
            this.Back = new System.Windows.Forms.Button();
            this.Adres = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.Born = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.FnameText = new System.Windows.Forms.TextBox();
            this.LnameText = new System.Windows.Forms.TextBox();
            this.SnameText = new System.Windows.Forms.TextBox();
            this.AdresText = new System.Windows.Forms.TextBox();
            this.BornText = new System.Windows.Forms.DateTimePicker();
            this.NumberText = new System.Windows.Forms.MaskedTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.Location = new System.Drawing.Point(20, 314);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(121, 27);
            this.Back.TabIndex = 21;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(31, 225);
            this.Adres.MaximumSize = new System.Drawing.Size(300, 0);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(44, 13);
            this.Adres.TabIndex = 16;
            this.Adres.Text = "Адрес: ";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(31, 183);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(99, 13);
            this.Number.TabIndex = 15;
            this.Number.Text = "Номер телефона: ";
            // 
            // Born
            // 
            this.Born.AutoSize = true;
            this.Born.Location = new System.Drawing.Point(31, 150);
            this.Born.Name = "Born";
            this.Born.Size = new System.Drawing.Size(92, 13);
            this.Born.TabIndex = 14;
            this.Born.Text = "Дата рождения: ";
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.Location = new System.Drawing.Point(33, 86);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(60, 13);
            this.Sname.TabIndex = 13;
            this.Sname.Text = "Отчество: ";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(31, 58);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(62, 13);
            this.Lname.TabIndex = 12;
            this.Lname.Text = "Фамилия: ";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(33, 25);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(35, 13);
            this.Fname.TabIndex = 11;
            this.Fname.Text = "Имя: ";
            // 
            // FnameText
            // 
            this.FnameText.Location = new System.Drawing.Point(83, 22);
            this.FnameText.MaxLength = 20;
            this.FnameText.Name = "FnameText";
            this.FnameText.Size = new System.Drawing.Size(100, 20);
            this.FnameText.TabIndex = 22;
            // 
            // LnameText
            // 
            this.LnameText.Location = new System.Drawing.Point(99, 55);
            this.LnameText.MaxLength = 20;
            this.LnameText.Name = "LnameText";
            this.LnameText.Size = new System.Drawing.Size(100, 20);
            this.LnameText.TabIndex = 23;
            // 
            // SnameText
            // 
            this.SnameText.Location = new System.Drawing.Point(99, 86);
            this.SnameText.MaxLength = 20;
            this.SnameText.Name = "SnameText";
            this.SnameText.Size = new System.Drawing.Size(100, 20);
            this.SnameText.TabIndex = 24;
            // 
            // AdresText
            // 
            this.AdresText.Location = new System.Drawing.Point(81, 218);
            this.AdresText.MaxLength = 140;
            this.AdresText.Multiline = true;
            this.AdresText.Name = "AdresText";
            this.AdresText.Size = new System.Drawing.Size(271, 64);
            this.AdresText.TabIndex = 27;
            // 
            // BornText
            // 
            this.BornText.CustomFormat = "yyyy-MM-dd";
            this.BornText.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BornText.Location = new System.Drawing.Point(120, 143);
            this.BornText.Name = "BornText";
            this.BornText.Size = new System.Drawing.Size(200, 20);
            this.BornText.TabIndex = 25;
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(136, 180);
            this.NumberText.Mask = "(999) 000-0000";
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(100, 20);
            this.NumberText.TabIndex = 30;
            this.NumberText.Click += new System.EventHandler(this.NumberText_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(181, 314);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(121, 27);
            this.Add.TabIndex = 34;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Done_Click);
            // 
            // AddEmployerForm
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Back;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.AdresText);
            this.Controls.Add(this.BornText);
            this.Controls.Add(this.SnameText);
            this.Controls.Add(this.LnameText);
            this.Controls.Add(this.FnameText);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Born);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label Born;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.TextBox FnameText;
        private System.Windows.Forms.TextBox LnameText;
        private System.Windows.Forms.TextBox SnameText;
        private System.Windows.Forms.TextBox AdresText;
        private System.Windows.Forms.DateTimePicker BornText;
        private System.Windows.Forms.MaskedTextBox NumberText;
        private System.Windows.Forms.Button Add;
    }
}