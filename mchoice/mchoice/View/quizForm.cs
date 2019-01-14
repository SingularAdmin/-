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
    public partial class quizForm : Form
    {
        Form1 parent = null;
        public quizForm()
        {
            InitializeComponent();
            
        }

        private void quizForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        public void getParent(Form1 parent)
        {
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tstForm = new testForm();
            this.Visible = false;
            tstForm.Show();
        }
    }
}
