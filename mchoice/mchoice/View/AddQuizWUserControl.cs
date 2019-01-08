using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mchoice.Controls;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace mchoice.View
{
    public partial class AddQuizWUserControl : Form
    {
        public AddQuizWUserControl()
        {
            InitializeComponent();
        }

        public static MultipleChoice uc = new MultipleChoice();

        int qNumber = 0;
        private void userControlTst_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(uc);
            qNumber++;
            checkLabel();
        }

        public int maxQs = 1;
        private void removeLastButton_Click(object sender, EventArgs e)
        {
            qNumber--;
            if (qNumber == 1)
                removeLastButton.Enabled = false;
            if (qNumber <= maxQs)
                CreateQuizButton.Enabled = false;
            flowLayoutPanel1.Controls.RemoveAt(qNumber);            
            checkLabel();
            //Console.WriteLine(qNumber);
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            MultipleChoice uc = new MultipleChoice();
            uc.Tag = qNumber;
            if (checkMChoice(qNumber-1) == true)
            {
                qNumber++;
                flowLayoutPanel1.Controls.Add(uc);
                if (qNumber > 0)
                    removeLastButton.Enabled = true;
                if (qNumber >= maxQs)
                    CreateQuizButton.Enabled = true;
                checkLabel();
            }
        }

        private void createQuizButton_Click(object sender, EventArgs e)
        {
            //bool print = false;
            bool flag = false;
            for (int i = 0; i < qNumber; i++)
            {
                if (checkMChoice(i) == true)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if(flag == true)
            {
                for (int i = 0; i < qNumber; i++)
                {
                    string q = ((MultipleChoice)flowLayoutPanel1.Controls[i]).qTitle;
                    string a = ((MultipleChoice)flowLayoutPanel1.Controls[i]).qAnswer;
                    Console.WriteLine("({0}) Question: {1} \nAnswer: {2}", i + 1, q, a);
                    //print = true;
                    printButton.Enabled = true;
                }
            }
        }

        public bool checkMChoice(int pos)
        {
            string q = ((MultipleChoice)flowLayoutPanel1.Controls[pos]).qTitle;
            string a = ((MultipleChoice)flowLayoutPanel1.Controls[pos]).qAnswer;
            bool flag = true;
            if (a == "")
            {
                MessageBox.Show("Please fill up all the answer textfields and check the right one at " + (pos + 1) + " Question");
                flag = false;
            }
            if (q == "")
            {
                MessageBox.Show("Please fill up the title at " + (pos + 1) + " Question");
                flag = false;
            }
            return flag;
        }

        public void checkLabel()
        {
            if (qNumber > 0)
            {
                label1.Visible = true;
                label1.Text = "You need : " + (maxQs - qNumber) + " more questions";
            }                

            if (maxQs - qNumber <= 0)
                label1.Visible = false;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();

            // Sample uses DIN A4, page height is 29.7 cm. We use margins of 2.5 cm.
            LayoutHelper helper = new LayoutHelper(document, XUnit.FromCentimeter(2.5), XUnit.FromCentimeter(29.7 - 2.5));
            XUnit left = XUnit.FromCentimeter(2.5);

            // Random generator with seed value, so created document will always be the same.
            Random rand = new Random(42);

            

            const int headerFontSize = 15;
            const int normalFontSize = 10;

            XFont fontHeader = new XFont("Verdana", headerFontSize, XFontStyle.BoldItalic);
            XFont fontNormal = new XFont("Verdana", normalFontSize, XFontStyle.Regular);

            int totalLines = qNumber*2;
            bool washeader = false;
            for (int line = 0; line < totalLines; ++line)
            {
                string q = ((MultipleChoice)flowLayoutPanel1.Controls[line/2]).qTitle;
                string a = ((MultipleChoice)flowLayoutPanel1.Controls[line/2]).qAnswer;
                bool isHeader = line == 0 || !washeader && line < totalLines - 1 && rand.Next(0) == 0;
                washeader = isHeader;
                // We do not want a single header at the bottom of the page, so if we have a header we require space for header and a normal text line.
                XUnit top = helper.GetLinePosition(isHeader ? headerFontSize + 3 : normalFontSize + 2, isHeader ? headerFontSize + 3 + normalFontSize : normalFontSize);

                helper.Gfx.DrawString(isHeader ? "Question #"+((line/2)+1)+": "+q : "Correct answer: " +a,
                    isHeader ? fontHeader : fontNormal, XBrushes.Black, left, top, XStringFormats.TopLeft);
            }

            // Save the document... 
            const string filename = "MultiplePages.pdf";
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }
    }

    internal class LayoutHelper
    {
        private readonly PdfDocument _document;
        private readonly XUnit _topPosition;
        private readonly XUnit _bottomMargin;
        private XUnit _currentPosition;

        public LayoutHelper(PdfDocument document, XUnit topPosition, XUnit bottomMargin)
        {
            _document = document;
            _topPosition = topPosition;
            _bottomMargin = bottomMargin;
            // Set a value outside the page - a new page will be created on the first request.
            _currentPosition = bottomMargin + 10000;
        }

        public XUnit GetLinePosition(XUnit requestedHeight)
        {
            return GetLinePosition(requestedHeight, -1f);
        }

        public XUnit GetLinePosition(XUnit requestedHeight, XUnit requiredHeight)
        {
            XUnit required = requiredHeight == -1f ? requestedHeight : requiredHeight;
            if (_currentPosition + required > _bottomMargin)
                CreatePage();
            XUnit result = _currentPosition;
            _currentPosition += requestedHeight;
            return result;
        }

        public XGraphics Gfx { get; private set; }
        public PdfPage Page { get; private set; }

        void CreatePage()
        {
            Page = _document.AddPage();
            Page.Size = PageSize.A4;
            Gfx = XGraphics.FromPdfPage(Page);
            _currentPosition = _topPosition;
        }
    }
}