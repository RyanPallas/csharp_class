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
    public partial class frm_class_and_object : Form
    {
        public frm_class_and_object()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animal_class animal_sound = new animal_class();
            animal_sound.cat_setter("meowww");
            animal_sound.Dog = "wott";
            animal_sound.cow_setter("mooo");
            //MessageBox.Show(animal_sound.cat_getter());
            //MessageBox.Show(animal_sound.Dog);
            animal_class bird_sound = new animal_class("kayli kayli");

        }
    }
    //user create class
   
}
