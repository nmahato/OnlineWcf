using System;
using System.Collections.Generic;

namespace ATS.WCF.Service.Dto
{
    public partial class MenuItemDto
    {
        public MenuItemDto()
        {
            this.PrivilegesDto = new List<PrivilegeDto>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string Parameter { get; set; }
        public int ParentId { get; set; }
        public int OrderNumber { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public System.Guid Status { get; set; }
        public virtual StatusDto StatusDto { get; set; }
        public virtual ICollection<PrivilegeDto> PrivilegesDto { get; set; }
    }
}
