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
    public class ContentManagementEntityTypeConfigration : IEntityTypeConfiguration<ContentManagement>
    {
        public void Configure(EntityTypeBuilder<ContentManagement> builder)
        {
            builder.ToTable("ContentManagementProduct");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
           
        }
    }
}
