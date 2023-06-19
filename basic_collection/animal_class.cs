using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_collection
{
    public class animal_class
    {
        public animal_class() 
        {
            MessageBox.Show("default constructor");
        }

        public animal_class(string bird)
        {
            MessageBox.Show(bird);
        }
        string cat = "meow";
        string dog = "wot";
        string cow = "moo";
        public string cat_getter()
        {
            return cat;
        }
        public string dog_getter()
        {
            return dog;
        }
        public string cow_getter()
        {
            return cow;
        }
        public void cat_setter(string c)
        {
            cat = c;
        }
        public void dog_setter(string d)
        {
            dog = d;
        }
        public void cow_setter(string co)
        {
            cow = co;
        }
        public string Dog
        {
            get { return dog; }
            set { dog = value; }
        }
        public string Cow
        {
            get { return cow; }
            set { cow = value; }
        }

    }
}
