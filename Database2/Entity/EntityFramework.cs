using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;

namespace Database2
{
    public class EntityFramework : DbContext
    {
        public DbSet<BlockedDate> BlockedDate { get; set; }
        public DbSet<IntressedList> IntressedList { get; set; }
        public DbSet<InviteList> InviteList { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<PersonalOfferList> PersonalOfferList { get; set; }
        public DbSet<Preference> Preference { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<Subtitles> Subtitles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserSecure> UserSecure { get; set; } 
        public DbSet<WatchedMedia> WatchedMedia { get; set; }

        public EntityFramework() : base("ConnectionEntity")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<EntityFramework>());
        }
    }
    class EntityFunction
    {
        public void Entity_Test(int counter)
        {
            using (var context = new EntityFramework())
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                IList<User> userList = new List<User>();

                for(int i = 0; i < counter; i++)
                {
                    userList.Add(new User()
                    {
                        Name = "TestUser",
                        Password = "Test",
                        Email = "Test",

                    });
                }

                context.User.AddRange(userList);
                context.SaveChanges();

                for (int i = 1; i <= counter; i++)
                {
                    var user = context.User.Find(i);
                    if(user.Name == "TestUser")
                    {
                        user.Name = "AdaptedTestUser";        
                        context.SaveChanges();
                    }
                }

                for (int i = 0; i < counter; i++)
                {
                    var users = context.User.Find(counter);
                    Console.WriteLine(users.Name);
                }

                for (int i = 1; i <= counter; i++)
                {
                    var delete = context.User.Find(i);
                    context.User.Remove(delete);
                    context.SaveChanges();
                }

                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;

                Console.WriteLine(ts);
            }
        }
    }
}
