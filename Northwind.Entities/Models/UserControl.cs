using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.Models
{
    public partial class UserControl : Entity
    {
        public Nullable<int> SQLBigID { get; set; }
        public string Sitecode { get; set; }
        public Nullable<int> UserNumOpen { get; set; }
        public Nullable<System.DateTime> TimeCreated { get; set; }
        public Nullable<System.DateTime> TimeFulfilled { get; set; }
        [Key]
        public int IDX_ROW_ID { get; set; }
    }
}
