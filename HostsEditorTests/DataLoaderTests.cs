using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HostsEditor.Utils.Tests
{
    [TestClass()]
    public class DataLoaderTests
    {
        [TestMethod()]
        public void LoadHostsFromFileTest()
        {
            DataLoader dataLoader = new DataLoader();

            dataLoader.path = "hostsTestData.txt";
            dataLoader.LoadHostsFromFile();

            Assert.AreEqual(1, dataLoader.hosts[0].fileRow);
            Assert.AreEqual("127.0.0.1", dataLoader.hosts[0].ip);
            Assert.AreEqual("iaero.me.local", dataLoader.hosts[0].host);
            Assert.AreEqual(2, dataLoader.hosts[1].fileRow);
            Assert.AreEqual("127.1.1.1", dataLoader.hosts[1].ip);
            Assert.AreEqual("iaero.me.dev", dataLoader.hosts[1].host);
        }
    }
}