namespace PlaylistSystem.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<PlaylistSystem.Data.PlaylistSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PlaylistSystemDbContext context)
        {
           

            if (context.Playlists.Any())
            {
                return;
            }

            var users = new List<User>();

            var userManager = new UserManager<User>(new UserStore<User>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }

            var adminUser = userManager.Users.FirstOrDefault(x => x.Email == "admin@site.com");

            if (adminUser == null)
            {
                var admin = new User
                {
                    Email = "admin@site.com",
                    UserName = "admin@site.com",
                    FirstName = "Admin",
                    LastName = "Admin"

                };
                //password
                userManager.Create(admin, "admina");
                context.SaveChanges();

                userManager.AddToRole(admin.Id, "Admin");
            }
            context.SaveChanges();

            var user1 = new User() { UserName = "user1@site.com", Email = "user1@site.com", FirstName = "UserFN1", LastName = "UserLN1" };
            //password
            userManager.Create(user1, "user11");
            users.Add(user1);
            context.SaveChanges();

            var user2 = new User() { UserName = "user2@site.com", Email = "user2@site.com", FirstName = "UserFN2", LastName = "UserLN2" };
            //password
            userManager.Create(user2, "user22");
            users.Add(user2);
            context.SaveChanges();

            var user3 = new User() { UserName = "user3@site.com", Email = "user3@site.com", FirstName = "UserFN3", LastName = "UserLN3" };
            //password
            userManager.Create(user3, "user33");
            users.Add(user3);
            context.SaveChanges();

            var user4 = new User() { UserName = "user4@site.com", Email = "user4@site.com", FirstName = "UserFN4", LastName = "UserLN4" };
            //password
            userManager.Create(user4, "user44");
            users.Add(user4);
            context.SaveChanges();

            var user5 = new User() { UserName = "user5@site.com", Email = "user5@site.com", FirstName = "UserFN5", LastName = "UserLN5" };
            //password
            userManager.Create(user5, "user55");
            users.Add(user5);
            context.SaveChanges();

            var seed = new SeedData(users);

            seed.Categories.ForEach(x => context.Categories.Add(x));
            context.SaveChanges();


            seed.Playlists.ForEach(x => context.Playlists.Add(x));
            context.SaveChanges();


            seed.Videos.ForEach(x => context.Videos.Add(x));
            context.SaveChanges();


            seed.Ratings.ForEach(x => context.Ratings.Add(x));

            context.SaveChanges();
        }
    }
}
