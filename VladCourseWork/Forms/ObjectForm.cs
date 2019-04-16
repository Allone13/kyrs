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
    public partial class ObjectForm : MainController
    {
        List<List< string>> Types;
        public ObjectForm() : base()
        {
            InitializeComponent();
            Actions();
            Personalization();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.objects, delegate (ref List<Dictionary<string, string>> data)
            {
                for (int g = 0; g < data.Count; g++)
                {
                    data[g]["Type"] = Controller.TakeRowById(SpecialSqlController.Tables.objecttype, Convert.ToInt32(data[g]["Type"]))[1];
                    data[g].Remove("Enable");
                }
            });
        }

        public override void Actions()
        {
            OnlyCan.Checked = false;
            TypeList.Items.Clear();
             Types = Controller.GetAllFrom(SpecialSqlController.Tables.objecttype);
            foreach (var c in Types)
            {
                TypeList.Items.Add(c[1]);
                TypeText.Items.Add(c[1]);
            }
            CostFrom.Minimum = CostTo.Minimum = (Controller.Minimum(SpecialSqlController.Tables.objects, "Cost"));
            CostFrom.Maximum = CostTo.Maximum = (Controller.Maximum(SpecialSqlController.Tables.objects, "Cost"));
            CostTo.Value = CostTo.Maximum;
            SortPanel.DropDownStyle=TypeText.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 3;
            MainAction();
            ClearRows();
            Print(ref Objects);
        //    TypeList.Items.AddRange(new string [] { "Принят", "Ведутся работы", "Готов к сдаче", "Сдан", "Отменен" });
            var emp = Controller.GetAllFromWithNames(SpecialSqlController.Tables.employeers);
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortPanel.SelectedIndex)
            {

                case 2:
                    Sort("Names", -1);
                    break;
                case 3:
                    Sort("Names", 1);
                    break;
                case 0:
                    Sort("Count", -1);
                    break;
                case 1:
                    Sort("Count", 1);
                    break;
                case 4:
                    Sort("Cost", -1);
                    break;
                case 5:
                    Sort("Cost", 1);
                    break;
            }
            Print(ref Objects);
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) { return !TypeList.CheckedItems.Contains(row["Type"]) && TypeList.CheckedItems.Count > 0; });
            tags.Add(delegate (Dictionary<string, string> row) { return !(Convert.ToInt32(row["Cost"]) >= Convert.ToInt32(CostFrom.Value) && Convert.ToInt32(row["Cost"]) <= Convert.ToInt32(CostTo.Value)); });
           tags.Add(delegate (Dictionary<string, string> row) { return row["Count"] =="0" && OnlyCan.Checked; });
     
            Filtres(tags.ToArray());
            SortPanel.SelectedIndex = 0;
            SortPanel.SelectedIndex = 1;
            Print(ref Objects);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Hiding(Objects, SpecialSqlController.Tables.objects);
        }

        private void ClearRows(bool par=false)
        {
            Update.Enabled = par;
            NameText.Enabled = par;
            CostText.Enabled = par;
            CountText.Enabled = false;
            DescriptionText.Enabled = par;
            TypeText.Enabled = par;
            TypeText.Items.Clear();
            NameText.Text = "";
            CostText.Value = 1;
            CountText.Value = 0;
            DescriptionText.Text = "";
            TypeText.Text = "";
        }

        private void CostFrom_ValueChanged(object sender, EventArgs e)
        {
            CostTo.Minimum = CostFrom.Value;
            CostFrom.Maximum = CostTo.Value;
        }

        private void Objects_Click(object sender, EventArgs e)
        {
            if (RowTest(Objects,false) ){
                ClearRows(true);
                foreach (var c in Types)
                {
                    TypeText.Items.Add(c[1]);
                }
                int id = Objects.SelectedRows[0].Index;
                NameText.Text = Objects[1, id].Value.ToString();
                CostText.Value =int.Parse( Objects[3, id].Value.ToString());
              CountText.Value = int.Parse(Objects[4,id].Value.ToString());
                DescriptionText.Text = Objects[5, id].Value.ToString();
                if (!TypeText.Items.Contains(Objects[2, id].Value.ToString()))
                {
                    TypeText.Items.Add(Controller.TakeRow(SpecialSqlController.Tables.objecttype, "`Names`=" + Objects[2, id].Value.ToString()));
                    TypeText.Enabled = false;
                }
            TypeText.SelectedIndex = TypeText.Items.IndexOf(Objects[2, id].Value.ToString());

        }
            else {
                ClearRows();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearRows();
        }

        private void Categoryes_Click(object sender, EventArgs e)
        {
            OpenForm(new Edit(SpecialSqlController.Tables.objecttype));
            Actions();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate ()
            {
                if (NameText.Text.Length < 5) { Error("Слишком короткое название"); return true; }
                else return false;
            });
            tests.Add(delegate ()
            {
                if (TypeText.SelectedIndex<0) { Error("Не выбран тип"); return true; }
                else return false;
            });
            tests.Add(delegate ()
            {
                if (DescriptionText.Text.Length < 10) { Error("Слишком короткое описание"); return true; }
                else return false;
            });

            if (CheckTest(tests.ToArray()))
            {
                Controller.UpdateIn(SpecialSqlController.Tables.objects, new List<string> { NameText.Text, Types.First(x => x[1] == TypeText.Text)[0], CostText.Text, CountText.Text, DescriptionText.Text },Objects[0,Objects.SelectedRows[0].Index].Value.ToString());
                ClearRows();
                Actions();
             
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }
    }
}
