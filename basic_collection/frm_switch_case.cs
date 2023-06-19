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
    public partial class frm_switch_case : Form
    {
        public frm_switch_case()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            //switch (data)
            //{
            //    case "1":
            //        MessageBox.Show("case 1");
            //        break;
            //    case "2":
            //        MessageBox.Show("case 2");
            //        break;
            //    default:
            //        MessageBox.Show("default");
            //        break;
            //}

            switch (data)
            {
                case "5":
                    for (int i = 1; i <= 13; i++)
                    {
                        richTextBox1.Text += $"5 * {i} = {5 * i}\n";
                    }
                    break;
                default:
                    MessageBox.Show("default");
                    break;


            }
        }
    }
}
