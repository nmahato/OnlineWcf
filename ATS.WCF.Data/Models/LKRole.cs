using System;
using System.Collections.Generic;

namespace ATS.WCF.Data.Models
{
    public partial class LKRole
    {
        public LKRole()
        {
            this.Privileges = new List<Privilege>();
            this.Users = new List<User>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Privilege> Privileges { get; set; }
        public virtual LKStatu LKStatu { get; set; }
        public virtual LKStatu LKStatu1 { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
