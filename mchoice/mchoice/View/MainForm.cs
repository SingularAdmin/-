using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mchoice.Control;

namespace mchoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;
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
            this.Hide();
            WindowsController.showLogInWindow(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void setValueAtSearchBOx(string value)
        {
            SearchBox.Text = value;
        }

        public void userLoggedIn(string username)
        {
            LogSignbutton.Text = "Welcome " + username;
            LogSignbutton.Enabled = false;
            addQuizButton.Visible = true;
        }
    }
}
