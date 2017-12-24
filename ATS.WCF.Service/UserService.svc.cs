using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ATS.WCF.Service
{

    public class UserService : IUserService
    {
       

        public string GetUserName(string Name)
        {
            return "Nitai" + Name;
        }
    }
}
