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
    public partial class StatisticForm : MainController
    {
  
        public StatisticForm():base()
        {
            InitializeComponent();
            Actions();
            Personalization();
        }
        public override void MainAction() {
            GetData(SpecialSqlController.Tables.orders, delegate (Dictionary<string, string> data)
         {
             Dictionary<string, string> res = new Dictionary<string, string>();
             if (Convert.ToDateTime(data["DateOrder"]).Date >= DateWith.Value.Date && Convert.ToDateTime(data["DateOrder"]).Date <= DateTo.Value.Date)
             {

                         res.Add("Id", data["Id"]);
                         res.Add("Employeer", Controller.TakeRowWithNamesById(SpecialSqlController.Tables.employeers,int.Parse(data["Employeer"]))["Lname"]);
                         res.Add("DateOrder", Convert.ToDateTime( data["DateOrder"]).ToShortDateString());
                         res.Add("DateGive", Convert.ToDateTime(data["DateGive"]).ToShortDateString());
                         res.Add("Cost", data["Cost"]);
                     
             }
             return res;
         });
            DataList.Reverse();
        }

        void AllCheck()
        {
            int m = 0;
            for (int i = 0; i < Statist.RowCount; i++)
            {
                m+= Convert.ToInt32(Statist[4,i].Value);
            }
            AllMoney.Text = m.ToString();
            AllCount.Text = Statist.RowCount.ToString();
        }

        public override void Actions()
        {
            DateWith.Value = DateTo.MinDate = DateWith.MinDate = Convert.ToDateTime(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.orders, Controller.Minimum(SpecialSqlController.Tables.orders, "Id"))["DateOrder"]);
            DateTo.Value = DateWith.MaxDate = DateTo.MaxDate = DateTime.Now;
            MainAction();

            Print(ref Statist);
            AllCheck();

        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            MainAction();
            Print(ref Statist);
            AllCheck();
        }



        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void DateWith_ValueChanged(object sender, EventArgs e)
        {
            DateTo.MinDate = DateWith.Value;
            DateWith.MaxDate = DateTo.Value;
        }
    }
}
