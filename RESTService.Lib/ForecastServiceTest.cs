using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebService.Lib;
using System.IO;

namespace RESTService.Lib
{

    [TestClass]
    public class ForecastServiceTest
    {
        [TestMethod]
        public void TestHelloWorld()
        {
            ForecastService service = new ForecastService();



            service.HelloWorld();

            Assert.AreEqual(true, true);

        }
    }
}
