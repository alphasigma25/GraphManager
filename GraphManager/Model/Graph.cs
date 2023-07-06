using System.Collections.Generic;

namespace GraphManager.Model;

//finalement pas besoin

public class Graph {
    public Graph() {
        //utiliser des ObservableCollection plus tard plutôt que List
        Nodes = new List<Node>();
        Edges = new List<Edge>();
    }

    public int NodesCount { get { return Nodes.Count; } }
    public int EdgeCount { get { return Edges.Count; } }

    public Node AddNode() {
        Node n = new();
        Nodes.Add(n);
        return n;
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
