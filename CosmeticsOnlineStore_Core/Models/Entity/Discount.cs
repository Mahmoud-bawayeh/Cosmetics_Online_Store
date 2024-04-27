using CosmeticsOnlineStore_Core.Shaered;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity
{
    public class Discount: ParentEntity
    {
        public int Id { get; set; }
        public int DiscountID { get; set; }
        public int CustomerID { get; set; }
        public double DiscountPercentage { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public virtual Users Users { get; set; }

    }
}
