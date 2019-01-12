using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Lucene;


namespace mchoice.LuceneFile
{
    public class LuceneInit
    {
        private Analyzer analyzer = new WhitespaceAnalyzer();
        private Lucene.Net.Store.Directory luceneIndexDirectory;
        private IndexWriter writer;
        private string indexPath = @"c:\temp\LuceneIndex";

        public LuceneInit()
        {
            InitialiseLucene();
        }


        private void InitialiseLucene()
        {
            if (System.IO.Directory.Exists(indexPath))
            {
                System.IO.Directory.Delete(indexPath, true);
            }

            luceneIndexDirectory = FSDirectory.Open(indexPath);
            writer = new IndexWriter(luceneIndexDirectory, analyzer, true, IndexWriter.MaxFieldLength.LIMITED);
        }

        public void BuildIndex(IEnumerable<SampleDataFileRow> dataToIndex)
        {
            foreach (var sampleDataFileRow in dataToIndex)
            {
                Document doc = new Document();
                doc.Add(new Field("LineNumber",
                sampleDataFileRow.LineNumber.ToString(),
                Field.Store.YES,
                Field.Index.NOT_ANALYZED));
                doc.Add(new Field("LineText",
                sampleDataFileRow.LineText,
                Field.Store.YES,
                Field.Index.ANALYZED));
                writer.AddDocument(doc);
            }
            writer.Optimize();
            //writer.Commit();
            writer.Dispose();
        }

        public List<SampleDataFileRow> Search(string searchTerm)
        {
            IndexSearcher searcher = new IndexSearcher(luceneIndexDirectory);
            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "LineText", analyzer);

            Query query = parser.Parse(searchTerm);


            TopDocs topDocs = searcher.Search(query, 20);
            List<SampleDataFileRow> results = new List<SampleDataFileRow>();
            SampleDataFileRow sampleDataFileRow = null;
            ScoreDoc[] scoreDoc = topDocs.ScoreDocs;
            sampleDataFileRow = new SampleDataFileRow();

            foreach (ScoreDoc sd in scoreDoc)
            {
                Document doc = searcher.Doc(sd.Doc);
                sampleDataFileRow.LineNumber = int.Parse(doc.Get("LineNumber"));
                sampleDataFileRow.LineText = doc.Get("LineText");
                results.Add(sampleDataFileRow);
            }
            luceneIndexDirectory.Dispose();
            return results.OrderByDescending(x => x.Score).ToList();


        }

    }

    public class SampleDataFileReader : ISampleDataFileReader
    {
        public IEnumerable<SampleDataFileRow> ReadAllRows()
        {
            FileInfo sFile = new FileInfo(Assembly.GetExecutingAssembly().Location);
            string file = string.Format(@"{0}\Lucene\SampleDataFile.txt", sFile.Directory.FullName);
            string[] lines = File.ReadAllLines(file);
            for (int i = 0; i < lines.Length; i++)
            {
                yield return new SampleDataFileRow
                {
                    LineNumber = i + 1,
                    LineText = lines[i]
                };
            }
        }

        public IEnumerable<SampleDataFileRow> ReadAllRowsDB()
        {
            DBController mydbC = new DBController();
            MCDataSet.MediaDataTable media = mydbC.getMedia();

            foreach (DataRow row in media.Rows)
            {
                yield return new SampleDataFileRow
                {

                    LineNumber = media.Rows.IndexOf(row),
                    LineText = row["link"].ToString()
                };
            }
            /*
            foreach (String s in rows) {
                System.Diagnostics.Debug.WriteLine("ROW: " + s.ToString() + "  END");
            }
            */
        }
    }
}
