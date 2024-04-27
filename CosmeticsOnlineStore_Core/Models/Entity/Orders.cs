using CosmeticsOnlineStore_Core.Shaered;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity
{
    public class Orders: ParentEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
       public int CustomerID { get; set; }
        public double TotalAmount { get; set; }
        public virtual Users Users { get; set; }
        public virtual List<Products> Products { get; set; }

    }
}
