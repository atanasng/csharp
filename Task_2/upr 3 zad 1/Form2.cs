using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upr_3_zad_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        double a, b,c;
        private void button1_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);
            c = Math.Pow(a, b);
            textBox3.Text = c.ToString();
        }
    }
}
