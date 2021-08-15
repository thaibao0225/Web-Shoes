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
                    pd_Name ="",
                    pd_Description = "",
                    pd_Price = 10000,
                    pd_ReducePrice = 1000,
                    pd_Img1 = "",
                    pd_Img2 = "",
                    pd_Img3 = "",
                    pd_Img4 = "",
                    pd_Rate = 1,
                    pd_MenuFacturer = "",
                    pd_ShortDescription = "",
                    pd_Size = "",
                    pd_Brand = "",
                    pd_Style = "",
                    pd_Color = "",
                    pd_Material = "",
                    pd_Technologies = ""

                });




        //Table About
        builder.Entity<About>().HasData(
                new About()
                {
                    about_id=1,
                    about_Img="",
                    about_Description=""
                });





            //Table AppRole 2222222222222222222222222222222222222222222222222222222222222222222




            //Table AppUser 2222222222222222222222222222222222222222222222222222222222222222222




            //Table Bills

            builder.Entity<Bills>().HasData(
                new Bills()
                {
                    bill_Id = 1,
                    bill_UserId = "",
                    bill_Paid = 10000
                });


            //Table Cart

            builder.Entity<Cart>().HasData(
                new Cart()
                {
                    cart_Id = 1,
                    cart_UserID = ""

                });


            //Table Categories



            builder.Entity<Categories>().HasData(
                new Categories()
                {
                    cg_Id = 1,
                    cg_Name = "",
                    cg_Type = "",
                    cg_Sale = ""

                });





            //Table ContactSystem

            builder.Entity<ContactSystem>().HasData(
                new ContactSystem()
                {
                    Contact_Id = 1,
                    Contact_Address = "",
                    Contact_Phone = "",
                    Contact_Email = "",
                    Contact_Website = ""


                });



            //Table ContactUsers




            builder.Entity<ContactUsers>().HasData(
                new ContactUsers()
                {
                    cu_Id = 1,
                    cu_FirstName = "",
                    cu_LastName = "",
                    cu_Email = "",
                    cu_Subject = "",
                    cu_Description = ""


                });




            //Table ProductInCategories



            builder.Entity<ProductsInCategories>().HasData(
                new ProductsInCategories()
                {
                    pic_CategoriesId = 1,
                    pic_productId = 1


                });


            //Table Reviews


            builder.Entity<Reviews>().HasData(
                new Reviews()
                {
                    review_id = 1,
                    review_Comment = "",
                    review_UserId=""

                });




            //Table Wishlist


            builder.Entity<Wishlists>().HasData(
                new Wishlists()
                {
                    wl_Id = 1,
                    wl_UserId = ""

                });




    }    
                
               
    }   
}
