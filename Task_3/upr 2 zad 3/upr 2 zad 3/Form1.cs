using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upr_2_zad_3
{
    public partial class Form1 : Form
    {
        double[,] Koef = new double[4, 4];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ((double.Parse(textBox1.Text) *
                Koef[comboBox1.SelectedIndex, comboBox2.SelectedIndex])).ToString();
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    label4.Text = "feet:";
                    break;
                case 1:
                    label4.Text = "yards:";
                    break;
                case 2:
                    label4.Text = "inches:";
                    break;
                case 3:
                    label4.Text = "miles:";
                    break;
                default:
                    label4.Text = "Result:";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox2.Text = "";
            textBox1.Text = 0.ToString();
            Koef[0, 0] = 1;
            Koef[0, 1] = 0.3333;
            Koef[0, 2] = 1.1989;
            Koef[0, 3] = 0.0001893;
            Koef[1, 0] = 3;
            Koef[1, 1] = 1;
            Koef[1, 2] = 3.5966;
            Koef[1, 3] = 0.0005682;
            Koef[2, 0] = 0.8341;
            Koef[2, 1] = 0.278;
            Koef[2, 2] = 1;
            Koef[2, 3] = 0.0001579;
            Koef[3, 0] = 5280;
            Koef[3, 1] = 1760;
            Koef[3, 2] = 6330;
            Koef[3, 3] = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox2.Text = "";
            textBox1.Text = 0.ToString();
        }
    }
}
