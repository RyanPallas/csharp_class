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
    public partial class frm_pot : Form
    {
        public frm_pot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;
            
            
            int num1_index = num1.Length - 1;
            int num2_index = num2.Length - 1;
           
            int power1 = int.Parse((num1)[num1_index].ToString());
            //MessageBox.Show($"{power1}");
            int power2 = int.Parse((num2)[num2_index].ToString());
            string base1 = "";
            string base2 = "";
            int c_base1, c_base2;
           
            
            for (int i = 0; i <= num1_index-1; i++)
            {
                base1 += num1[i];

            }
            //MessageBox.Show(base1);
            for (int i = 0; i <= num2_index - 1; i++)
            {
                base2 += num2[i];

            }
            c_base1 = int.Parse(base1);
            c_base2 = int.Parse(base2);
            int first_num = (int)Math.Pow(c_base1, power1);
            int sec_num = (int)Math.Pow(c_base2, power2);
            int sum = first_num + sec_num;
            MessageBox.Show($"{sum}");


        }
    }
}
