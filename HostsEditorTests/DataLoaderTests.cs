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
            Assert.AreEqual(3, dataLoader.hosts[2].fileRow);
            Assert.AreEqual("127.66.6.6", dataLoader.hosts[2].ip);
            Assert.AreEqual("iaero.local", dataLoader.hosts[2].host);
            Assert.AreEqual(4, dataLoader.hosts[3].fileRow);
            Assert.AreEqual("127.4.5.6", dataLoader.hosts[3].ip);
            Assert.AreEqual("iaero.local.2", dataLoader.hosts[3].host);
        }

        [TestMethod()]
        public void AddHostToFileTest()
        {
            DataLoader dataLoader = new DataLoader();
            HostRow testData = new HostRow(0, "127.0.3.1 test.data");

            dataLoader.path = "hostsTestData.txt";

            Assert.IsTrue(dataLoader.AddHostToFile(testData));
        }
    }
}