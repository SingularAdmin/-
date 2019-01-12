using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using mchoice.View;
using mchoice.LuceneFile;

namespace mchoice
{
    static class Program
    {
        /// this is a comment made using VS
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //initialise Lucene
            LuceneInit luIn = new LuceneInit();
            SampleDataFileReader fileReader = new SampleDataFileReader();
            IEnumerable<SampleDataFileRow> row = fileReader.ReadAllRowsDB();
            luIn.BuildIndex(row);


            ////
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AddQuizWUserControl());


        }
    }
}
