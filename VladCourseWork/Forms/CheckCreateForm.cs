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
    public partial class CheckCreateForm : MainController
    {
        List<Dictionary<string, string>> Employeers;
        List<Dictionary<string, string>> Customers;
        List<Dictionary<string, string>> Objects;
        List<Dictionary<string, string>> Shablons;
        Dictionary<string, string> BuyShablon;
        List<Dictionary<string, string>> BuyObjects;
        List<Dictionary<string, string>> AdditObj;
        int All = 0;
        int Minus = 0;
        string RowId;
        public CheckCreateForm()
        {
            InitializeComponent();
            Personalization();
            RowId = null;
            Statys.Items.Clear();
            Statys.Items.AddRange(new string[] { "Принят"/*, "Ведутся работы", "Готов к сдаче", "Сдан"*/});
            TimeOrder.MinDate = DateTime.Now;
            TimeOrder.Enabled = false;
            DateGive.MinDate = DateTime.Now.AddDays(7);
            Shablons=Controller.GetAllFromWithNames(SpecialSqlController.Tables.shablons);
            BuyObjects = new List<Dictionary<string, string>>();
            Statys.SelectedIndex = 0;
            Actions();
            ShablonText.Items.Add("None");
            ShablonText.Text = "None";
        }
        public CheckCreateForm(string RowId)
        {
            InitializeComponent();
            Personalization();
            Dictionary<string, string> r = Controller.TakeRowWithNamesById(SpecialSqlController.Tables.orders, int.Parse(RowId));
            this.RowId = RowId;
      
            Shablons = Controller.GetAllFromWithNames(SpecialSqlController.Tables.shablons);
            BuyObjects = new List<Dictionary<string, string>>();
            Statys.SelectedIndex = 0;
            Actions();

            Statys.Items.Clear();
            Statys.Items.AddRange(new string[] { "Принят", "Ведутся работы", "Готов к сдаче", "Сдан", "Отменен" });
            Statys.Text = r["Status"];
            if (Statys.Text.CompareTo("Отменен") != 0)
                Statys.Items.RemoveAt(Statys.Items.Count - 1);
            for (int i = 0; i < Statys.Items.IndexOf(r["Status"]); i++)
            {
                Statys.Items.RemoveAt(i);
                i--;
            }

            Customer.SelectedIndex =Customers.IndexOf(Customers.First(x=>x["Id"]== r["Customer"]));
            Employeer.SelectedIndex = Employeers.IndexOf(Employeers.First(x => x["Id"] == r["Employeer"]));
            TimeOrder.Text = Convert.ToDateTime( r["DateOrder"]).ToShortDateString();
            DateGive.MinDate = Convert.ToDateTime(r["DateGive"]);
            DateGive.Text = Convert.ToDateTime(r["DateGive"]).ToShortDateString();

            Customer.Enabled = false;
            Employeer.Enabled = false;
            TimeOrder.Enabled = false;
 
            Add.Enabled = false;
            AllMoney.Enabled = false;
            MainObjects.Enabled = false;
           ShablonText.Enabled = false;
            AddObjects.Enabled = false;
            Add.Enabled = false;
            delete.Enabled = false;
            if (!Shablons.Any(x => x["Id"] == r["Shablon"]))
            {
                Shablons.Add(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.shablons, int.Parse(r["Shablon"])));
                ShablonText.Items.Add(Shablons.Last()["Names"]);
                ShablonText.SelectedIndex = ShablonText.Items.Count - 1;
            }
            else
                ShablonText.SelectedIndex = Shablons.IndexOf(Shablons.First(x => x["Id"] == r["Shablon"]));

           if(r["Status"]!="Принят")
                DateGive.Enabled = false;
            if (r["Status"] == "Отменен" || r["Status"] == "Оплачен")
                {
                    Create.Enabled = false;
                    Statys.Enabled = false;
                }
     
            ShablonText.Items.Add("None");
        }
        public override void Actions()
        {
            Employeers = Controller.GetAllFromWithNames(SpecialSqlController.Tables.employeers);
            Customers = Controller.GetAllFromWithNames(SpecialSqlController.Tables.customer);
            Shablons = Controller.GetAllFromWithNames(SpecialSqlController.Tables.shablons);

          ShablonText.DropDownStyle=  Employeer.DropDownStyle =Customer.DropDownStyle=Statys.DropDownStyle= ComboBoxStyle.DropDownList;
            Objects = Controller.GetAllFromWithNames(SpecialSqlController.Tables.objects);
            foreach (var e in Employeers)
                Employeer.Items.Add(e["Lname"] + " " + e["Fname"][0] + ".");
            foreach (var c in Customers)
                Customer.Items.Add(c["Lname"] + " " + c["Fname"]);
            ShablonText.Items.Clear();
            foreach (var s in Shablons)
                ShablonText.Items.Add(s["Names"]);

            AddObjectsList();
            //foreach (var e in Eat)
            //{
            //    Tovar.Items.Add(e["Names"] + " " + e["Portion"] + " " + e["Cost"] + "грн.");
            //}
            //foreach (var d in Shablons)
            //{
            //    Tovar.Items.Add(d["Names"] + " " + d["Volume"] + "мл. " + d["Cost"] + "грн.");
            //}
        }



        private void Create_Click(object sender, EventArgs e)
        {
            CreateCheck();
        }

        private void CreateCheck()
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate () { if (Customer.SelectedIndex < 0) { Error("Не выбран заказчик"); return true; }; return false; });
            tests.Add(delegate () { if (Employeer.SelectedIndex == -1) { Error("Сотрудник не выбран"); return true; }; return false; });
            tests.Add(delegate () { if (BuyObjects.Count==0) { Error("Нет обьектов"); return true; }; return false; });
           if (CheckTest(tests.ToArray()))
            {
                if (RowId == null)
                {
                    if (BuyObjects.Count == MainObjects.RowCount) {
                        string er = "";
                        var o = Controller.GetAllFromWithNames(  SpecialSqlController.Tables.shablonlist,"`Shablon`="+ Shablons[ShablonText.SelectedIndex]["Id"]);
                        string id = null;
                        foreach (var i in o)
                        {
                            var r = Controller.TakeRowWithNamesById(SpecialSqlController.Tables.objects, int.Parse(i["Objects"]));
                            if (int.Parse(r["Count"]) < int.Parse(i["Count"]))
                            {
                                er = "На складе не достатоно объектов будет сформирован зкаказ на доставку, а это может занять время\n";
                                if (id == null) {
                                    Controller.InsertIn(SpecialSqlController.Tables.buy, new List<string> { Employeers[Employeer.SelectedIndex]["Id"], TimeOrder.Text });
                                    id = Controller.Maximum(SpecialSqlController.Tables.buy, "Id").ToString();
                                }
                                Controller.InsertIn(SpecialSqlController.Tables.buylist,new List<string> {r["Id"], (int.Parse(i["Count"])- int.Parse(r["Count"])).ToString(),id },deleteLast:false);
                                Controller.UpdateCell(SpecialSqlController.Tables.objects, "`Count`=0", "`Id`=" + r["Id"]);

                            }
                            else
                            {
                                Controller.UpdateCell(SpecialSqlController.Tables.objects, "`Count`=`Count`-"+i["Count"], "`Id`=" + r["Id"]);

                            }
                        }
                        if (er.Length > 0) Error(er);
                        if (Controller.InsertIn(SpecialSqlController.Tables.orders, new List<string> { Customers[Customer.SelectedIndex]["Id"], Employeers[Employeer.SelectedIndex]["Id"], TimeOrder.Text, DateGive.Text, Statys.Text, Shablons[ShablonText.SelectedIndex]["Id"], (All + Minus).ToString() }))
                            this.Close();
                    }
                    else
                    {
                        if (Controller.InsertInMenu(SpecialSqlController.Tables.shablons, new List<string> { "Заказ Номер" + (Controller.Maximum(SpecialSqlController.Tables.orders, "Id") + 1), "Это специальный зкаказ" + (Controller.Maximum(SpecialSqlController.Tables.orders, "Id") + 1), "0" }, BuyObjects, false))
                        {


                            string er = "";
                            var o = Controller.GetAllFromWithNames(SpecialSqlController.Tables.shablonlist, "`Shablon`=" + Controller.Maximum(SpecialSqlController.Tables.shablons, "Id").ToString());
                            string id = null;


                            foreach (var i in o)
                            {
                                var r = Controller.TakeRowWithNamesById(SpecialSqlController.Tables.objects, int.Parse(i["Objects"]));
                                if (int.Parse(r["Count"]) < int.Parse(i["Count"]))
                                {
                                    er = "На складе не достатоно объектов будет сформирован зкаказ на доставку, а это может занять время\n";
                                    if (id == null)
                                    {
                                        Controller.InsertIn(SpecialSqlController.Tables.buy, new List<string> { Employeers[Employeer.SelectedIndex]["Id"], TimeOrder.Text });
                                        id = Controller.Maximum(SpecialSqlController.Tables.buy, "Id").ToString();
                                    }
                                    Controller.InsertIn(SpecialSqlController.Tables.buylist, new List<string> { r["Id"], (int.Parse(i["Count"]) - int.Parse(r["Count"])).ToString(), id }, deleteLast: false);
                                    Controller.UpdateCell(SpecialSqlController.Tables.objects, "`Count`=0", "`Id`=" + r["Id"]);

                                }
                                else
                                {
                                    Controller.UpdateCell(SpecialSqlController.Tables.objects, "`Count`=`Count`-" + i["Count"], "`Id`=" + r["Id"]);

                                }
                            }
                            if (er.Length > 0) Error(er);
                            if (Controller.InsertIn(SpecialSqlController.Tables.orders, new List<string> { Customers[Customer.SelectedIndex]["Id"], Employeers[Employeer.SelectedIndex]["Id"], TimeOrder.Text, DateGive.Text, Statys.Text, Controller.Maximum(SpecialSqlController.Tables.shablons, "Id").ToString(), (All+Minus).ToString() }))
                                this.Close();
                        }
                    }
                }
                else
                {
                    if (Controller.UpdateIn(SpecialSqlController.Tables.orders, new List<string> { Customers[Customer.SelectedIndex]["Id"], Employeers[Employeer.SelectedIndex]["Id"], TimeOrder.Text, DateGive.Text, Statys.Text, BuyShablon["Id"], (All+Minus).ToString() },RowId))
                        this.Close();
                    //if (BuyObjects.Count == MainObjects.RowCount)
                    //{
                    //    if (Controller.InsertIn(SpecialSqlController.Tables.orders, new List<string> { Customers[Customer.SelectedIndex]["Id"], Employeers[Employeer.SelectedIndex]["Id"], TimeOrder.Text, DateGive.Text, Statys.Text, Shablons[ShablonText.SelectedIndex]["Id"] }))
                    //        this.Close();
                    //}
                    //else
                    //{

                    //    if (Controller.InsertInMenu(SpecialSqlController.Tables.shablons, new List<string> { "Заказ Номер" + (Controller.Maximum(SpecialSqlController.Tables.orders, "Id") + 1), "Это специальный зкаказ" + (Controller.Maximum(SpecialSqlController.Tables.orders, "Id") + 1), All.ToString(), "0" }, BuyObjects, false))
                    //        if (Controller.InsertIn(SpecialSqlController.Tables.orders, new List<string> { Customers[Customer.SelectedIndex]["Id"], Employeers[Employeer.SelectedIndex]["Id"], TimeOrder.Text, DateGive.Text, Statys.Text, Controller.Maximum(SpecialSqlController.Tables.shablons, "Id").ToString() }))
                    //            this.Close();
                    //}
                    //Controller.DeleteFrom(SpecialSqlController.Tables.orders, "`Check`=" + RowId);
                    //Controller.DeleteFrom(SpecialSqlController.Tables.checks, int.Parse(RowId));
                    //if (Controller.InsertCheck(new List<string> { Customer.Text, Table.SelectedIndex != -1 ? Tables.Where(x => x["Names"].CompareTo(Table.Text) == 0).First()["Id"] : null, Employeers[Employeer.SelectedIndex]["Id"], TimeOrder.Text, DateGive.Text, AdresText.Text.Length != 0 ? AdresText.Text : null, Statys.Text, CustomerCard.Count() != 0 ? CustomerCard["Id"] : null }, BuyEat, BuyShablons))
                    //{
                    //    if (Table.SelectedIndex != -1 && Statys.Text == "Оплачен") Controller.Request("UPDATE `pizzeria`.`tables` SET `CanTake` = '1' WHERE `Id`=" + (Tables.Where(x => x["Names"].CompareTo(Table.Text) == 0).First()["Id"]));

                    //    Dishes.Rows.Clear();
                    //    this.Close();

                    //}
                }
            }
        }


        private void CheckCreateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //for (int i = 0; i < Dishes.RowCount; i++)
            //{
            //    Delete_Click(Dishes, EventArgs.Empty);
            //    i--;
            //}
        }

        private void Statys_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Statys.Text == "Оплачен" && OnLoad)
            //{
            //    Calcut c = new Calcut(All);
            //    DialogResult result = c.ShowDialog();
            //    if (result != DialogResult.OK)
            //        Statys.SelectedIndex = Statys.Items.Count - 2;
            //    else
            //    {
            //        CreateCheck();
            //    }

            //}
        }

        private void AddObjectsList()
        {
            AdditObj = new List<Dictionary<string, string>>();
            foreach (var o in Objects)
            {
                if (!BuyObjects.Any(x => x["Id"] == o["Id"]&&x["Count"]!="0")) 
                    AdditObj.Add(o);
            }
            AddObjects.Items.Clear();
            AdditionalObjects.Rows.Clear();
            AddObjects.Text = "";
            numericUpDown1.Value = 1;
            foreach (var a in AdditObj)
            {
                AddObjects.Items.Add(a["Names"]);
            }
        }

        private void ShablonText_SelectedIndexChanged(object sender, EventArgs e)
        {
            All = 0;
            if (ShablonText.Text != "None")
            {
                BuyShablon = Shablons[ShablonText.SelectedIndex];
                var objects = Controller.GetAllFromWithNames(SpecialSqlController.Tables.shablonlist, "`Shablon`=" + BuyShablon["Id"]);

                BuyObjects.Clear();
                foreach(var o in objects)
                {
                    BuyObjects.Add(Objects.First(x=>x["Id"]==o["Objects"]));
                    All += int.Parse(o["Count"]) * int.Parse(BuyObjects.Last()["Cost"]);
                 BuyObjects.Last()["Count"] = o["Count"];
                    BuyObjects.Last().Remove("Type");
              

                }
                DataList.Clear();
                DataList.AddRange(BuyObjects);
                Print(ref MainObjects);
                AddObjectsList();
                Minus= All * 25/ 100;
                AllMoney.Text = (All+Minus).ToString();
            }
            else
            {
                BuyShablon = null;
             BuyObjects.Clear();
                DataList.Clear();
                Print(ref MainObjects);
                AddObjectsList();
            }
        }

        private void AddObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddObjects.SelectedIndex >= 0)
            {
                numericUpDown1.Enabled = true;
             //   numericUpDown1.Maximum = int.Parse(AdditObj[AddObjects.SelectedIndex]["Count"]);
                numericUpDown1.Value = 1;
            }
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 1;
                //  numericUpDown1.Maximum =1;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if ((AddObjects.SelectedIndex >= 0)){ 
                if (BuyObjects.Any(x=>x["Id"]== AdditObj[AddObjects.SelectedIndex]["Id"]))
                {
                    int i = 0;
                    for (; AdditionalObjects[0,i].Value.ToString() != AdditObj[AddObjects.SelectedIndex]["Id"]; i++) { }
                    AdditionalObjects.Rows.RemoveAt(i);
                    BuyObjects.Remove(BuyObjects.First( x => x["Id"] == AdditObj[AddObjects.SelectedIndex]["Id"]));
                }
                BuyObjects.Add(AdditObj[AddObjects.SelectedIndex]);
                All +=(int) numericUpDown1.Value * int.Parse(BuyObjects.Last()["Cost"]);
                BuyObjects.Last()["Count"] = numericUpDown1.Value.ToString();
                BuyObjects.Last().Remove("Type");
                DataList.Clear();
                DataList.AddRange(BuyObjects);
                AdditionalObjects.Rows.Add();
                int j = AdditionalObjects.RowCount-1;
                AdditionalObjects.Rows[j].Cells["d1"].Value = BuyObjects.Last()["Id"];
                AdditionalObjects.Rows[j].Cells["d2"].Value = BuyObjects.Last()["Names"];
                AdditionalObjects.Rows[j].Cells["d3"].Value = BuyObjects.Last()["Count"];
                AdditionalObjects.Rows[j].Cells["d4"].Value = BuyObjects.Last()["Cost"];
                AdditionalObjects.Rows[j].Cells["d5"].Value = BuyObjects.Last()["Description"];

                Minus = All * 25 / 100;
                AllMoney.Text = (All + Minus).ToString();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (RowTest(AdditionalObjects, false))
            {

                BuyObjects.Remove(BuyObjects.First(x => x["Id"] == AdditionalObjects[0,AdditionalObjects.SelectedRows[0].Index].Value.ToString()));
                All -= int.Parse(AdditionalObjects[2, AdditionalObjects.SelectedRows[0].Index].Value.ToString()) * int.Parse(AdditionalObjects[3, AdditionalObjects.SelectedRows[0].Index].Value.ToString());
                AdditionalObjects.Rows.RemoveAt(AdditionalObjects.SelectedRows[0].Index);

                Minus = All * 25 / 100;
                AllMoney.Text = (All + Minus).ToString();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new AddCustomerForm());
            Customers = Controller.GetAllFromWithNames(SpecialSqlController.Tables.customer);
            Customer.Items.Clear();
            foreach (var c in Customers)
                Customer.Items.Add(c["Lname"] + " " + c["Fname"]);
        }
    }
}
