using CosmeticsOnlineStore_Core.Models.Entity;
using CosmeticsOnlineStore_Core.Models.Entity_Configration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Context
{
    public class CosmeticsOnlineStoreDBContext : DbContext
    {
        public CosmeticsOnlineStoreDBContext(DbContextOptions options) : base(options)
        
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ContentManagementEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new ContentManagementProductEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new DiscountEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new OrderEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new productRequestEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new ProductsEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new salesReportEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new UsersEntityTypeConfigration());
            modelBuilder.ApplyConfiguration(new WishListEntityTypeConfigration());


        }


        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ContentManagement> ContentManagements { get; set; }
        public virtual DbSet<ContentManagementProduct> ContentManagementProducts { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<ProductRequest> ProductRequests { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<SalesReport> SalesReports { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }
    }
}


