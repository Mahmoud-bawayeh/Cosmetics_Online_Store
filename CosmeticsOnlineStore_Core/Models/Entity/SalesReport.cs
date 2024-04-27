using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity
{
    public class SalesReport
    {
     public int Id { get; set; }
        public int ReportID { get; set; }
        public DateTime ReportDate { get; set; }
        public double TotalSales { get; set; }
        public double TotalOrders { get; set; }

    }
}
