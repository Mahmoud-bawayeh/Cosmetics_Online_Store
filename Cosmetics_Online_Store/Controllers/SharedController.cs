using CosmeticsOnlineStore_Core.Implmentations;
using CosmeticsOnlineStore_Core.Interfaces;
using CosmeticsOnlineStore_Core.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cosmetics_Online_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedController : ControllerBase
    {
        private readonly SharedImplementation _SharedImplementation;
        private SharedImplementation? implementation;

        public SharedController(ISharedInterface sharedInterface)
        {
            _SharedImplementation = implementation;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllProductsin()
        {
            var rs = await _SharedImplementation.GetAllProductsin();
            return Ok(rs); 
        }
    }
}