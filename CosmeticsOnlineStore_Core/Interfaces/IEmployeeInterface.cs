using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Interfaces
{
    public interface IEmployeeInterface
    {
        Task CheckoutOrder(CreateOrderDTO dto);
        Task PrintInvoice(int OrderId);
    }
}
