using HelloWorld.Api.Implementation.Controllers;
using HelloWorld.Business;
using HelloWorld.Business.Implementation;
using HelloWorld.Data.Implementation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Web;

namespace HelloWorld.Api.Test
{
    [TestFixture]
    public class HellWorldControllerTest
    {
        [Test]
        public void Get_Returns_Database_Value()
        {
            HelloWorldRepository repo = new HelloWorldRepository();
            HelloWorldController controller = new HelloWorldController(new HelloWorldService(repo));
            Assert.Equals(controller.Get(), "Hello World Written to Database");
        }
    }
}