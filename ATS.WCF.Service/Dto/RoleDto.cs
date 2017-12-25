using System;
using System.Collections.Generic;

namespace ATS.WCF.Service.Dto
{
    public partial class RoleDto
    {
        public RoleDto()
        {
            this.PrivilegeDto = new List<PrivilegeDto>();
            this.Users = new List<UserDto>();
        }

        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public System.Guid Status { get; set; }
        public virtual ICollection<PrivilegeDto> PrivilegeDto { get; set; }
        public virtual StatusDto StatusDto { get; set; }
       
        public virtual ICollection<UserDto> Users { get; set; }
    }
}
