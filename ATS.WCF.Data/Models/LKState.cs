using System;
using System.Collections.Generic;

namespace ATS.WCF.Data.Models
{
    public partial class LKState
    {
        public LKState()
        {
            this.Users = new List<User>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int Status { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
