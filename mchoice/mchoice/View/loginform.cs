using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using mchoice.Control;


namespace mchoice
{
    public partial class loginform : Form
    {
        Form1 parent = null;
        public loginform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.White;
            loginButton.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(255, 128, 0);
            loginButton.ForeColor = Color.White;
        }
        /*
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
        */
        private void LoginButton_Click(object sender, EventArgs e)
        {
            WindowsController.checkLogin(this, parent);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            var newForm = new signupform();
            newForm.Show();
            this.Close();
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void changeBorderColor()
        {
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Red;
        }

        public void getParent(Form1 parent)
        {
            this.parent = parent;
        }

        public string Username
        {
            get
            {
                return usernameText.Text;
            }

            set
            {
                usernameText.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return passwordText.Text;
            }

            set
            {
                passwordText.Text = value;
            }
        }
    }
}
