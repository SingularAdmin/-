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
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'mCDataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.mCDataSet1.Category);
            this.CenterToScreen();
            for (int i = 0; i<3; i++)
            {
                quizUserControl quc = new quizUserControl();
                flowLayoutPanel1.Controls.Add(quc);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void addQuizButton_Click_1(object sender, EventArgs e)
        {
            var addQuiz = new AddQuizWUserControl();
            addQuiz.Show();
        }

        private void LogSignbutton_Click_1(object sender, EventArgs e)
        {
            var loginForm = new loginform();
            loginForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        DataTable dtTree = new DataTable();
        private void button4_Click_1(object sender, EventArgs e)
        {
            DBConnect.Initialize();
            DBConnect db = new DBConnect();
            Console.WriteLine(mCDataSet1.Category.ToString());
            treeView1.Nodes.Add("Entertainment");
            treeView1.Nodes[0].Nodes.Add("Video Games");
            treeView1.Nodes[0].Nodes.Add("Television");
            treeView1.Nodes[0].Nodes.Add("Music");
            treeView1.Nodes[0].Nodes.Add("Musicals & Theaters");
            treeView1.Nodes[0].Nodes.Add("Board Games");

            treeView1.Nodes.Add("Science");
            treeView1.Nodes[1].Nodes.Add("Science & Nature");
            treeView1.Nodes[1].Nodes.Add("Mathematics");
            treeView1.Nodes[1].Nodes.Add("History");

            treeView1.Nodes.Add("Books");
            treeView1.Nodes[2].Nodes.Add("Japanese Anime & Manga");
            treeView1.Nodes[2].Nodes.Add("Cartoon & Animations");
            treeView1.Nodes[2].Nodes.Add("Comics");

            treeView1.Nodes.Add("Computers");
            treeView1.Nodes[3].Nodes.Add("Gadgets");
            

            treeView1.Nodes.Add("Politics");
            treeView1.Nodes.Add("Geography");
            treeView1.Nodes.Add("Vehicles");
            treeView1.Nodes.Add("Sports");
            treeView1.Nodes.Add("Celebrities");
            treeView1.Nodes.Add("Animals");
            treeView1.Nodes.Add("Art");
            treeView1.Nodes.Add("Mythology");            
            treeView1.Nodes.Add("General Knoledge");
        }
    }
}
