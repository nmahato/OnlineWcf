using System;
using System.Collections.Generic;
using ATS.WCF.Service.Dto;

namespace ATS.WCF.Service.Dto
{
    public partial class PrivilegeDto
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> RoleId { get; set; }
        public Nullable<System.Guid> MenuId { get; set; }
        public Nullable<System.Guid> MenuItemId { get; set; }
        public Nullable<System.Guid> SubMenuId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public System.Guid Status { get; set; }
        public virtual RoleDto RoleDto { get; set; }
        public virtual StatusDto StatusDto { get; set; }
        public virtual SubMenuItemDto SubMenuItemDto { get; set; }
        public virtual MenuDto MenuDto { get; set; }
        public virtual MenuItemDto MenuItemDto { get; set; }
    }
}
