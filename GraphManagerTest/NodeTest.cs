using GraphManager.Model;

namespace GraphManagerTest;
[TestClass]
public class NodeTest {

    [TestMethod]
    public void NeighboursNodesAreConnected() {
        Node n1 = new();
        Node n2 = new();
        Edge.Create(n1, n2);

        Assert.AreEqual(n1.Neighbours().First(), n2);
        Assert.AreEqual(n2.Neighbours().First(), n1);
    }

    [TestMethod]
    public void DeletedNodeIsNotOnNeighbourListOfOtherNodes() {
        // Si on supprime un node, il faut v�rifier que les
        // noeuds auquel il �tait li� ne sont plus connect� � l'arr�te
        Node n1 = new();
        Node n2 = new();
        Node n3 = new();
        Node n4 = new();

        #region edgesCreation
        Edge.Create(n1, n2);
        Edge.Create(n1, n3);
        Edge.Create(n1, n4);
        Edge.Create(n2, n4);
        Edge.Create(n3, n4);
        Edge.Create(n2, n3);
        #endregion

        // on va supprimer le node n1
        // avant, on v�rifie que n1 est reli� aux autres noeuds
        Assert.IsTrue(n1.Neighbours().ToHashSet().SetEquals(new HashSet<Node>() { n2, n3, n4 }));

        n1.Delete();

        // puis on v�rifie que n2 n'est plus reli� aux autres noeuds
        Assert.IsFalse(n2.Neighbours().Contains(n1));
        Assert.IsFalse(n3.Neighbours().Contains(n1));
        Assert.IsFalse(n4.Neighbours().Contains(n1));
    }
}
