using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class AND : Form
    {
        public AND()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true && checkBox4.Checked == true)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
            else if (checkBox3.Checked == false && checkBox4.Checked == true)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
            else if (checkBox3.Checked == true && checkBox4.Checked == false)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
            else if (checkBox3.Checked == false && checkBox4.Checked == false)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true && checkBox4.Checked == true)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
            else if (checkBox3.Checked == false && checkBox4.Checked == true)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
            else if (checkBox3.Checked == true && checkBox4.Checked == false)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
            else if (checkBox3.Checked == false && checkBox4.Checked == false)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
        }
    }
}
