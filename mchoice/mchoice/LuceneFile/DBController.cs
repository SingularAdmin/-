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

        public MCDataSet.MediaDataTable getMediaFromAID(int answerID) {
            return mAdap.GetMediaFromAID(answerID);
        }

        public MCDataSet.MediaDataTable getMediaFromQID(int questionID) {
            return mAdap.GetMediaFromQID(questionID);
        }

        public MCDataSet.MediaDataTable getQID_MID_Diff(int mediaID) {
            return mAdap.GetQID_AID_Diff(mediaID);
        }
    }
}
