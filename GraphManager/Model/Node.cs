namespace GraphManager.Model;

public record class Node(double X = 0, double Y = 0) {

    public IEnumerable<Edge> Delete() {
        foreach (var e in Edges) {
            if (e.N1 != this) {
                e.N1.Edges.Remove(e);
            } else if (e.N2 != this) {
                e.N2.Edges.Remove(e);
            } else {
                // on préfère qu'il y ait une erreur ici car
                // en écrivant le code je suis parti du principe qu'on arriverait
                // jamais ici, mais si un jour le code change, ça serait bien 
                // prévenir
                throw new Exception("Edge not linked to node edge list");
            }
            yield return e;
        }
        Edges.Clear();
    }

    public List<Edge> Edges { get; set; } = new();

    public IEnumerable<Node> Neighbours() {
        foreach (var e in Edges) {
            if (e.N1 == this) {
                yield return e.N2;
            } else if (e.N2 == this) {
                yield return e.N1;
            } else {
                throw new Exception("Edge not linked to node in edge list");
            }
        };
    }
}

