using GraphManager.Model;

namespace GraphManager;
internal class PositionalNode {
    public Node Node { get; }
    public double X { get; set; }
    public double Y { get; set; }
    public PositionalNode(Node node, double x, double y) {
        Node = node;
        X = x;
        Y = y;
    }
}

/* question : est-ce que les edge on besoin d'un PositionalEdge ?
 * probablement pas parce que pour l'affichage, on a seulement besoin
 * des deux node de l'edge
 * 
 * problématique d'avoir plusieurs edge entre les deux mêmes nodes
 * idée 1 : empêcher d'avoir plusieurs edge entre 2 m^ nodes
 * idée 2 : avoir des affichages différents quand plusieurs edge entre deux même nodes
 *          par exemple, le 1e edge est juste une ligne, les suivants sont des arcs 
 *          de cercles (avec très faible courbure) -> recalculer la courbure quand on
 *          bouge les nodes...
 * idée 3 : il y aura différents "types" de edge, on pourrait de toute façon ne pas 
 *          pouvoir avoir plusieurs edge de m^ type entre 2 nodes
 *          et ensuite on aurait des plans qui contiennent un type de edge, et on ne 
 *          peut afficher qu'un type de edge à la fois.
*/


