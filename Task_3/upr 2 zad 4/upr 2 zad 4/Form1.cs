using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upr_2_zad_4
{
    public partial class Form1 : Form
    {
        double a, b, p, sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            p = b - a;
            textBox3.Text = p.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = Double.Parse(textBox2.Text);
            p = b - a;
            textBox3.Text = p.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sum = p * Double.Parse(radioButton1.Text);
            textBox4.Text = sum.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sum = p * Double.Parse(radioButton2.Text);
            textBox4.Text = sum.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sum = p * Double.Parse(radioButton3.Text);
            textBox4.Text = sum.ToString();
        }
    }
}
