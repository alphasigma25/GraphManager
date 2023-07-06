using GraphManagerApp.Model;

namespace GraphManagerTest {
    [TestClass]
    public class NodeTest {
        [TestMethod]
        public void TestAddNode() {
            Node n = new Node();
            Assert.AreEqual(n.Id, 0);
        }

        [TestMethod]
        public void TestDeleteNode() {

        }
    }
}