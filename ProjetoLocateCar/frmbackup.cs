﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLocateCar
{
    public partial class frmbackup : Form
    {
        public frmbackup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(5);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.timer1.Start();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
