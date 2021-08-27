using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Web_Shoes.Configurations
{
    public class UserInDeviceConfigurations : IEntityTypeConfiguration<UserInDevice>
    {
        public void Configure(EntityTypeBuilder<UserInDevice> builder)
        {
            builder.ToTable("UserInDevice");
            builder.HasKey(t => new { t.uid_DeviceId, t.uid_UserId });


     //       builder.HasOne(t => t.ProductsPICart).WithMany(ur => ur.ProductInCartP)
     //.HasForeignKey(pc => pc.pic_ProductId);
     //       builder.HasOne(t => t.CartPICart).WithMany(ur => ur.ProductInCartC)
     //.HasForeignKey(pc => pc.pic_CartId);
        }
    }
}
