using GraphManager.Model;

namespace GraphManagerTest {
    [TestClass]
    public class EdgeTest {
        [TestMethod]
        public void NewEdgeIsOnNodesEdgesList() {
            Node n1 = new();
            Node n2 = new();

            Edge e = Edge.Create(n1, n2);

            Assert.AreEqual(e.N1, n1);
            Assert.AreEqual(e.N2, n2);
        }

        [TestMethod]
        public void DeletedEdgeIsNotOnNodesEdgeList() {
            Node n1 = new();
            Node n2 = new();

            Edge e = Edge.Create(n1, n2);
            e.Delete();

            Assert.AreEqual(n1.Neighbours().ToList().Count, 0);
            Assert.AreEqual(n1.Neighbours().ToList().Count, 0);
        }
    }
}