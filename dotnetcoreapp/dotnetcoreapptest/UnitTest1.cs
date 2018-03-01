using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnetcoreapp.Controllers;

namespace dotnetcoreapptest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             HomeController controller = new HomeController();
            bool bsuccess = controller.CheckAvailability(2);
            Assert.IsTrue(bsuccess, "test passed"); 
        }
    }
}
