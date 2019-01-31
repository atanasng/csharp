using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upr_2_zad_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double CalculateCelsius(double fahreinheit)
        {
            return (fahreinheit-32)/5/9;
        }

        private static double CalculateFahreinheit(double celsius)
        {
            return (celsius*1.8)+32;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Celcius")
            {
                textBox2.Text = CalculateCelsius(Double.Parse(textBox1.Text)).ToString();
            }
            else if (comboBox1.Text == "Fahrenheit")
            {
                textBox2.Text = CalculateFahreinheit(Double.Parse(textBox1.Text)).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
