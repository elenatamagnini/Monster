﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestClassi
{
    public partial class Form1 : Form
    {
        private List<Monster> monsters;

        public Form1()
        {
            InitializeComponent();
            monsters = Deserializer.deserializeMonsters();

            /*foreach (Monster m in monsters)
            {
                Console.WriteLine(m.GetType());
                if (m.GetType() == typeof(Fire_Monster))
                {
                    Fire_Monster f = m as Fire_Monster;
                    Console.WriteLine(f.fireDamage);
                }
                //Console.WriteLine(m.fire);
            }*/
        }

        public string[] fileEntries; 
        public int indice;

        private void Form1_Load(object sender, EventArgs e)
        {
             fileEntries = Directory.GetFiles(@"..\..\assets\images\");

         
            if (fileEntries.Count() > 0)
            {
                pictureBox1.Load(fileEntries[0]);
               
                indice = 0; 
            }
        }

        private Monster addMonster(Monster m)
        {
            monsters.Add(m);
            return m;
        }

       


        }
    }


