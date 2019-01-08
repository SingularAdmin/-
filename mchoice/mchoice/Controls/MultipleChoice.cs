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
    public partial class MultipleChoice : UserControl
    {
        public MultipleChoice()
        {
            InitializeComponent();
        }

        public string qTitle
        {
            get
            {
                return questionTitle.Text;
            }
        }

        public string qAnswer
        {
            get
            {
                return answer;
            }
        }

        private void MultipleChoice_Load(object sender, EventArgs e)
        {
            initRadio();
        }

        private void initRadio()
        {
            radioButton1.CheckedChanged += radioButtons_CheckedChanged;
            radioButton2.CheckedChanged += radioButtons_CheckedChanged;
            radioButton3.CheckedChanged += radioButtons_CheckedChanged;
            radioButton4.CheckedChanged += radioButtons_CheckedChanged;
        }
        public string answer = "";
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            // Do stuff only if the radio button is checked (or the action will run twice).
            if (((RadioButton)sender).Checked)
            {
                int n = 0;
                if (((RadioButton)sender) == radioButton1)
                {
                    n = Convert.ToInt32(radioButton1.Tag);
                }
                else if (((RadioButton)sender) == radioButton2)
                {
                    n = Convert.ToInt32(radioButton2.Tag);
                }
                else if (((RadioButton)sender) == radioButton3)
                {
                    n = Convert.ToInt32(radioButton3.Tag);
                }
                else if (((RadioButton)sender) == radioButton4)
                {
                    n = Convert.ToInt32(radioButton4.Tag);
                }
                foreach (Control control in this.panel1.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox text = control as TextBox;
                        if (Convert.ToInt32(text.Tag) == n)
                        {                            
                            answer = text.Text;
                        }
                    }
                }
            }
        }
    }
}
