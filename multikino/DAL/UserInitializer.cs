using System;
using System.Linq;
using multikino.Models;
namespace multikino.DAL

{
    public class UserInitializer
    {
        public static void Initialize(MultikinoContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User { Id = 1, UserSurname = "Carson", UserFirstname = "Alexander", Password = "123" },
            };

            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();

        }
    }
}

