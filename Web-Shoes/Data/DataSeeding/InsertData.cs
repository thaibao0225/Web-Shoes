using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;

namespace Web_Shoes.Data.DataSeeding
{
    public static class InsertData
    {
        public static void Seed(this ModelBuilder builder)
        {


            //var hasher = new PasswordHasher<AppUsers>();

            //Table Products
            builder.Entity<Products>().HasData(
                new Products()
                {
                    pd_Id = 1,
                    pd_Name ="1",
                    pd_Description = "1",
                    pd_Price = 10000,
                    pd_ReducePrice = 1000,
                    pd_Img1 = "1",
                    pd_Img2 = "1",
                    pd_Img3 = "1",
                    pd_Img4 = "1",
                    pd_Rate = 1,
                    pd_MenuFacturer = "1",
                    pd_ShortDescription = "1",
                    pd_Size = "1",
                    pd_Brand = "1",
                    pd_Style = "1",
                    pd_Color = "1",
                    pd_Material = "1",
                    pd_Technologies = "1"

                },

                new Products()
                {
                    pd_Id = 2,
                    pd_Name = "2",
                    pd_Description = "2",
                    pd_Price = 10000,
                    pd_ReducePrice = 1000,
                    pd_Img1 = "2",
                    pd_Img2 = "2",
                    pd_Img3 = "2",
                    pd_Img4 = "2",
                    pd_Rate = 2,
                    pd_MenuFacturer = "2",
                    pd_ShortDescription = "2",
                    pd_Size = "2",
                    pd_Brand = "2",
                    pd_Style = "2",
                    pd_Color = "2",
                    pd_Material = "2",
                    pd_Technologies = "2"

                },

                new Products()
                {
                    pd_Id = 3,
                    pd_Name = "3",
                    pd_Description = "3",
                    pd_Price = 10000,
                    pd_ReducePrice = 1000,
                    pd_Img1 = "3",
                    pd_Img2 = "3",
                    pd_Img3 = "3",
                    pd_Img4 = "3",
                    pd_Rate = 3,
                    pd_MenuFacturer = "3",
                    pd_ShortDescription = "3",
                    pd_Size = "3",
                    pd_Brand = "3",
                    pd_Style = "3",
                    pd_Color = "3",
                    pd_Material = "3",
                    pd_Technologies = "3"

                }
                );




        //Table About
        builder.Entity<About>().HasData(
                new About()
                {
                    about_id=1,
                    about_Img="string",
                    about_Description="string"
                });

            var IdRoleStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd";
            var IdRoleAdmin = "360E601E-92F2-4F08-832B-604A21293258";



            //Table AppRole 2222222222222222222222222222222222222222222222222222222222222222222

            builder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = IdRoleStaff,
                    Name ="staff",
                    Description = "Staff"
                },
                new AppRole()
                {
                    Id = IdRoleAdmin,
                    Name = "admin",
                    Description = "admin"
                });


            var IdStaff = "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff";
            var IdAdmin = "f49e4348-718f-43e3-b1f6-6dc89cfBb5ff";

            //Table AppUser 2222222222222222222222222222222222222222222222222222222222222222222

            var hasher = new PasswordHasher<AppUser>();

            builder.Entity<AppUser>().HasData(
            new AppUser{
                Id = IdAdmin,
                UserName = "Admin",
                NormalizedUserName = "Admin",
                NormalizedEmail = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                SecurityStamp = string.Empty,
                FirstName = "admin",
                LastName = "admin",
                DoB = new DateTime(2020,01,02)

            },
            new AppUser
            {
                Id = IdStaff,
                UserName = "Staff",
                NormalizedUserName = "Staff",
                NormalizedEmail = "staff@gmail.com",
                Email = "staff@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456Aa"),
                SecurityStamp = string.Empty,
                FirstName = "staff",
                LastName = "staff",
                DoB = new DateTime(2020, 03, 02)

            });


            //Table AppUser - role 2222222222222222222222222222222222222222222222222222222222222222222
            builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = IdRoleStaff,
                UserId = IdStaff
            },
            new IdentityUserRole<string>
            {
                RoleId = IdRoleAdmin,
                UserId = IdAdmin
            });



            //Table Bills

            //builder.Entity<Bills>().HasData(
            //    new Bills(){
            //        bill_Id = 1,
            //        bill_UserId = "",
            //        bill_Paid = 10000
            //    });


            //Table Cart

            //builder.Entity<Cart>().HasData(
            //    new Cart()
            //    {
            //        cart_Id = 1,
            //        cart_UserID = ""

            //    });


            //Table Categories



            builder.Entity<Categories>().HasData(
                new Categories()
                {
                    cg_Id = 1,
                    cg_Name = "Wonman",
                    cg_Type = "",
                    cg_Sale = ""

                },
                new Categories()
                {
                    cg_Id = 2,
                    cg_Name = "Man",
                    cg_Type = "",
                    cg_Sale = ""

                });





            //Table ContactSystem

            //builder.Entity<ContactSystem>().HasData(
            //    new ContactSystem()
            //    {
            //        Contact_Id = 1,
            //        Contact_Address = "",
            //        Contact_Phone = "",
            //        Contact_Email = "",
            //        Contact_Website = ""


            //    });



            //Table ContactUsers




            //builder.Entity<ContactUsers>().HasData(
            //    new ContactUsers()
            //    {
            //        cu_Id = 1,
            //        cu_FirstName = "",
            //        cu_LastName = "",
            //        cu_Email = "",
            //        cu_Subject = "",
            //        cu_Description = ""


            //    });




            //Table ProductInCategories



            builder.Entity<ProductsInCategories>().HasData(
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 1
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 2
                },
                new ProductsInCategories()
                {
                    pic_CategoriesId = 2,
                    pic_productId = 3
                });


            //Table Reviews


            //builder.Entity<Reviews>().HasData(
            //    new Reviews()
            //    {
            //        review_id = 1,
            //        review_Comment = "",
            //        review_UserId=""

            //    });




            //Table Wishlist


            //builder.Entity<Wishlists>().HasData(
            //    new Wishlists()
            //    {
            //        wl_Id = 1,
            //        wl_UserId = ""

            //    });




        }    
                
               
    }   
}
