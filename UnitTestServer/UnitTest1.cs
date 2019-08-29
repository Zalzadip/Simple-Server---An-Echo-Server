using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simple_Server___An_Echo_Server;

namespace UnitTestServer
{
    [TestClass]
    public class UnitTest1
    {
        Worker worker = new Worker();

        [TestMethod]
        public void WordCountTest()
        {
            Assert.AreEqual(3, worker.WordCount("hej med dig"));
            Assert.AreEqual(0, worker.WordCount(""));
            //Assert.AreEqual(0, worker.WordCount("   hej"));
        }

        [TestMethod]
        public void DoClientTest()
        {
            
        }
    }
}
