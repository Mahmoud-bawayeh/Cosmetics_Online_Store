using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity
{
    public class Wishlist
    {
        public int Id { get; set; }
        public int WishlistID { get; set; }
         public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public DateTime AddedDate { get; set; }
        public virtual Users Users { get; set; }


    }
}
