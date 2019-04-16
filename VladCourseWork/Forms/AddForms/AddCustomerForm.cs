using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladCourseWork.Forms
{
    public partial class AddCustomerForm : MainController
    {
        int Id;
        public AddCustomerForm() : base()
        {
            InitializeComponent();
            Personalization();
            Id = 0;
        }
        public AddCustomerForm(Dictionary<string, string> info) : base()
        {
            InitializeComponent();
            Personalization();
            this.Text = Add.Text = "Изменить";
            Id = Convert.ToInt32(info["Id"]);
            LnameText.Text = info["Lname"];
            FnameText.Text = info["Fname"];
            SnameText.Text = info["Sname"];
            AdresText.Text = info["Adres"];
            NumberText.Text = info["Phone"];

        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<TestValid> tests = new List<TestValid>();
            string number = "";
            foreach (var n in NumberText.Text)
            {
                if (char.IsDigit(n)) number += n;
            }
            tests.Add(delegate () { if (LnameText.Text.Length < 1) { Error("Не правильно введена фамилия"); return true; }; return false; });
            tests.Add(delegate () { if (FnameText.Text.Length < 1) { Error("Не правильно введено имя"); return true; }; return false; });
            tests.Add(delegate () { if (SnameText.Text.Length < 1) { Error("Не правильно введено отчество"); return true; }; return false; });
            tests.Add(delegate () { if (AdresText.Text.Length < 1) { Error("Не правильно введен адрес"); return true; }; return false; });
            tests.Add(delegate () { if (NumberText.Text.Where(c => Char.IsDigit(c)).Count() < 10) { Error("Не правильно введен номер"); return true; }; return false; });

            if (CheckTest(tests.ToArray()))
            {
                if (Id == 0)
                    Controller.InsertIn(SpecialSqlController.Tables.customer, new List<string> { FnameText.Text, LnameText.Text, SnameText.Text, AdresText.Text, number });
                else
                {
                    Controller.UpdateIn(SpecialSqlController.Tables.customer, new List<string> { FnameText.Text, LnameText.Text, SnameText.Text, AdresText.Text, number }, Id.ToString());
                }
                this.Close();
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NumberText_Click(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).Clear();
            (sender as MaskedTextBox).SelectionStart = 0;
        }
    }
}
