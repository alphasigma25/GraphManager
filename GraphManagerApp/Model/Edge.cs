
namespace GraphManagerApp.Model;
public class Edge {

    public Edge(Node n1, Node n2) {
        N1 = n1;
        N2 = n2;
        Id = EdgeCount++;
        n1.Edges.Add(this);
        n2.Edges.Add(this);
    }

    public int Id { get; set; }
    public Node N1 { get; set; }
    public Node N2 { get; set; }

    private static int EdgeCount = 0;

}
