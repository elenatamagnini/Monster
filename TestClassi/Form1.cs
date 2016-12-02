﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClassi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           
        private void Form1_Load(object sender, EventArgs e)
        {
            Monster strongbonna = new Monster("Strongbonna", 100, 20);
            Monster charmender = new Monster("Charmender", 60, 20, 10);

            strongbonna.attack(charmender);
            charmender.attack(strongbonna);
            strongbonna.heal();
            charmender.heal(strongbonna);
            strongbonna.attack(charmender);
            strongbonna.attack(charmender);
        }
    }
}
