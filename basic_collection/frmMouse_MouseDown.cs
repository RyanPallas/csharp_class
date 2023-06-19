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
    public partial class frmMouse_MouseDown : Form
    {
        public frmMouse_MouseDown()
        {
            InitializeComponent();
        }

        private void frmMouse_MouseDown_Load(object sender, EventArgs e)
        { // listener
            this.MouseDown += new MouseEventHandler(this.frmMouse_MouseDown_MouseDown);
            this.MouseMove += new MouseEventHandler(this.frmMouse_MouseDown_MouseMove);


        }

        private void frmMouse_MouseDown_MouseDown(object sender, MouseEventArgs e)
        {
           
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void frmMouse_MouseDown_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }
    }
}
