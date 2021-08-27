﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Web_Shoes.Configurations;
using Web_Shoes.Data.DataSeeding;
using Web_Shoes.Entity;
using Web_Shoes.Models;

namespace Web_Shoes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
            builder
                // .AddFilter (DbLoggerCategory.Database.Command.Name, LogLevel.Warning)
                // .AddFilter (DbLoggerCategory.Query.Name, LogLevel.Debug)
                .AddConsole();
        });

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //// Bỏ tiền tố AspNet của các bảng: mặc định các bảng trong IdentityDbContext có
            //// tên với tiền tố AspNet như: AspNetUserRoles, AspNetUser ...
            //// Đoạn mã sau chạy khi khởi tạo DbContext, tạo database sẽ loại bỏ tiền tố đó
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }



            builder.ApplyConfiguration(new AboutConfigurations());
            builder.ApplyConfiguration(new AppRoleConfigurations());
            builder.ApplyConfiguration(new AppUserConfigurations());
            builder.ApplyConfiguration(new BillConfigurations());
            builder.ApplyConfiguration(new CartConfigurations());
            builder.ApplyConfiguration(new CategoriesConfigurations());
            builder.ApplyConfiguration(new ContactSystemConfigurations());
            builder.ApplyConfiguration(new ContactUsersConfigurations());
            builder.ApplyConfiguration(new ProductInCartConfigurations());
            builder.ApplyConfiguration(new ProductInCategoriesConfigurations());
            builder.ApplyConfiguration(new ProductInWishlistConfigurations());
            builder.ApplyConfiguration(new ProductsConfigurations());
            builder.ApplyConfiguration(new ReviewsConfigurations());
            builder.ApplyConfiguration(new ReviewInproductConfigurations());
            builder.ApplyConfiguration(new WishlistsConfigurations());
            builder.ApplyConfiguration(new CouponsConfigurations());
            builder.ApplyConfiguration(new DeviceConfigurations());
            builder.ApplyConfiguration(new UserInDeviceConfigurations());



            //builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            //builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRole").HasKey(x => new { x.UserId, x.RoleId });
            //builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            //builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppUserRoleClaims");
            //builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);




            builder.Seed();


        }
        public DbSet<About> About { set; get; }
        public DbSet<AppRole> AppRole { set; get; }
        public DbSet<AppUser> AppUser { set; get; }
        public DbSet<Bills> Bills { set; get; }
        public DbSet<Categories> Categories { set; get; }
        public DbSet<ContactSystem> ContactSystem { set; get; }
        public DbSet<ContactUsers> ContactUsers { set; get; }
        public DbSet<Products> Products { set; get; }
      
        public DbSet<Reviews> Reviews { set; get; }
        public DbSet<Wishlists> Wishlists { set; get; }
        public DbSet<ReviewInproduct> ReviewInproduct { set; get; }
        public DbSet<ProductInCart> ProductInCart { set; get; }
        public DbSet<ProductsInCategories> ProductsInCategories { set; get; }
        public DbSet<ProductInWishlist> ProductInWishlist { set; get; }
        public DbSet<Cart> Cart { set; get; }
        public DbSet<Coupons> Coupons { set; get; }
        public DbSet<Device> Devices { set; get; }
        public DbSet<UserInDevice> UserInDevices { set; get; }

        public DbSet<Web_Shoes.Models.UserInRoleModel> UserInRoleModel { get; set; }
        //public DbSet<AppUserRole> AppUserRole { set; get; }

    }
}
