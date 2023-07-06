using GraphManagerApp.Model;

namespace GraphManagerTest {
    [TestClass]
    public class EdgeTest {
        [TestMethod]
        public void CreateEdge() {
            Node n1 = new(0);
            Node n2 = new(1);

            Edge e = new(n1, n2);

            Assert.AreEqual(e.N1, n1);
            Assert.AreEqual(e.N2, n2);
        }
    }
}