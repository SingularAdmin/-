﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mchoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            LogSignbutton.BackColor = Color.White;
            LogSignbutton.ForeColor = Color.FromArgb(255,128,0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            LogSignbutton.BackColor = Color.FromArgb(255, 128, 0);
            LogSignbutton.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new loginform();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newForm = new quizform();
            newForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
