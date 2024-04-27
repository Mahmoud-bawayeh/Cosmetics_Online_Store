using CosmeticsOnlineStore_Core.Shaered;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity
{
    public class ProductRequest: ParentEntity
    {
        public int Id { get; set; }
        public int RequestID { get; set; }
        public int CustomerID { get; set; }
         public string ProductName { get; set; }
        public string Description { get; set; }
        public bool FulfillmentStatus { get; set; }
        public virtual Users Users { get; set; }

    }
}
