using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HostsEditor.Utils.Tests
{
    [TestClass()]
    public class DataManagerTests
    {
        /// <summary>
        /// Test to compare a hosts file with varying user data inputs to model outcomes.
        /// The test will pass if the program parses the hosts file inputs correctly.
        /// </summary>
        [TestMethod()]
        public void LoadHostsFromFileTest()
        {
            DataManager dataManager = new DataManager();

            dataManager.path = "hostsTestData.txt";
            dataManager.LoadHostsFromFile();

            Assert.AreEqual(1, dataManager.Hosts[0].FileRow);
            Assert.AreEqual("127.0.0.1", dataManager.Hosts[0].IP);
            Assert.AreEqual("iaero.me.local", dataManager.Hosts[0].Host);
            Assert.AreEqual(2, dataManager.Hosts[1].FileRow);
            Assert.AreEqual("127.1.1.1", dataManager.Hosts[1].IP);
            Assert.AreEqual("iaero.me.dev", dataManager.Hosts[1].Host);
            Assert.AreEqual(3, dataManager.Hosts[2].FileRow);
            Assert.AreEqual("127.66.6.6", dataManager.Hosts[2].IP);
            Assert.AreEqual("iaero.local", dataManager.Hosts[2].Host);
            Assert.AreEqual(4, dataManager.Hosts[3].FileRow);
            Assert.AreEqual("127.4.5.6", dataManager.Hosts[3].IP);
            Assert.AreEqual("iaero.local.2", dataManager.Hosts[3].Host);
        }

        /// <summary>
        /// Test to test adding a new entry to the hosts file.
        /// The test will pass if the program was able to add the new entry successfully.
        /// </summary>
        [TestMethod()]
        public void AddHostToFileTest()
        {
            DataManager dataManager = new DataManager();
            HostRow testData = new HostRow(0, "127.0.3.1 test.data");

            dataManager.path = "hostsTestData.txt";

            Assert.IsTrue(dataManager.AddHostToFile(testData));
        }

        /// <summary>
        /// Test to test updating line in the hosts file.
        /// The test will pass if the program was able to update the row and the value is updated.
        /// </summary>
        [TestMethod()]
        public void UpdateHostTest()
        {
            DataManager dataManager = new DataManager();
            HostRow testData = new HostRow(1, "127.0.0.11", "iaero.me.local.test");

            dataManager.path = "hostsTestData.txt";
            dataManager.LoadHostsFromFile();

            Assert.IsTrue(dataManager.UpdateHost(testData));

            dataManager.LoadHostsFromFile();

            Assert.AreEqual("127.0.0.11", dataManager.Hosts[0].IP);
            Assert.AreEqual("iaero.me.local.test", dataManager.Hosts[0].Host);
        }

        /// <summary>
        /// Test to test deleting line in the hosts file.
        /// The test will pass if the program was able to delete the row.
        /// </summary>
        [TestMethod()]
        public void DeleteHostTest()
        {
            DataManager dataManager = new DataManager();

            dataManager.path = "hostsTestData.txt";
            dataManager.LoadHostsFromFile();

            Assert.IsTrue(dataManager.DeleteHost(1)); // delete host on line 2

            dataManager.LoadHostsFromFile();

            Assert.AreEqual("127.1.1.1", dataManager.Hosts[0].IP);
        }
    }
}
