using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestElement
{
    [Serializable]
    public class Data
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public List<TestElem> Tests { get; set; }

    }
}
