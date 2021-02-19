using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoLib
{
    [Serializable]
    public class DBUserData
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int? GroupId { get; set; }
    }
}
