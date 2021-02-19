using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoLib
{
    [Serializable]
    public class DBTestData
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Filename { get; set; }
        public int NumOfQuestions { get; set; }
        public int? Time { get; set; }
    }
}
