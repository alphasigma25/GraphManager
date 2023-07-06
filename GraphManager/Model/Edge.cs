namespace GraphManager.Model;
public record class Edge(Node N1, Node N2) {

    public static Edge Create(Node n1, Node n2) {
        Edge e = new(n1, n2);
        n1.Edges.Add(e);
        n2.Edges.Add(e);
        return e;
    }

    public void Delete() {
        N1.Edges.Remove(this);
        N2.Edges.Remove(this);
    }
}
