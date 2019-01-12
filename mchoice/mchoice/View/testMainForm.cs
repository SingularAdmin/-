using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mchoice.LuceneFile;
using mchoice.Controls;

namespace mchoice.View
{
    public partial class testMainForm : Form
    {
        public testMainForm()
        {
            InitializeComponent();
        }

        public static quizUserControl quizUserControl = new quizUserControl();

        private void addQuizButton_Click(object sender, EventArgs e)
        {
            var qForm = new AddQuizWUserControl();
            qForm.Show();
        }

        private void LogSignbutton_Click(object sender, EventArgs e)
        {
            var logForm = new loginform();
            logForm.Show();
        }

        private void SearchBox_MouseClick(object sender, MouseEventArgs e)
        {
            LuceneInit lucene = new LuceneInit();
            IEnumerable<SampleDataFileRow> results = lucene.Search(this.Text);
        }

        private void testMainForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<3; i++)
            {
                quizUserControl quc = new quizUserControl();
                flowLayoutPanel1.Controls.Add(quc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
