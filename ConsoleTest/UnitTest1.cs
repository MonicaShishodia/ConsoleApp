using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;


namespace ConsoleTest
{
    [TestClass]
    public class ConsoleTest
    {
        [TestMethod]
        public void TestOutput()
        {
           ConsoleApp.Form1 fs = new ConsoleApp.Form1();
           Assert.IsNotNull(fs.GetMessage());
        }
        [TestMethod]
        public void TestOutputData()
        {
            ConsoleApp.Form1 fs = new ConsoleApp.Form1();
            Assert.AreEqual("Hello Console!!", fs.GetMessage(), true);
        }
    }
}
