using System;
using System.Collections.Generic;

namespace ATS.WCF.Data.Models
{
    public partial class LKStatu
    {
        public LKStatu()
        {
            this.LKRoles = new List<LKRole>();
            this.LKRoles1 = new List<LKRole>();
            this.MenuItems = new List<MenuItem>();
            this.Menus = new List<Menu>();
            this.Privileges = new List<Privilege>();
            this.LKSubMenuItems = new List<LKSubMenuItem>();
            this.Users = new List<User>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<LKRole> LKRoles { get; set; }
        public virtual ICollection<LKRole> LKRoles1 { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<Privilege> Privileges { get; set; }
        public virtual ICollection<LKSubMenuItem> LKSubMenuItems { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
