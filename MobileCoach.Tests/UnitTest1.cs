using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VzSoftphone;
using System.Web.Http;
using System.Web.Http.Results;
using System.Collections.Generic;
using VzSoftphone.Models;

namespace VzSoftphone.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string expectedResult = "Today is the wonderful day of my life";
            //string[] actualStringArray = new string[] { "Today", "is", "the", "wonderful", "day", "of", "my", "life" };
            Controllers.mcController appObject = new Controllers.mcController();

            IHttpActionResult actualResult = appObject.GetAgents();
            var contentResult = actualResult as OkNegotiatedContentResult<List<call>>;

            // Assert
            //Assert.IsNotNull(contentResult);
            //Assert.IsNotNull(contentResult.Content);
            Assert.IsNotNull(null);
            


        }
    }
}
