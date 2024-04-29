using CosmeticsOnlineStore_Core.Models.Entity_Configration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsOnlineStore_Core.Models.Entity
{
    public class ContentManagement
    {
        public int Id { get; set;  }
        public int ContentID { get; set; }
        public string ContentType { get; set; }
        public string ContentText { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        //public virtual List<Products> Products { get; set; }
        public virtual List<ContentManagementProductss> ContentManagementProducts { get; set; }

    }
}
