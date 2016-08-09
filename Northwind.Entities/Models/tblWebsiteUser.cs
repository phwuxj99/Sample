using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.Models
{
    //class tblWebsiteUser
    //{
    //}


    public partial class tblWebsiteUser: Entity
    {
        public int SqlBigID { get; set; }
        public string OrgName { get; set; }
        public string UserName { get; set; }

        [Key]
        public string UserID { get; set; }
        public string UserPassword { get; set; }
        public Nullable<System.DateTime> Passmdate { get; set; }
        public short SuperUser { get; set; }
        public string Email { get; set; }
        public System.DateTime ActivationDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public short BigCom { get; set; }
        public short BigCa { get; set; }
        public short FsCom { get; set; }
        public short FsCa { get; set; }
        public Nullable<short> FsUK { get; set; }
        public Nullable<short> Tutorial { get; set; }
        public System.DateTime TimeCreated { get; set; }
        public string ContactDB { get; set; }
        public short ConcurrentLimit { get; set; }
        public int DownloadLimit { get; set; }
        public short Newsletter { get; set; }
        public short DLicense { get; set; }
        public int RelocateLic { get; set; }
        public int RelocateLicLimit { get; set; }
        public short Suspend { get; set; }
        public string Browser { get; set; }
        public string StationID { get; set; }
        public string ComputerIP { get; set; }
        public Nullable<short> Stationcontrol { get; set; }
        public int IDX_ROW_ID { get; set; }
        public Nullable<System.DateTime> Module1_1 { get; set; }
        public Nullable<System.DateTime> Module1_2 { get; set; }
        public Nullable<System.DateTime> Module1_3 { get; set; }
        public Nullable<System.DateTime> Module1_4 { get; set; }
        public Nullable<System.DateTime> Module1_5 { get; set; }
        public Nullable<System.DateTime> Module1_6 { get; set; }
        public Nullable<System.DateTime> Module1_7 { get; set; }
        public Nullable<System.DateTime> Module1_8 { get; set; }
        public Nullable<System.DateTime> Module2_1 { get; set; }
        public Nullable<System.DateTime> Module2_2 { get; set; }
        public Nullable<System.DateTime> Module2_3 { get; set; }
        public Nullable<System.DateTime> Module2_4 { get; set; }
        public Nullable<System.DateTime> Module2_5 { get; set; }
        public Nullable<System.DateTime> Module2_6 { get; set; }
        public Nullable<System.DateTime> Module3_1 { get; set; }
        public Nullable<System.DateTime> Module3_2 { get; set; }
        public Nullable<System.DateTime> Module3_3 { get; set; }
        public Nullable<System.DateTime> Module3_4 { get; set; }
        public Nullable<System.DateTime> Module4_1 { get; set; }
        public Nullable<System.DateTime> Module4_2 { get; set; }
        public Nullable<System.DateTime> Module4_3 { get; set; }
        public Nullable<System.DateTime> Module4_4 { get; set; }
        public Nullable<System.DateTime> Module4_5 { get; set; }
        public Nullable<System.DateTime> Module4_6 { get; set; }
        public Nullable<System.DateTime> Module4_7 { get; set; }
        public Nullable<System.DateTime> Module4_8 { get; set; }
        public Nullable<System.DateTime> Module4_9 { get; set; }
        public string Client_LastName { get; set; }
        public short OE { get; set; }
        public string LESSON1 { get; set; }
        public string LESSON2 { get; set; }
        public string LESSON3 { get; set; }
        public string LESSON4 { get; set; }
        public string LESSON5 { get; set; }
        public string LESSON6 { get; set; }
        public string LESSON7 { get; set; }
        public string LESSON8 { get; set; }
        public string LESSON9 { get; set; }
        public string LESSON10 { get; set; }
        public Nullable<System.DateTime> Gift_Sent { get; set; }
    }
}
