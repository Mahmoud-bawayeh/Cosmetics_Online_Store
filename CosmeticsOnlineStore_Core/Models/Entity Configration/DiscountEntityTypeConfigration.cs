﻿using CosmeticsOnlineStore_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity_Configration
{
    public class DiscountEntityTypeConfigration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.DiscountID).IsRequired(true);
            builder.Property(x => x.CustomerID).IsRequired(true);
            builder.Property(x => x.ValidFrom).IsRequired(true);
            builder.Property(x => x.ValidTo).IsRequired(true);
            builder.Property(x => x.DiscountPercentage).HasDefaultValue(0);
            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsActive).HasDefaultValue(true);






        }
    }
}
