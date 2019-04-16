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
    public partial class AddEmployerForm : MainController
    {
        List<List<string>> Jobs;
        int Id;
    
        public AddEmployerForm():base()
        {
            InitializeComponent();
            Personalization();
            Id = 0;
            BornText.MinDate = DateTime.Now.Date.AddYears(-50);
            BornText.MaxDate = DateTime.Now.Date.AddYears(-18);
          
        }

        public AddEmployerForm(Dictionary<string, string> info):base()
        {
            InitializeComponent();
            Personalization();
            this.Text = "Изменить";
            Add.Text= "Изменить";
            Id = Convert.ToInt32(info["Id"]);
            FnameText.Text = info["Fname"];
             LnameText.Text = info["Lname"];
            SnameText.Text = info["Sname"];
            BornText.Text = info["Born"];
            NumberText.Text = info["Phone"];
            AdresText.Text = info["Adres"];

            BornText.MinDate = DateTime.Now.Date.AddYears(-50);
            BornText.MaxDate = DateTime.Now.Date.AddYears(-18);
        }

        private void NumberText_Click(object sender, EventArgs e)
        {
           (sender as MaskedTextBox).Clear();
           (sender as MaskedTextBox).SelectionStart = 0;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate () { if (FnameText.Text.Length < 1) { Error("Не правильно введено имя"); return true; }; return false; });
            tests.Add(delegate () { if (LnameText.Text.Length < 1) { Error("Не правильно введена фамилия"); return true; }; return false; });
            tests.Add(delegate () { if (SnameText.Text.Length < 1) { Error("Не правильно введено отчество"); return true; }; return false; });
            tests.Add(delegate () { if (NumberText.Text.Where(c => Char.IsDigit(c)).Count() < 10) { Error("Не правильно введен номер"); return true; }; return false; });
            tests.Add(delegate () { if (AdresText.Text.Length < 3) { Error("Не правильно введен адрес"); return true; }; return false; });
            if (CheckTest(tests.ToArray()))
            {
                string number = "";
                foreach (var n in NumberText.Text)
                {
                    if (char.IsDigit(n)) number += n;
                }
                if (Id != 0)
                    Controller.UpdateIn(SpecialSqlController.Tables.employeers, new List<string> { LnameText.Text, FnameText.Text, SnameText.Text, BornText.Text, number, AdresText.Text},Id.ToString());

                else
                    Controller.InsertIn(SpecialSqlController.Tables.employeers, new List<string> { LnameText.Text, FnameText.Text, SnameText.Text, BornText.Text, number, AdresText.Text});
                this.Close();
            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
