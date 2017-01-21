using System;
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
        private List<Monster> monsters = new List<Monster>();

        public Form1()
        {
            InitializeComponent();
        }
           
        private void Form1_Load(object sender, EventArgs e)
        {
            addMonster(new Monster("tizio", 200, 100));
            Console.WriteLine(monsters[0].describe());
        }

        private Monster addMonster(Monster m)
        {
            monsters.Add(m);
            return m;
        }

    }
}
