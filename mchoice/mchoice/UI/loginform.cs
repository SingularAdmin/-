using System;
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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new signupform();
            newForm.Show();
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.White;
            LoginButton.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.BackColor = Color.FromArgb(255, 128, 0);
            LoginButton.ForeColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            SignupButton.BackColor = Color.White;
            SignupButton.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            SignupButton.BackColor = Color.FromArgb(255, 128, 0);
            SignupButton.ForeColor = Color.White;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            /*
            if ()
            {
                Errorlabel.Text = "Wrong Password";
                
            }

            else */
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            var newForm = new forgetpasswordform();
            newForm.Show();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font.Name, 8.25f, FontStyle.Bold | FontStyle.Underline);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = new Font(label6.Font.Name, 8.25f, FontStyle.Bold);
        }
    }
}
