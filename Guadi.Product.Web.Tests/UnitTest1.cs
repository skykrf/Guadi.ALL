using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Guadi.Product.Web.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller =new  Guadi.Product.Web.Controllers.CountryController();
            var result = controller.Index();
            Assert.AreEqual("Index",result.ToString());

        }
    }
}
