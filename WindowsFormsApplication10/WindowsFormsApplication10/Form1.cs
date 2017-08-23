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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AND b = new AND();
            b.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buffer l = new buffer();
            l.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NOT n = new NOT();
            n.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XNOR n = new XNOR();
            n.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XOR k = new XOR();
            k.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NOR c = new NOR();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OR a = new OR();
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NAND d = new NAND();
            d.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
