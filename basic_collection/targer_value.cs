using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection
{
    public partial class targer_value : Form
    {
        public targer_value()
        {
            InitializeComponent();
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            //int j = 1;
            //label1.Text = "";
            //while (j <= 5)
            //{
            //    int i = 1;

            //    while (i <= 5)
            //    {

            //        label1.Text += "*";
            //        i++;
            //    }
            //    label1.Text += "\n";
            //    j++;
            //}

            //label1.Text = "";
            //int j = 5;
            //while (j>= 1)
            //{
            //    int i = 1;
            //    while (i<= j)
            //    {
            //        label1.Text += $"{i}";
            //        i++;
            //    }
            //    label1.Text += "\n";
            //    j--;
            //}
            if (textBox1.Text != "ggez");
            {
                count++;
                MessageBox.Show("reenter");
                if (count == 5)
                {
                    MessageBox.Show("wait 5 sec");
                    count = 0;
                }
            }

           
        }

        private void targer_value_Load(object sender, EventArgs e)
        {
            
        }
    }
}
