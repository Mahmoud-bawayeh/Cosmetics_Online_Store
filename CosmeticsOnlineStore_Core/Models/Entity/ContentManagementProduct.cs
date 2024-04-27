using CosmeticsOnlineStore_Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity_Configration
{
    public class ContentManagementProduct
    {
        public int Id { get; set; }

        // Foreign key properties
        public int ContentManagementId { get; set; }
        public int ProductId { get; set; }

        // Navigation properties
        [ForeignKey("ContentManagementId")]
        public ContentManagement ContentManagement { get; set; }

        [ForeignKey("ProductId")]
        public Products Products { get; set; }
    }
}
