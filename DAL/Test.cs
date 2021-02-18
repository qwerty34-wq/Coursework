using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Test
    {
        public int Id { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string Author { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string Title { get; set; }
        [Required]
        public int NumOfQuestions { get; set; }

        public int? Time { get; set; } 


        public ICollection<Group> Groups { get; set; }
        public Test()
        {
            Groups = new List<Group>();
        }


    }
}
