using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GroupTest
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int TestId { get; set; }
        
        public virtual Group Group { get; set; }
        public virtual Test Test { get; set; }
    }
}
