using CosmeticsOnlineStore_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity_Configration
{
    public class OrderEntityTypeConfigration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Orders> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            //not null constaints 
            builder.Property(x => x.OrderId).IsRequired(true);
            //not null constaints 
            builder.Property(x => x.CustomerID).IsRequired(true);
            builder.HasCheckConstraint("Ch_Order_TotalAmount", "TotalAmount >= 0");

            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);


        }
    }
}
