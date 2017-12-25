using System;
using System.Collections.Generic;

namespace ATS.WCF.Service.Dto
{
    public partial class ProjectConfigDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
