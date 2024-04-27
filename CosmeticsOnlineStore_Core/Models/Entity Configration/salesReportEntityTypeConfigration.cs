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
    public class salesReportEntityTypeConfigration : IEntityTypeConfiguration<SalesReport>
    {
        public void Configure(EntityTypeBuilder<SalesReport> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            //not null constaints 
            builder.Property(x => x.ReportID).IsRequired(true);
            builder.Property(x => x.ReportDate).HasDefaultValue(DateTime.Now);
            builder.ToTable(x => x.HasCheckConstraint("_salesReport_TotalOrders_CH", "TotalOrders >= 0"));

    }
    }
}
