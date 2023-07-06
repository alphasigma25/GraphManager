using GraphManager;
using GraphManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphManagerApp;
internal class ViewModel {
    public ViewModel() {

    }

    public List<PositionalNode> Nodes { get; } = new() {
        new(new(), 100, 200),
        new(new(), 30, 20)
    };
    public List<Edge> Edges { get; } = new();
}

