using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Grade
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int TestId { get; set; }
        [Required]
        public int Mark { get; set; }


        public virtual User User { get; set; }
        public virtual Test Test { get; set; }
    }
}
