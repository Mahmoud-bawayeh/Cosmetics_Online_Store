using CosmeticsOnlineStore_Core.DTO.OrderDTO;
using CosmeticsOnlineStore_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Implmentations
{
    public class EmployeeImplementation : IEmployeeInterface
    {
        public Task CheckoutOrder(CreateOrderDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task PrintInvoice(int OrderId)
        {
            throw new NotImplementedException();
        }
    }
}
