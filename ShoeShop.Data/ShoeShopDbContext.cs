﻿using Microsoft.AspNet.Identity.EntityFramework;
using ShoeShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Data
{
    public class ShoeShopDbContext: IdentityDbContext<ApplicationUser>
    {
        public ShoeShopDbContext(): base("ShoeShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        } 

        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }
        public DbSet<Error> Errors { set; get; }

        public static ShoeShopDbContext Create()
        {
            return new ShoeShopDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityUserRole>().HasKey(i =>new { i.UserId, i.RoleId });
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}
