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
           // initialise Lucene
           
            LuceneInit luIn = new LuceneInit(true);
            SampleDataFileReader fileReader = new SampleDataFileReader();
            IEnumerable<SampleDataFileRow> row = fileReader.ReadAllRowsDB();
            /*
            foreach (SampleDataFileRow i in row) {
                System.Diagnostics.Debug.WriteLine("debug: " + i.LineText+i.LineNumber+" id: "+i.Id);
            }
            */
            luIn.BuildIndex(row);
            

            ////
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
