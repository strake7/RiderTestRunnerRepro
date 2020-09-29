using System;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;

namespace RiderTestRunnerRepro.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private ValuesController _controller = new ValuesController();
        [TestMethod]
        public void TestMethod1()
        {
            _controller.Configuration = new HttpConfiguration();
            var model = new Model();
            _controller.Validate(model);
        }
    }
}
