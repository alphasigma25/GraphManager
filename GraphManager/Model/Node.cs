using System.Collections.Generic;

namespace GraphManager.Model;

public class Node {

    public void Delete() {
        Edges.ForEach(e => {
            if (e.N1 != this) {
                e.N1.Edges.Remove(e);
            } else if (e.N2 != this) {
                e.N2.Edges.Remove(e);
            }
        });
        Edges.Clear();
    }

    public List<Edge> Edges { get; set; } = new();

    public IEnumerable<Node> Neighbours() {
        foreach (var e in Edges) {
            if (e.N1 == this) {
                yield return e.N2;
            } else if (e.N2 == this) {
                yield return e.N1;
            }
        };
    }
}

