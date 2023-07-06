using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GraphManagerApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void OnClickAddNode(object sender, MouseButtonEventArgs e) {
        AddNodeOnCanvas(MyCanvas,
            Mouse.GetPosition(MyCanvas).X,
            Mouse.GetPosition(MyCanvas).Y, 50);
    }

    private void OnClickRemove(object sender, MouseButtonEventArgs e) {
        if (e.OriginalSource is Shape) {
            Shape activeRec = (Shape)e.OriginalSource;
            MyCanvas.Children.Remove(activeRec);
        }
    }


    private Point startPoint;

    private void OnClickAddEdge(object sender, MouseButtonEventArgs e) {

        Ellipse el = (Ellipse)sender;

        double cx = Canvas.GetLeft(el) + el.Width / 2;
        double cy = Canvas.GetTop(el) + el.Height / 2;

        if (startPoint == default) {
            startPoint = new Point(cx, cy);
        } else {
            AddLine(MyCanvas, startPoint.X, startPoint.Y, cx, cy);

            startPoint = default;
        }
    }

    private void ManageLeftButtonDown(object sender, MouseButtonEventArgs e) {
        // TODO amélioration : https://stackoverflow.com/questions/9212873/binding-radiobuttons-group-to-a-property-in-wpf
        if (AddNode.IsChecked == true) {
            OnClickAddNode(sender, e);
        } else if (Remove.IsChecked == true) {
            OnClickRemove(sender, e);
        }
    }

    private void AddNodeOnCanvas(Canvas myCanvas, double cx, double cy, double r) {
        Ellipse newCir = new Ellipse {
            Width = r,
            Height = r,
            Fill = Brushes.White,
            StrokeThickness = 1,
            Stroke = Brushes.Black
        };

        newCir.MouseDown += (object sender, MouseButtonEventArgs e) => {
            if (AddEdge.IsChecked == true) {
                OnClickAddEdge(sender, e);
            };
        };

        Canvas.SetLeft(newCir, cx - r / 2);
        Canvas.SetTop(newCir, cy - r / 2);
        myCanvas.Children.Add(newCir);
    }

    private void AddLine(Canvas myCanvas, double x1, double y1, double x2, double y2) {
        Line line = new Line {
            X1 = x1,
            Y1 = y1,
            X2 = x2,
            Y2 = y2,
            Stroke = Brushes.Black,
            StrokeThickness = 1
        };

        Panel.SetZIndex(line, -1);
        myCanvas.Children.Add(line);
    }


}


