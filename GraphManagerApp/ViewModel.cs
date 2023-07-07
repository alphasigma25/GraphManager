using GraphManager;
using GraphManager.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GraphManagerApp;
internal class ViewModel {
    public ViewModel() {
        Edges.Add(Edge.Create(Nodes[0], Nodes[1]));
    }

    public void AddNode(double x, double y) {
        Nodes.Add(new(x, y));
    }

    public void AddEdge(Node n1, Node n2) {
        Edges.Add(Edge.Create(n1, n2));
    }

    public void DeleteNode(Node n) {
        foreach (Edge e in n.Delete()) {
            Edges.Remove(e);
        }
        Nodes.Remove(n);
    }

    public void DeleteEdge(Edge e) {
        e.Delete();
        Edges.Remove(e);
    }

    public ObservableCollection<Node> Nodes { get; } = new() {
        new(100, 200),
        new(30, 20)
    };

    public ObservableCollection<Edge> Edges { get; } = new();
}

