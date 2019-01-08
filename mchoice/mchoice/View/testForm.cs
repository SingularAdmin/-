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
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();

            // This integer variable keeps track of the 
            // remaining time.
            
        }
        int timeLeft;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timerLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timerLabel.Text = "Time's up!";
                panel1.BackColor = Color.Red;
                MessageBox.Show("You didn't finish in time.", "Sorry!");
            }
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            timeLeft = 600;
            timer1.Start();
            previousButton.Enabled = false;
        }

        int page = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            page++;
            if (page > 0)
                previousButton.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
