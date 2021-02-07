using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestElement
{
    [Serializable]
    public class TestElem
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public string CorectAnswer { get; set; }
    }
}
