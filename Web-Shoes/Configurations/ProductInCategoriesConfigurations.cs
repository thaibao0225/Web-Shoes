using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Shoes.Configurations
{
    public class ProductInCategoriesConfigurations : IEntityTypeConfiguration<ProductsInCategories>
    {
        public void Configure(EntityTypeBuilder<ProductsInCategories> builder)
        {
            builder.ToTable("ProductsInCategories");
            builder.HasKey(t => new { t.pic_productId,t.pic_CategoriesId });

        }
    }
}
