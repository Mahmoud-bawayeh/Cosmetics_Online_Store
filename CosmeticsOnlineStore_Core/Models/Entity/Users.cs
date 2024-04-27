using CosmeticsOnlineStore_Core.Shaered;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity
{
    public class Users: ParentEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Image { get; set; }
        public string NationalNo { get; set; }
        public string UserType { get; set; }
         public double TotalSpent { get; set; }
        public virtual List<Orders> Orders { get; set; }
        public virtual List<Discount> Discounts { get; set; }
        public virtual List<ProductRequest> ProductRequests { get; set; }
        public virtual List<Wishlist> Wishlists { get; set; }




    }
}
