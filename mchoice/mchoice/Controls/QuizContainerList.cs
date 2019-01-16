using mchoice.LuceneFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mchoice.Controls
{
    class QuizContainerList 
    {
        private List<quizUserControl> userCList;

        public QuizContainerList()
        {
            userCList = new List<quizUserControl>();
        }

        public List<quizUserControl> getQuizList(List<SampleDataFileRow> results) {
            

            SampleDataFileRow sample = new SampleDataFileRow();
            foreach (SampleDataFileRow m in results) {
                //System.Diagnostics.Debug.WriteLine(m.Id);
                quizUserControl quc = new quizUserControl
                {
                Title = getcontent(m.LineNumber)[0].Value,
                description = getcontent(m.LineNumber)[1].Value,
                rating = getcontent(m.LineNumber)[2].Value
                 };
                userCList.Add(quc);
            }
            
            return userCList;
        }

        private List<KeyValuePair<string,String>> getcontent(int id) { // media id to question content
            DBController db = new DBController();
            MCDataSet.MediaDataTable mdt = db.getQID_MID_Diff(id);
            System.Diagnostics.Debug.WriteLine(mdt.Rows[0]["questionID"].ToString());

            // Int32 qid = (Int32) mdt.Rows[0]["questionID"];
            // Int32 aid = (Int32) mdt.Rows[0]["answerID"];

            //  MCDataSet.MediaDataTable qlink = db.getMediaFromQID(qid);

            //mdt.Rows[0].Table.Columns["link"].DefaultValue.ToString();
            //mdt.Rows[0].Table.Columns["rating"].DefaultValue.ToString();

            List<KeyValuePair<string, String>> cont = new List<KeyValuePair<string, String>>() {
                new KeyValuePair<string, string>("title","default"),
                new KeyValuePair<string, string>("description", "default"),
                new KeyValuePair<string, string>("rating", "default"),
        }; 
            return cont;
        }
    }
}
