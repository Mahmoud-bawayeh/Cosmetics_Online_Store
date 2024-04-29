using CosmeticsOnlineStore_Core.DTO.OrderRecordDTO;
using CosmeticsOnlineStore_Core.DTO.productsDTO;
using CosmeticsOnlineStore_Core.DTO.UserDTO;
using CosmeticsOnlineStore_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Implmentations
{
    public class AdminImplementation : IAdminInterface
    {
        public Task CreateProduct(CreateProductDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderRecordDTO>> GetAllOrder()
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDTO>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Task<List<UserRecordDTO>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<OrderRecordDTO> GetOrderById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<productDetalsDto> GetproductById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<UserRecordDTO> GeUserById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(UpdateProductDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
