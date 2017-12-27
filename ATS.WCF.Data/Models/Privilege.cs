using System;
using System.Collections.Generic;

namespace ATS.WCF.Data.Models
{
    public partial class Privilege
    {
        public int ID { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> MenuId { get; set; }
        public Nullable<int> MenuItemId { get; set; }
        public Nullable<int> SubMenuId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int Status { get; set; }
        public virtual LKRole LKRole { get; set; }
        public virtual LKStatu LKStatu { get; set; }
        public virtual LKSubMenuItem LKSubMenuItem { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }
}
