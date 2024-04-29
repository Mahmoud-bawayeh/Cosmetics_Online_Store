using CosmeticsOnlineStore_Core.DTO.OrderRecordDTO;
using CosmeticsOnlineStore_Core.DTO.productsDTO;
using CosmeticsOnlineStore_Core.DTO.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Interfaces
{
    public interface IAdminInterface
    {
        Task<List<ProductDTO>> GetAllProduct();
        Task<productDetalsDto> GetproductById(int Id);
        Task CreateProduct(CreateProductDTO dto);
        Task UpdateProduct(UpdateProductDTO dto);
        Task DeleteProduct(int Id);

        Task<List<UserRecordDTO>> GetAllUsers();
        Task<UserRecordDTO> GeUserById(int Id);

        Task DeleteUser(int Id);

        Task<List<OrderRecordDTO>> GetAllOrder();
        Task<OrderRecordDTO> GetOrderById(int Id);


    }
}
