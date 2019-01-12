using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mchoice.View;

namespace mchoice.Controls
{
    public partial class quizUserControl : UserControl
    {
        public quizUserControl()
        {
            InitializeComponent();
        }

        public string quiz
        {
            get
            {
                return label1.Text;
            }
        }

        private void quizUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}