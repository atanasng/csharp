﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bikes
{
    public partial class Form1 : Form
    {
        Broker b = new Broker();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.ModelID1 = textBox1.Text;
            p.VersionID1 = textBox2.Text;
            p.Price1 = textBox3.Text;
            p.Note1 = textBox4.Text;
            b.Insert(p);

        }
    }
}
