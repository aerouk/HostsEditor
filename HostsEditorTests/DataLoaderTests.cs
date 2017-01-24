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

            Assert.AreEqual(1, dataLoader.Hosts[0].FileRow);
            Assert.AreEqual("127.0.0.1", dataLoader.Hosts[0].IP);
            Assert.AreEqual("iaero.me.local", dataLoader.Hosts[0].Host);
            Assert.AreEqual(2, dataLoader.Hosts[1].FileRow);
            Assert.AreEqual("127.1.1.1", dataLoader.Hosts[1].IP);
            Assert.AreEqual("iaero.me.dev", dataLoader.Hosts[1].Host);
            Assert.AreEqual(3, dataLoader.Hosts[2].FileRow);
            Assert.AreEqual("127.66.6.6", dataLoader.Hosts[2].IP);
            Assert.AreEqual("iaero.local", dataLoader.Hosts[2].Host);
            Assert.AreEqual(4, dataLoader.Hosts[3].FileRow);
            Assert.AreEqual("127.4.5.6", dataLoader.Hosts[3].IP);
            Assert.AreEqual("iaero.local.2", dataLoader.Hosts[3].Host);
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