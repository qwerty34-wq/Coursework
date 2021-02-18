using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Group
    {
        public int Id { get; set; }
        [Required, MaxLength(50), MinLength(1), Index(IsUnique = true)]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Test> Tests { get; set; }
        public Group()
        {
            Users = new List<User>();
            Tests = new List<Test>();
        }



    }
}
