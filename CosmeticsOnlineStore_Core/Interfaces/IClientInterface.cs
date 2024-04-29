using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CosmeticsOnlineStore_Core.Enums.CosmaticsLookup;

namespace CosmeticsOnlineStore_Core.Interfaces
{
    public interface IClientInterface
    {
        Task CreateOrder(CreateOrderByClint dto);
        Task<OrderDetailsDTO> GetOrderDetailsByOrderId(int Id);
    }
}
