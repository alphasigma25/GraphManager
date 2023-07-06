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
        AddCircle(MyCanvas,
            Mouse.GetPosition(MyCanvas).X,
            Mouse.GetPosition(MyCanvas).Y, 50);
    }

    private void OnClickRemove(object sender, MouseButtonEventArgs e) {
        if (e.OriginalSource is Shape) {
            Shape activeRec = (Shape)e.OriginalSource;
            MyCanvas.Children.Remove(activeRec);
        }
    }

    private void OnClickAddEdge(object sender, MouseButtonEventArgs e) {
        throw new NotImplementedException();
    }
    private void ManageLeftButtonDown(object sender, MouseButtonEventArgs e) {
        if (AddNode.IsChecked == true) {
            OnClickAddNode(sender, e);
        } else if (AddEdge.IsChecked == true) {
            OnClickAddEdge(sender, e);
        } else if (Remove.IsChecked == true) {
            OnClickRemove(sender, e);
        }
    }
    private void MouseAddOrDelete(object sender, MouseButtonEventArgs e) {
        if (e.OriginalSource is Shape) {
            Shape activeRec = (Shape)e.OriginalSource;
            MyCanvas.Children.Remove(activeRec);
        } else {

        }
    }
    private void ToggleButtonManageClick(ToggleButton button, Action OnCheck, Action OnUnckeck) {
        if (button.IsChecked == true) {
            OnCheck.Invoke();
        }
        if (button.IsChecked == false) {
            OnUnckeck.Invoke();
        }
    }
    private void AddRectangle(Canvas myCanvas, double cx, double cy, int w, int h) {
        Rectangle newRec = new Rectangle {
            Width = w,
            Height = h,
            Fill = Brushes.White,
            StrokeThickness = 1,
            Stroke = Brushes.Black
        };

        Canvas.SetLeft(newRec, cx);
        Canvas.SetTop(newRec, cy);
        myCanvas.Children.Add(newRec);
    }
    private void AddCircle(Canvas myCanvas, double cx, double cy, double r) {
        Ellipse newCir = new Ellipse {
            Width = r,
            Height = r,
            Fill = Brushes.White,
            StrokeThickness = 1,
            Stroke = Brushes.Black
        };

        Canvas.SetLeft(newCir, cx - r / 2);
        Canvas.SetTop(newCir, cy - r / 2);
        myCanvas.Children.Add(newCir);
    }


}


