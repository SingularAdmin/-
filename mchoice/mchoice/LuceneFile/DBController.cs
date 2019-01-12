using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mchoice.LuceneFile
{
    public class DBController
    {
        private MCDataSet.MediaDataTable mrow;
        private MCDataSetTableAdapters.MediaTableAdapter mAdap;
        
        public DBController()
        {
            mrow = new MCDataSet.MediaDataTable();
            mAdap = new MCDataSetTableAdapters.MediaTableAdapter();

        }

        public MCDataSet.MediaDataTable getMedia()
        {
            return mAdap.GetMediaQ();
        }

    }
}
