﻿namespace VladCourseWork.Forms
{
    partial class AddCustomerForm
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
            this.LnameText = new System.Windows.Forms.TextBox();
            this.FnameText = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.AdresText = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SnameText = new System.Windows.Forms.TextBox();
            this.SnameLabel = new System.Windows.Forms.Label();
            this.NumberText = new System.Windows.Forms.MaskedTextBox();
            this.Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LnameText
            // 
            this.LnameText.Location = new System.Drawing.Point(92, 65);
            this.LnameText.MaxLength = 20;
            this.LnameText.Name = "LnameText";
            this.LnameText.Size = new System.Drawing.Size(100, 20);
            this.LnameText.TabIndex = 27;
            // 
            // FnameText
            // 
            this.FnameText.Location = new System.Drawing.Point(92, 28);
            this.FnameText.MaxLength = 20;
            this.FnameText.Name = "FnameText";
            this.FnameText.Size = new System.Drawing.Size(100, 20);
            this.FnameText.TabIndex = 26;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(24, 68);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(62, 13);
            this.Lname.TabIndex = 25;
            this.Lname.Text = "Фамилия: ";
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(26, 35);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(35, 13);
            this.Fname.TabIndex = 24;
            this.Fname.Text = "Имя: ";
            // 
            // AdresText
            // 
            this.AdresText.Location = new System.Drawing.Point(74, 137);
            this.AdresText.MaxLength = 140;
            this.AdresText.Multiline = true;
            this.AdresText.Name = "AdresText";
            this.AdresText.Size = new System.Drawing.Size(271, 64);
            this.AdresText.TabIndex = 29;
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(24, 144);
            this.Adres.MaximumSize = new System.Drawing.Size(300, 0);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(44, 13);
            this.Adres.TabIndex = 28;
            this.Adres.Text = "Адрес: ";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(7, 276);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 33;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(140, 266);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(81, 33);
            this.Add.TabIndex = 32;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SnameText
            // 
            this.SnameText.Location = new System.Drawing.Point(92, 100);
            this.SnameText.MaxLength = 20;
            this.SnameText.Name = "SnameText";
            this.SnameText.Size = new System.Drawing.Size(100, 20);
            this.SnameText.TabIndex = 35;
            // 
            // SnameLabel
            // 
            this.SnameLabel.AutoSize = true;
            this.SnameLabel.Location = new System.Drawing.Point(24, 103);
            this.SnameLabel.Name = "SnameLabel";
            this.SnameLabel.Size = new System.Drawing.Size(54, 13);
            this.SnameLabel.TabIndex = 34;
            this.SnameLabel.Text = "Отчество";
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(129, 229);
            this.NumberText.Mask = "(999) 000-0000";
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(100, 20);
            this.NumberText.TabIndex = 37;
            this.NumberText.Click += new System.EventHandler(this.NumberText_Click);
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(24, 232);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(99, 13);
            this.Number.TabIndex = 36;
            this.Number.Text = "Номер телефона: ";
            // 
            // AddCustomerForm
            // 
            this.AcceptButton = this.Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(415, 310);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.SnameText);
            this.Controls.Add(this.SnameLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AdresText);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.LnameText);
            this.Controls.Add(this.FnameText);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LnameText;
        private System.Windows.Forms.TextBox FnameText;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.TextBox AdresText;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox SnameText;
        private System.Windows.Forms.Label SnameLabel;
        private System.Windows.Forms.MaskedTextBox NumberText;
        private System.Windows.Forms.Label Number;
    }
}