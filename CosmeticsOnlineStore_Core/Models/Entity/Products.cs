using CosmeticsOnlineStore_Core.Models.Entity_Configration;
using CosmeticsOnlineStore_Core.Shaered;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity
{
    public class Products: ParentEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }  
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }
        public string Image { get; set; }
        public virtual Orders Orders { get; set; }
        //public virtual List<Products> Product { get; set; }
        public virtual List<SalesReport> SalesReports { get; set; }
        //public virtual List<ContentManagement> ContentManagements { get; set; }
        public virtual List<ContentManagementProductss> ContentManagementProducts { get; set; }


    }
}
