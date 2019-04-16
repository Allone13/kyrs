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
    public partial class MainMenu : MainController
    {
        public MainMenu()
        {
            InitializeComponent();
            Personalization();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new CheckCreateForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm(new ObjectForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm(new OrderShablonForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenForm(new OrdersForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenForm(new EmployeersForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm(new AddObject());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerForm());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenForm(new StatisticForm());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
