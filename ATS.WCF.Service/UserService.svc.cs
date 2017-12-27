using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ATS.WCF.Data.Repository;
using ATS.WCF.Service.Dto;
using ATS.WCF.Service.Helper.ServiceMapper;
using ATS.WCF.Data.Models;

namespace ATS.WCF.Service
{
    
    public class UserService : IUserService
    {
        public UserRepository UserRepository;

        public UserService()
        {
            UserRepository = new UserRepository();
        }
        
        public List<UserDto> GetUserName(string Name)
        {
           
            var user = new List<UserDto>();
            try
            {
                var lstuser = UserRepository.GetAll().ToList();
                user = GenericServiceMapper<User, UserDto>.MapServiceDto(lstuser);
               
            }
            catch (FaultException fe)
            {
                   throw new FaultException(fe.Message, new FaultCode("UserService"));
            }

            return user;
        }


        public string GetUserNameTest(string Name)
        {
            return "Hello" + Name;
        }
    }
}
