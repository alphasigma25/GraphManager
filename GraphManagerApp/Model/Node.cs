using System.Collections.Generic;

namespace GraphManagerApp.Model;

public class Node {

    public Node(int id) {
        Id = id;
        Edges = new List<Edge>();
    }

    public void Delete() {
        Edges.Clear();
    }

    public int Id { get; set; }
    public List<Edge> Edges { get; set; }

    public List<Node> Neighbours() {
        List<Node> nodes = new List<Node>();
        Edges.ForEach(e => {
            if (e.N1.Id == Id || e.N2.Id == Id) {
                nodes.Add(this);
            }
        });
        return nodes;
    }
}

