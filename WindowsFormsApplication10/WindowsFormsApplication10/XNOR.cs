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
    public partial class XNOR : Form
    {
        public XNOR()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
        }
    }
}
