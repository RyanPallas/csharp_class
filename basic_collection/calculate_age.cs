using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection
{
    public partial class calculate_age : Form
    {
        public calculate_age()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c_year = DateTime.Now.Year;
            int c_month = DateTime.Now.Month;
            int c_day = DateTime.Now.Day;
            int my_age;
            string[] dob = textBox1.Text.Split('.');
            if (int.Parse(dob[1]) > c_month)
            {
                my_age = c_year - (int.Parse(dob[2])) - 1;
            }
            else
            { my_age = c_month - (int.Parse(dob[2])); 
            }
            MessageBox.Show($"{my_age}");
        }

        
    }
}
