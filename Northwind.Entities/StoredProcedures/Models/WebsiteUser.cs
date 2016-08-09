using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.StoredProcedures.Models
{

    public partial class WebsiteUser : Entity
    {
        public int SqlBigID { get; set; }
        public string OrgName { get; set; }
        public string UserName { get; set; }

        [Key]
        public string UserID { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public System.DateTime ActivationDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<short> Tutorial { get; set; }
        public short ConcurrentLimit { get; set; }
    }
}
