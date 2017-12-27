using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATS.WCF.Service;

namespace ATS.WCF.TEST
{
    [TestClass]
    public class UserServiceTest
    {
        [TestMethod]
        public void UserTest()
        {
            var user = new UserService();
          var a=  user.GetUserName("Test");

        }
    }
}
