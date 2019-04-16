using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VladCourseWork.Forms
{
    public partial class OrdersForm : MainController
    {
        public OrdersForm() : base()
        {
            InitializeComponent();
            Actions();
            Personalization();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.orders, delegate (Dictionary<string, string> data)
            {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add("Id", data["Id"]);
            result.Add("Names", Controller.TakeRowWithNamesById(SpecialSqlController.Tables.customer, int.Parse(data["Customer"]))["Lname"]);
                result.Add("Employeer", Controller.TakeRowWithNamesById(SpecialSqlController.Tables.employeers, int.Parse(data["Employeer"]))["Lname"]);
            result.Add("Status", data["Status"]);
                result.Add("DateGive",Convert.ToDateTime( data["DateGive"]).ToShortDateString());
        result.Add("All", data["Cost"]);
                return result;
            });
            DataList.Reverse();
        }


        public override void Actions()
        {
            MainAction();
            Print(ref Orders);
            StatysList.Items.Clear();
            StatysList.Items.AddRange(new string[] { "Принят", "Ведутся работы", "Готов к сдаче", "Сдан", "Отменен" });
            EmployeerList.Items.Clear();
            var emp = Controller.GetAllFromWithNames(SpecialSqlController.Tables.employeers);
            foreach (var e in emp)
            {
                EmployeerList.Items.Add(e["Lname"]);
            }
            day.MinDate = Convert.ToDateTime(Controller.Query("select min(`DateGive`) from orders")[0][0]);
            day.MaxDate = Convert.ToDateTime(Controller.Query("select Max(`DateGive`) from orders")[0][0]);
            OnlyCan.Checked = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (RowTest(Orders) && Orders[4, Orders.SelectedRows[0].Index].Value.ToString().CompareTo("Принят") == 0)
            {

                Hiding(Orders, SpecialSqlController.Tables.orders, delegate (string[] s)
                {
       
                    return Controller.Request($"UPDATE `orders` SET `Status` = 'Отменен' WHERE (`Id` = '{s[0]}')");
                }, false);
      
                Actions();
            }
            else
            {
                Error("Статус заказа не позволяет его отменить");
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (RowTest(Orders))
            {
                OpenForm(new CheckCreateForm(GetId(Orders)));
                Actions();
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { return !StatysList.CheckedItems.Contains(row["Status"]) && StatysList.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return !EmployeerList.CheckedItems.Contains(row["Employeer"]) && EmployeerList.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return OnlyCan.Checked&& row["DateGive"]!= Convert.ToDateTime(day.Text).ToShortDateString(); });


            Filtres(tags.ToArray());
            Print(ref Orders);
        }

        private void CreateCheck_Click(object sender, EventArgs e)
        {
            if (RowTest(Orders))
            {
                string text = "";
                var o = Controller.TakeRowWithNamesById(SpecialSqlController.Tables.orders, int.Parse( GetId(Orders)));
                text += "Заказ №" + o["Id"] + "\n";
                text += "Сотрудник: " + Controller.TakeRowWithNamesById(SpecialSqlController.Tables.employeers,int.Parse( o["Employeer"]))["Lname"] + "\n";
                text += "Клиент: " + Controller.TakeRowWithNamesById(SpecialSqlController.Tables.customer,int.Parse( o["Customer"]))["Lname"] + "\n";
                text += "Дата заключения: " + o["DateOrder"]+ "\n";
                text += "Дата здачи: " + o["DateGive"]+ "\n";
                text += "Объкты:\n";
                var obj = Controller.GetAllFromWithNames(SpecialSqlController.Tables.shablonlist,"`Shablon`="+o["Shablon"]);
                for (int i = 0; i < obj.Count; i++)
                {
                    text += Controller.TakeRowWithNamesById(SpecialSqlController.Tables.objects, int.Parse(obj[i]["Objects"]))["Names"] + "  " + obj[i]["Count"]+"\n";
                }
                text += "Адрес: " + Controller.TakeRowWithNamesById(SpecialSqlController.Tables.customer,int.Parse(o["Customer"]))["Adres"] + "\n";

                text += "Сумма: " + o["Cost"] + "\n";

                string l = @"Check.doc";
                using (StreamWriter writer = new StreamWriter(l, false, System.Text.Encoding.UTF8)
                )
                {
                    writer.WriteLine(text);
                }
                Error("Чек создан");
            }
        }
    }
}
