using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using CosmeticsOnlineStore_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Implmentations
{
    public class ClientImplementation : IClientInterface
    {
        public Task CreateOrder(CreateOrderByClint dto)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDetailsDTO> GetOrderDetailsByOrderId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
