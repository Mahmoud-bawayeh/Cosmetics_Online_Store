using CosmeticsOnlineStore_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity_Configration
{
    public class productRequestEntityTypeConfigration : IEntityTypeConfiguration<ProductRequest>
    {
        public void Configure(EntityTypeBuilder<ProductRequest> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            //not null constaints 
            builder.Property(x => x.RequestID).IsRequired(true);

            builder.Property(x => x.CustomerID).IsRequired(true);
            builder.Property(x => x.ProductName).IsRequired(true);
            builder.Property(x => x.RequestID).IsRequired(true);
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);
    }
    }
}
