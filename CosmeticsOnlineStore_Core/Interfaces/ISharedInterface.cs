using CosmeticsOnlineStore_Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Interfaces
{
    public interface ISharedInterface
    {
        Task Login(LoginReqDTO loginReqDTO);
        Task Logout(int userId);
        Task CreateAccount(RegistrationDTO dto);
        Task ResetPassword(ResetPasswordDTO dto);
        Task UpdateProfile(UpdateProfileDTO dto);
        Task<List<ProductsDTO>> ViewProducts(bool isAdmin = false);
        Task GetAllProducts();
    }
}
