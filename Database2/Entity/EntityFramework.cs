using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Database2
{
    public class EntityFramework : DbContext
    {
        ///public DbSet<BlockedDate> BlockedDate { get; set; }
        ///public DbSet<IntressedList> IntressedList { get; set; }
        ///public DbSet<InviteList> InviteList { get; set; }
        ///public DbSet<Language> Language { get; set; }
        ///public DbSet<Media> Media { get; set; }
        ///public DbSet<PersonalOfferList> PersonalOfferList { get; set; }
        ///public DbSet<Preference> Preference { get; set; }
        ///public DbSet<Profile> Profile { get; set; }
        ///public DbSet<Subscription> Subscription { get; set; }
        ///public DbSet<Subtitles> Subtitles { get; set; }
        public DbSet<User> User { get; set; }
        ///public DbSet<UserSecure> UserSecure { get; set; } 
        ///public DbSet<WatchedMedia> WatchedMedia { get; set; }

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
                var std = new User()
                {
                    Name = "TestUser",
                    Password = "Test",
                    Email = "Test",
                };
                context.User.Add(std);

                context.SaveChanges();

                var student = context.User.Find(1);
                Console.WriteLine(student);
            }
        }
    }
}
