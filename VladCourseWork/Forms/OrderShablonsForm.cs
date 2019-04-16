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
    public partial class OrderShablonForm : MainController
    {
        public OrderShablonForm() : base()
        {
            InitializeComponent();
            Actions();
            Personalization();
        }

        public override void MainAction()
        {
            GetData(SpecialSqlController.Tables.shablons, delegate (ref List<Dictionary<string, string>> data)
            {
                for (int g = 0; g < data.Count; g++)
                {
                    List<Dictionary<string, string>> ing = Controller.GetAllFromWithNames(SpecialSqlController.Tables.shablonlist, "`Shablon`=" + data[g]["Id"]);
                    string result = "";
                    foreach (var i in ing)
                    {
                        result += Controller.TakeRow(SpecialSqlController.Tables.objects, "Id=" + i["Objects"])[1] + " - " + i["Count"]+"; ";
                    }
                    data[g].Add("Objects", result);
                }
            });
        }

        public override void Actions()
        {

            IngredientsFiltr.Items.Clear();
            List<List<string>> prod = Controller.GetAllFrom(SpecialSqlController.Tables.objects);
            foreach (var p in prod)
                IngredientsFiltr.Items.Add(p[1]);
            NameText.Text = "";

            MainAction();
            SortPanel.DropDownStyle = ComboBoxStyle.DropDownList;
            SortPanel.SelectedIndex = 1;
            SortPanel.SelectedIndex = 3;
            Print(ref Shablons);
        }

        private void Add_Click(object sender, EventArgs e)
        {
           OpenForm( new AddShablons());
            Actions();
        }

        private void SortPanel_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (SortPanel.SelectedIndex)
            {
                case 0:
                    Sort("Names", -1);
                    break;
                case 1:
                    Sort("Names", 1);
                    break;

            }
            Print(ref Shablons);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           Hiding(Shablons, SpecialSqlController.Tables.shablons);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (RowTest(Shablons))
            {
                string id = GetId(Shablons);
               OpenForm(new AddShablons(Controller.TakeRowWithNamesById(SpecialSqlController.Tables.shablons, Convert.ToInt32(id))));
                Actions();
            }
        }


        private void Filtr_Click(object sender, EventArgs e)
        {
            List<FiltrTag> tags = new List<FiltrTag>();
            tags.Add(delegate (Dictionary<string, string> row) {
                return NameText.Text.Length > 0 && !row["Names"].ToLower().Replace(" ", "").Contains(NameText.Text.ToLower().Replace(" ", ""));
            });
        tags.Add(delegate (Dictionary<string, string> row) {

                for (int i = 0; i < IngredientsFiltr.CheckedItems.Count; i++)
                    if (!row["Objects"].ToLower().Contains(IngredientsFiltr.CheckedItems[i].ToString().ToLower()))
                        return true;
                    return false;
            });
            Filtres(tags.ToArray());
            SortPanel.SelectedIndex = 1;
            SortPanel.SelectedIndex = 3;
            Print(ref Shablons);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Actions();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
