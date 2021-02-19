using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestElement;

namespace InfoLib
{
    [Serializable]
    public class Info
    {
        public string MSG { get; set; }
        public Data Data { get; set; }
        public DBTestData DBTestData { get; set; }
        public DBUserData DBUserData { get; set; }
        public IPEndPoint remoteEP { get; set; }
    }
}
