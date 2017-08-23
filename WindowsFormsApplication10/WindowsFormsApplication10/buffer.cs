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
    public partial class buffer : Form
    {
        public buffer()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                opened.Visible = true;
                closed.Visible = false;
            }
            else
            {
                opened.Visible = false;
                closed.Visible = true;
            }
        }
    }
}
