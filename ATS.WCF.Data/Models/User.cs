using System;
using System.Collections.Generic;

namespace ATS.WCF.Data.Models
{
    public partial class User
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public int CountyId { get; set; }
        public Nullable<decimal> ZipCpde { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int Status { get; set; }
        public virtual LKRole LKRole { get; set; }
        public virtual LKState LKState { get; set; }
        public virtual LKStatu LKStatu { get; set; }
    }
}
