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
    public partial class testMainForm : Form
    {
        public testMainForm()
        {
            InitializeComponent();
        }

        private void addQuizButton_Click(object sender, EventArgs e)
        {
            var qForm = new AddQuizWUserControl();
            qForm.Show();
        }

    }
}
