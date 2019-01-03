using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mchoice.View
{
    public partial class AddQuizForm : Form
    {
        Form1 parent = null;

        public AddQuizForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "TESTINGG";
            button.Location = new Point(100,200);
            this.panel1.Controls.Add(button);
        }

        public void getParent(Form1 parent)
        {
            this.parent = parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
