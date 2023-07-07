using GraphManager.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GraphManagerApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        graph = new ViewModel();
        DataContext = graph;

        InitializeComponent();
    }
    private ViewModel graph;

    private void OnClickAddNode(object sender, MouseButtonEventArgs e) {
        Point pos = e.GetPosition(MyCanvas);
        graph.AddNode(pos.X - 25, pos.Y - 25);
    }

    private Node? selected = null;
    private void OnNodeClick(object sender, MouseButtonEventArgs e) {
        if (sender is Shape activeNode) {
            if (Remove.IsChecked == true) {
                graph.DeleteNode((Node)activeNode.DataContext);
            } else if (AddEdge.IsChecked == true) {
                if (selected == null) {
                    selected = (Node)activeNode.DataContext;
                } else {
                    graph.AddEdge(selected, (Node)activeNode.DataContext);
                    selected = null;
                }
            }
        }
    }

    private void OnEdgeClick(object sender, MouseButtonEventArgs e) {
        if (Remove.IsChecked == true) {
            if (sender is Shape activeNode) {
                graph.DeleteEdge((Edge)activeNode.DataContext);
            }
        }
    }

    private void ManageLeftButtonDown(object sender, MouseButtonEventArgs e) {
        if (AddNode.IsChecked == true) {
            OnClickAddNode(sender, e);
        }
    }
}


