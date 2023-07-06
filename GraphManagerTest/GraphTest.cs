using GraphManager;

// pas besoin
namespace GraphManagerTest {
    [TestClass]
    public class GraphTest {
        [TestMethod]
        public void TestAddNode() {
            Graph g = new Graph();
            g.AddNode();
            g.AddNode();

            Assert.AreEqual(g.NodesCount, 2);
        }
    }
}