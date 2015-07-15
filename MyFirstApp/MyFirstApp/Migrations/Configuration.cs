namespace MyFirstApp.Migrations
{
    using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyFirstApp.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyFirstApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyFirstApp.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));

            if (!context.Roles.Any(r => r.Name == "Admin"))
            { 
                roleManager.Create(new IdentityRole { Name = "Admin"});

            }
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));

            if (!context.Users.Any(u => u.Email =="your email address"))
                userManager.Create(new ApplicationUser {

                    UserName = "jessica.ansong@gmail.com",
                    Email = "jessica.ansong@gmail.com",
                    FirstName = "Jessica",
                    LastName = "Ansong",
                    DisplayName = "Jessica Ansong"
                },"spelmanite07");

        var userId = userManager.FindByEmail("jessica.ansong@gmail.com").Id;
        userManager.AddToRole(userId, "Admin");

    }
    


                    
    }
}
