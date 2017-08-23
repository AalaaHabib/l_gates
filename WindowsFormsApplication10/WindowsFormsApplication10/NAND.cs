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
    public partial class NAND : Form
    {
        public NAND()
        {
            InitializeComponent();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true && checkBox6.Checked == true)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
            else if (checkBox5.Checked == false && checkBox6.Checked == true)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
            else if (checkBox5.Checked == true && checkBox6.Checked == false)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
            else if (checkBox5.Checked == false && checkBox6.Checked == false)
            {
                opened.Visible = true;
                closed.Visible = false;
            }


        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true && checkBox6.Checked == true)
            {
                opened.Visible = false;
                closed.Visible = true;
            }
            else if (checkBox5.Checked == false && checkBox6.Checked == true)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
            else if (checkBox5.Checked == true && checkBox6.Checked == false)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
            else if (checkBox5.Checked == false && checkBox6.Checked == false)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
        }
    }
}
