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
    public partial class AddQuizForm : Form
    {
        Form1 parent = null;
        List<Button> buttons;
        List<Panel> panels;

        public AddQuizForm()
        {
            InitializeComponent();
            hideAtStart();
        }

        private void hideAtStart()
        {
            buttons = tableLayoutPanel1.Controls.OfType<Button>().ToList();
            buttons.Reverse();
            panels = mainPanel.Controls.OfType<Panel>().ToList();
            panels.Remove(tableLayoutPanel1);
            panels.Reverse();

            Console.WriteLine("Number of Buttons " + buttons.Count);
            Console.WriteLine("Number of Panels " + panels.Count);
            for (int i =0; i < buttons.Count; i++)
            {
                buttons[i].Visible = false;
                Console.WriteLine(buttons[i].Name);
            }
            for (int i = 1; i < panels.Count; i++)
            {
                panels[i].Visible = false;
                Console.WriteLine( panels[i].Name);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "TESTINGG";
            button.Location = new Point(100,200);
            this.mainPanel.Controls.Add(button);
        }

        public void getParent(Form1 parent)
        {
            this.parent = parent;
        }

        int countPages = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if ( countPages == 0)
            {
                buttons[0].Visible = true;
                buttons[1].Visible = true;
                countPages = 2;

                panel2.Location = new Point(150, 59);
                panel2.Visible = true;
            }
            else if( countPages < 10)
            {
                buttons[countPages].Visible = true;

                panels[countPages].Location = new Point(150, 59);
                panels[countPages].Visible = true;
                panels[countPages].BringToFront();

                countPages++;
            }
            else
            {
                string messageBoxText = "A quiz can contain only up to 30 questions!";
                string caption = "Oups";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(messageBoxText, caption, button);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            panel3.BringToFront();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            panel4.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel6.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel7.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel8.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel9.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel10.BringToFront();
        }

        private void LogSignbutton_Click(object sender, EventArgs e)
        {
            var newForm = new loginform();
            newForm.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddQuizForm_Load(object sender, EventArgs e)
        {

        }

        private void createQuizButton_Click(object sender, EventArgs e)
        {

        }
    }
}
