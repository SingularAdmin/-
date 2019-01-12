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
using mchoice.LuceneFile;
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

        private void addQuizButton_Click(object sender, EventArgs e)
        {
            WindowsController.showAddQuizWindow(this);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void takeQuiz()
        {
            WindowsController.showQuizForm(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            takeQuiz();
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            takeQuiz();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            takeQuiz();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addQuizButton.Visible = false;
            //if (logedIn)
            //addQuizButton.Visible = true;
        }

        private void searchButton_MouseClick(object sender, MouseEventArgs e)
        {
            LuceneInit lucene = new LuceneInit();
            IEnumerable<SampleDataFileRow> results = lucene.Search(this.Text);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
