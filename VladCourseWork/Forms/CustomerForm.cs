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
    public partial class CustomerForm : MainController
    {
        public CustomerForm()
        {
            InitializeComponent();
            Personalization();
            Actions();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.customer, delegate (ref List<Dictionary<string, string>> data)
            {
                for (int j = 0; j < data.Count; j++)
                {
                    data[j]["Fname"] += " " + data[j]["Lname"]+" " + data[j]["Sname"];
                    data[j].Remove("Lname");
                    data[j].Remove("Sname");
                }

            });
        }

        public override void Actions()
        {
            MainAction();
            SortPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 1;
            Print(ref Customers);
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortPanel.SelectedIndex)
            {
                case 0:
                    Sort("Fname", -1);
                    break;
                case 1:
                    Sort("Fname", 1);
                    break;
            }
            Print(ref Customers);
        }


        private void Delete_Click(object sender, EventArgs e)
        {
                Hiding(Customers,SpecialSqlController.Tables.customer);
        }

        private void Add_Click(object sender, EventArgs e)
        {
           OpenForm(new AddCustomerForm());
            Actions();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (RowTest(Customers))
            {
                string id = GetId(Customers);
           OpenForm(new AddCustomerForm(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.customer, Convert.ToInt32(id))));
                Actions();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
