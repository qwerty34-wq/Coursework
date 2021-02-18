using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(30), MinLength(1)]
        public string FName { get; set; }
        [Required, MaxLength(30), MinLength(1)]
        public string LName { get; set; }
        [Required, MaxLength(50), MinLength(1), Index(IsUnique = true)]
        public string Login { get; set; }
        [Required, MaxLength(50), MinLength(1)]
        public string Password { get; set; }
        [Required]
        public bool IsAdmin { get; set; }

        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
