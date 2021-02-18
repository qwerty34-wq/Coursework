using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Context: DbContext
    {
        public Context(string conStr)
            :base(conStr)
        {}

        static Context()
        {
            Database.SetInitializer<Context>(new MyContextInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
