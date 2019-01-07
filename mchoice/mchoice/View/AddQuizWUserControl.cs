using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mchoice.Controls;

namespace mchoice.View
{
    public partial class AddQuizWUserControl : Form
    {
        public AddQuizWUserControl()
        {
            InitializeComponent();
        }

        public static UserControl1 uc = new UserControl1();

        int tag = 0;
        private void userControlTst_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(uc);
            tag++;
            checkLabel();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            UserControl1 uc = new UserControl1();
            uc.Tag = tag;
            tag++;
            flowLayoutPanel1.Controls.Add(uc);
            if (tag > 0)
                removeLastButton.Enabled = true;
            if (tag >= 15)
                CreateQuizButton.Enabled = true;
            checkLabel();
            Console.WriteLine(tag);
        }

        private void removeLastButton_Click(object sender, EventArgs e)
        {
            tag--;
            if (tag == 1)
                removeLastButton.Enabled = false;
            if (tag <= 15)
                CreateQuizButton.Enabled = false;
            flowLayoutPanel1.Controls.RemoveAt(tag);            
            checkLabel();
            Console.WriteLine(tag);
        }

        private void createQuizButton_Click(object sender, EventArgs e)
        {
        }

        public void checkLabel()
        {
            if (tag > 0)
            {
                label1.Visible = true;
                label1.Text = "You need : " + (15 - tag) + " more questions";
            }                

            if (15 - tag == 0)
                label1.Visible = false;
        }
    }
}