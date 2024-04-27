using CosmeticsOnlineStore_Core.IRepos;
using CosmeticsOnlineStore_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Infra.Repos
{
    public class ManagerRepos : IManagerReposInterface
    {
        public List<int> GetJokes()
        {

            var number = new List<int>()
            {
                11,23,36,22
            };
            return number;
        }
    }
}
    

