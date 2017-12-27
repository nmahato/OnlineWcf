using System;
using System.Collections.Generic;

namespace ATS.WCF.Data.Models
{
    public partial class Menu
    {
        public Menu()
        {
            this.Privileges = new List<Privilege>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int Status { get; set; }
        public virtual LKStatu LKStatu { get; set; }
        public virtual ICollection<Privilege> Privileges { get; set; }
    }
}
