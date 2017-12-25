using System;
using System.Collections.Generic;
using ATS.WCF.Service.Dto;

namespace ATS.WCF.Service.Dto
{
    public partial class MenuDto
    {
        public MenuDto()
        {
            this.Privileges = new List<PrivilegeDto>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public int OrderNumber { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public System.Guid Status { get; set; }
        public virtual StatusDto StatusDto { get; set; }
        public virtual ICollection<PrivilegeDto> Privileges { get; set; }
    }
}
