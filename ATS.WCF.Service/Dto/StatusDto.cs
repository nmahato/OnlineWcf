using System;
using System.Collections.Generic;

namespace ATS.WCF.Service.Dto
{
    public partial class StatusDto
    {
        public StatusDto()
        {
        //    this.LKRoles = new List<LKRole>();
        //    this.LKRoles1 = new List<LKRole>();
        //    this.MenuItems = new List<MenuItem>();
        //    this.Menus = new List<Menu>();
        //    this.Privileges = new List<Privilege>();
        //    this.LKSubMenuItems = new List<LKSubMenuItem>();
        //    this.Users = new List<User>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<RoleDto> LKRoles { get; set; }
        
        public virtual ICollection<MenuItemDto> MenuItems { get; set; }
        public virtual ICollection<MenuDto> MenuDto { get; set; }
        public virtual ICollection<PrivilegeDto> PrivilegesDto { get; set; }
        public virtual ICollection<SubMenuItemDto> LKSubMenuItemsDtos { get; set; }
        public virtual ICollection<UserDto> UserDtos { get; set; }
    }
}
