using System.Collections.Generic;

namespace GraphManagerApp.Model;
public class Graph {

    public Graph() {
        Nodes = new List<Node>();
        Edges = new List<Edge>();
    }

    public void AddNode() {
        Nodes.Add(new Node());
    }

    public void DeleteNode(Node n) {
        n.Delete();
        Nodes.Remove(n);
    }

    public void AddEdge(Node n1, Node n2) {
        Edges.Add(new Edge(n1, n2));
    }

    public void DeleteEdge(Edge e) {
        Edges.Remove(e);
    }

    private List<Node> Nodes;
    private List<Edge> Edges;

}

