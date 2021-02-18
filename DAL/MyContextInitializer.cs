using System.Data.Entity;

namespace DAL
{
    class MyContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var admin = context.Users.Add(new User() {FName="$", LName="admin", Login="1", Password="1", IsAdmin=true });
            var admins_group = context.Groups.Add(new Group() {Name= "admins_group" });

            admins_group.Users.Add(admin);

            context.SaveChanges();

        }
    }
}