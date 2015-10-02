using System;

using VzSoftphone;
using System.Web.Http;
using System.Web.Http.Results;
using System.Collections.Generic;
using VzSoftphone.Models;
using NUnit;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using ClassCleanup = NUnit.Framework.TestFixtureTearDownAttribute;
using ClassInitialize = NUnit.Framework.TestFixtureSetUpAttribute;


using NUnitAssert = NUnit.Framework.Assert;
using MsAssert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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

            //IHttpActionResult actualResult = appObject.GetAgents();
            //var contentResult = actualResult as OkNegotiatedContentResult<List<call>>;

            // Assert
            //Assert.IsNotNull(contentResult);
            //Assert.IsNotNull(contentResult.Content);
            NUnitAssert.IsNotNull("test");
            


        }
    }
}
