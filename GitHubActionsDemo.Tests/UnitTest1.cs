using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace GitHubActionsDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("UnitTests")]
        public void TestMethod1()
        {
            Assert.AreEqual(expected: 1, actual: Class1.Property1);
        }

        [TestMethod]
        [TestCategory("IntegrationTests")]
        public void TestMethod2()
        {
            Assert.IsNotNull(Path.GetTempPath());
        }
    }
}
