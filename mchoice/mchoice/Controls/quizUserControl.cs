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

        public string Title
        {
            get
            {
                return titleL.Text;
            }
            set
            {
                titleL.Text = value;
            }
        }

        public string rating
        {
            get
            {
                return ratingL.Text;
            }
            set
            {
                ratingL.Text = value;
            }
        }

        public string description
        {
            get
            {
                return descriptionL.Text;
            }
            set
            {
                descriptionL.Text = value;
            }
        }


    }
}