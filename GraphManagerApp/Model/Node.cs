using System.Collections.Generic;

namespace GraphManagerApp.Model;

public class Node {

    public Node() {
        Id = NodesCount++;
        Edges = new();
    }

    public void Delete() {
        Edges.ForEach(e => {
            if (e.N1.Id != Id) {
                e.N1.Edges.Remove(e);
            } else if (e.N2.Id != Id) {
                e.N2.Edges.Remove(e);
            }
        });
        Edges.Clear();
    }

    public int Id { get; set; }
    public List<Edge> Edges { get; set; }

    public IEnumerable<Node> Neighbours() {
        foreach (var e in Edges) {
            if (e.N1 == this) {
                yield return e.N2;
            } else if (e.N2 == this) {
                yield return e.N1;
            }
        };
    }

    private static int NodesCount = 0;
}

