namespace ShoeShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ShoeShop.Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoeShop.Data.ShoeShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShoeShop.Data.ShoeShopDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ShoeShopDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ShoeShopDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "shoeshop",
                Email = "huynhanhtrucmong@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "huynh anh truc mong"
            };
            manager.Create(user,"123454$");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("huynhanhtrucmong@gmail.com");

            manager.AddToRole(adminUser.Id, "Admin");
            manager.AddToRole(adminUser.Id, "User");

        }
    }
}
