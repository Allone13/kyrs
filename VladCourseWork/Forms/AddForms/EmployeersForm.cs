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
    public partial class EmployeersForm : MainController
    {

        public EmployeersForm() : base()
        {
            InitializeComponent();
            Personalization();
            Actions();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.employeers, delegate (Dictionary<string, string> row)
            {
                Dictionary<string, string> newRow = new Dictionary<string, string>();
                newRow.Add("Id", row["Id"]);
                newRow.Add("FLName", row["Lname"] + " " + row["Fname"]);
                newRow.Add("Born",Convert.ToDateTime( row["Born"]).ToShortDateString());
                newRow.Add("Phone", row["Phone"]);
                newRow.Add("Adres", row["Adres"]);
                return newRow;
            });
        }

        public override void Actions()
        {
            MainAction();
            SortPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 1;
            Print(ref Employeers);
        }

        private void Add_Click(object sender, EventArgs e)
        {
        OpenForm (new AddEmployerForm());
            Actions();
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortPanel.SelectedIndex)
            {
                case 0:
                    Sort("FLName", -1);
                    break;
                case 1:
                    Sort("FLName", 1);
                    break;
            }
            Print(ref Employeers);
        }




        private void Update_Click(object sender, EventArgs e)
        {
            if (RowTest(Employeers))
            {
                string id =GetId(Employeers);
             OpenForm( new AddEmployerForm(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.employeers, Convert.ToInt32(id))));
                Actions();
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
        
                Hiding(Employeers, SpecialSqlController.Tables.employeers);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
