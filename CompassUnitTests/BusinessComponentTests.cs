using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompassUnitTests
{
    [TestClass]
    public class BusinessComponentTests
    {
        [TestMethod]
        public void CreateUserTest()
        {
            Compass.Business.Components.UserManager userManagerTestManager = new Compass.Business.Components.UserManager();
            Assert.AreEqual(1,userManagerTestManager.CreateNewUser(new Compass.Business.Entities.UserDetailDTO()));
        }
    }
}
