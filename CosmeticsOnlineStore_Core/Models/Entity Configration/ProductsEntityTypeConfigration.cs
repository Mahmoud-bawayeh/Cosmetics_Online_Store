using CosmeticsOnlineStore_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity_Configration
{
    public class ProductsEntityTypeConfigration : IEntityTypeConfiguration<Products>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ProductName).IsRequired(true);
            builder.Property(x => x.Price).IsRequired(true);
            //check const
            builder.ToTable(x => x.HasCheckConstraint("Ch_Product_Price", "Price>=0"));
            builder.ToTable(x => x.HasCheckConstraint("Ch_Product_AvailableQuantity", "AvailableQuantity>=5"));
            //deafult value
            builder.Property(x => x.Price).HasDefaultValue(0);

            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);

        }
    }
}

