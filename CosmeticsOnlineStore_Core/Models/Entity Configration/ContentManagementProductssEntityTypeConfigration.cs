using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity_Configration
{
    public class ContentManagementProductssEntityTypeConfigration : IEntityTypeConfiguration<ContentManagementProductss>
    {
        public void Configure(EntityTypeBuilder<ContentManagementProductss> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

        }
    }
}
