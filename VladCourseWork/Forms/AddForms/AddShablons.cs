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
    public partial class AddShablons :MainController
    {
        List<string> ProductList;
        List<Dictionary<string, string>> ProductSelectedList;
        int Id;
        public AddShablons():base()
        {
            InitializeComponent();
            Personalization();
            Id = 0;

            ProductList = new List<string>();
            Product.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductSelectedList = new List<Dictionary<string, string>>();
            Delete.Enabled = false;
            List<List<string>> pr = Controller.GetAllFrom(SpecialSqlController.Tables.objects, "Enable=1");
            foreach (var p in pr)
            {
                ProductList.Add(p[1]);
            }
            Product.Items.AddRange(ProductList.ToArray());
            AddIng.Enabled = false;
            Actions();
        }

        public AddShablons(Dictionary<string,string> info):base()
        {
            InitializeComponent();
            Personalization();
            this.Text = Add.Text = "Изменить";
            Actions();
            Id = Convert.ToInt32(info["Id"]);
            DishName.Text = info["Names"];
           Description.Text = info["Description"];
            ProductList = new List<string>();
            Product.DropDownStyle= ComboBoxStyle.DropDownList;
            ProductSelectedList = new List<Dictionary<string, string>>();
            List<List<string>> pr = Controller.GetAllFrom(SpecialSqlController.Tables.objects, "Enable=1");
            Delete.Enabled = false;
            string where = "`Shablon`=" + info["Id"];

            List<List<string>> ing = Controller.GetAllFrom(SpecialSqlController.Tables.shablonlist, where);
            foreach (var p in pr)
            {
                if (ing.Where(x => Int32.Parse(x[1]) == Int32.Parse(p[0])).Count() == 0)
                    ProductList.Add(p[1]);
                else
                {
                    Dictionary<string, string> line = new Dictionary<string, string>();
                    line.Add("Id", p[0]);
                    line.Add("Names", p[1]);
                    line.Add("Count", ing.Where(x => Int32.Parse(x[1]) == Int32.Parse(p[0])).First()[2]);
                    ProductSelectedList.Add(line);
                }
            }
            PrintSeleceted();
            Product.Items.AddRange(ProductList.ToArray());
            AddIng.Enabled = false;
        }
        public override void  Actions()
        {
        }

        void PrintSeleceted()
        {
            Ingredients.Items.Clear();
            foreach (var s in ProductSelectedList)
            {
                Ingredients.Items.Add(s["Names"] + " - " + s["Count"]);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<TestValid> tests = new List<TestValid>();
            tests.Add(delegate () { if (DishName.Text.Length < 1) { Error("Не правильно введено название"); return true; }; return false; });
            tests.Add(delegate () { if (Description.Text.Length < 3) { Error("Описание не добавлено"); return true; }; return false; });
            tests.Add(delegate () { if (ProductSelectedList.Count == 0) { Error("Ингредиенты не добавлены"); return true; }; return false; });
            if (CheckTest(tests.ToArray()))
            {
                if (Id == 0)
                {
                     Controller.InsertInMenu(SpecialSqlController.Tables.shablons, new List<string> { DishName.Text, Description.Text}, ProductSelectedList);
                }
                else
                {
                          Controller.UpdateMenu(SpecialSqlController.Tables.shablons, Id.ToString(), new List<string> { DishName.Text, Description.Text}, ProductSelectedList);
                }
                this.Close();
            }
        }


        private void AddIng_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> line = new Dictionary<string, string>();
            List<string> p = Controller.TakeRow(SpecialSqlController.Tables.objects, "`Names`='" + Product.Text + "'");
            line.Add("Id", p[0]);
            line.Add("Names", p[1]);
            line.Add("Count", Count.Value.ToString());
            ProductSelectedList.Add(line);
            Product.Items.RemoveAt(Product.SelectedIndex);
            Product.Text = "";
            AddIng.Enabled = false;
            PrintSeleceted();
            Count.Value = 1;
        }

        private void Ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ingredients.SelectedIndex > -1)
                Delete.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete.Enabled = false;
            Product.Items.Add(ProductSelectedList[Ingredients.SelectedIndex]["Names"]);
            ProductSelectedList.RemoveAt(Ingredients.SelectedIndex);
            PrintSeleceted();
        }

        private void Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Product.SelectedIndex >= 0)
                AddIng.Enabled = true;
        }
    }
}
