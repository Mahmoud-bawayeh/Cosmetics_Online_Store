using CosmeticsOnlineStore_Core.Context;
using CosmeticsOnlineStore_Core.DTO;
using CosmeticsOnlineStore_Core.Interfaces;
using CosmeticsOnlineStore_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Implmentations
{
    public class SharedImplementation : ISharedInterface
    {

        private readonly CosmeticsOnlineStoreDBContext _context;
        public SharedImplementation(CosmeticsOnlineStoreDBContext context)
        {
            
            _context = context;
        }
        public async Task<List<Products>> GetAllProductsin()
        {
            string query = "select * from Products";
            return await _context.Products.ToListAsync();
        }
        public Task CreateAccount(RegistrationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task Login(LoginReqDTO loginReqDTO)
        {
            throw new NotImplementedException();
        }

        public Task Logout(int userId)
        {
            throw new NotImplementedException();
        }

        public Task ResetPassword(ResetPasswordDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProfile(UpdateProfileDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductsDTO>> ViewMenu(bool isAdmin = false)
        {
            throw new NotImplementedException();
        }

        public Task GetAllProduects()
        {
            throw new NotImplementedException();
        }

        public Task GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductsDTO>> ViewProducts(bool isAdmin = false)
        {
            throw new NotImplementedException();
        }
    }
}
