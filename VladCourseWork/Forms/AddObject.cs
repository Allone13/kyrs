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
    public partial class AddObject : MainController
    {
        List<Dictionary<string, string>> Buy;
        List<Dictionary<string, string>> Types;
        List<Dictionary<string, string>> Employeers;

        public AddObject()
        {
            InitializeComponent();
            Personalization();
            EmployeerText.DropDownStyle = ComboBoxStyle.DropDownList;
            Buy = new List<Dictionary<string, string>>();
            Actions();
        }
        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.objects, delegate (ref List<Dictionary<string, string>> data)
            {
                for (int g = 0; g < data.Count; g++)
                {
                    data[g].Remove("Enable");
                }
            });


            Employeers = Controller.GetAllFromWithNames(SpecialSqlController.Tables.employeers);
        }
        private void ClearRows(bool par = false)
        {
            CostText.Enabled = par;
            DescriptionText.Enabled = par;
            TypeText.Enabled = par;
            //DescriptionText.Text = "";
      //      CostText.Value = 1;
          //  NameText.Text = "";
        //    CountText.Value = 1;
     //       TypeText.Text = "";
        }
        public override void Actions()
        {
            NameText.Items.Clear();
            EmployeerText.DropDownStyle = TypeText.DropDownStyle = ComboBoxStyle.DropDownList;
            MainAction();
            AddTypes();
            foreach (var l in DataList)
            {
                NameText.Items.Add(l["Names"]);
            }

            foreach (var e in Employeers)
            {
                EmployeerText.Items.Add(e["Fname"]);
            }

        }
        private void AddTypes()
        {
            TypeText.Items.Clear();
            Types = Controller.GetAllFromWithNames(SpecialSqlController.Tables.objecttype);
            foreach (var t in Types)
            {
                TypeText.Items.Add(t["Names"]);
            }
        }

        private void NameText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            if (NameText.Items.Contains(NameText.Text))
            {
               
                Dictionary<string, string> row = DataList.Where(x => x["Names"] == NameText.Text).First();
                int id = int.Parse(row["Id"]);
                CostText.Text = row["Cost"];
                DescriptionText.Text = row["Description"];
                if (!TypeText.Items.Contains(Types.Where(x => x["Id"] == row["Type"]).First()["Names"]))
                {
                    Types.Add(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.objecttype,int.Parse( row["Type"])));
                    TypeText.Items.Add(Types.Last()["Names"]);
                        }
                TypeText.Text = Types.Where(x => x["Id"] == row["Type"]).First()["Names"];
                ClearRows();

            }
            else
            {
                CountText.Value = 1;
                CostText.Value = 1;
                if (DescriptionText.Text.Length > 0)
                    DescriptionText.Text = "";
                TypeText.Text = "";
             //   TypeText.Text = Text;
                ClearRows(true);
            }
        }

        private void Categoryes_Click(object sender, EventArgs e)
        {
            OpenForm(new Edit(SpecialSqlController.Tables.objecttype));
            AddTypes();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate ()
            {
                if (NameText.Text.Length < 5) { Error("Слишком короткое название"); return true; }
                else return false;
            });
            tests.Add(delegate ()
            {
                if (TypeText.SelectedIndex < 0) { Error("Не выбран тип"); return true; }
                else return false;
            });
            tests.Add(delegate ()
            {
                if (DescriptionText.Text.Length < 10) { Error("Слишком короткое описание"); return true; }
                else return false;
            });

            if (CheckTest(tests.ToArray()))
            {
                string obj = "";
                if (NameText.SelectedIndex == -1)
                {
                    Controller.InsertIn(SpecialSqlController.Tables.objects, new List<string> { NameText.Text, Types[TypeText.SelectedIndex]["Id"], CostText.Text, CountText.Value.ToString(), DescriptionText.Text });
                    obj = Controller.Maximum(SpecialSqlController.Tables.objects, "Id").ToString();
                }
                else
                {
                    obj = DataList[NameText.SelectedIndex]["Id"];
                    Controller.UpdateCell(SpecialSqlController.Tables.objects,"`Count`=`Count`+"+ CountText.Value.ToString(),"`Id`="+obj);
                }
                Controller.InsertIn(SpecialSqlController.Tables.buylist, new List<string> { Employeers[EmployeerText.SelectedIndex]["Id"], CountText.Value.ToString(), Controller.Maximum(SpecialSqlController.Tables.buy, "Id").ToString() },deleteLast:false);

             

                Actions();
                NameText.Text = "";
     }
        }

        private void StartShop_Click(object sender, EventArgs e)
        {
            if (EmployeerText.SelectedIndex > -1)
            {
                panel1.Hide();
                Controller.InsertIn(SpecialSqlController.Tables.buy, new List<string> { Employeers[EmployeerText.SelectedIndex]["Id"], DateShop.Text });

            }
            else
            {
                Error("Не выбран сотрудник для закупки");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
