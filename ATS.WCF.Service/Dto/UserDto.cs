using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ATS.WCF.Service.Dto
{
    [DataContract]
    public class UserDto
    {
        [DataMember]
        public int ID { get; set; }
         [DataMember]
        public string UserId { get; set; }
         [DataMember]
        public string Password { get; set; }
         [DataMember]
        public string FirstName { get; set; }
         [DataMember]
        public string MiddleName { get; set; }
         [DataMember]
        public string LastName { get; set; }
         [DataMember]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public int CountyId { get; set; }
        public Nullable<decimal> ZipCpde { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int Status { get; set; }
        public virtual RoleDto Role { get; set; }
        public virtual StateDto StateDto { get; set; }
        public virtual StatusDto StatusDto { get; set; }
    }
}