using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CosmeticsOnlineStore_Core.Enums.CosmaticsLookup;

namespace CosmeticsOnlineStore_Core.DTO.OrderDTO
{
    public class CreateOrderByClint
    {
        public int OrderId { get; set; }
        public float PromoCode { get; set; }
        
    }
}
