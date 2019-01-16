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
    public partial class signupform : Form
    {
        public signupform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new loginform();
            newForm.Show();

            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            SignupButton.BackColor = Color.White;
            SignupButton.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            SignupButton.BackColor = Color.FromArgb(255, 128, 0);
            SignupButton.ForeColor = Color.White;
        }

        private void signupform_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
