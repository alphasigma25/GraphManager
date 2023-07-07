using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace GraphManagerApp;
public class DecalageConverter : IValueConverter {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
        return (double)value + 25;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
        return (double)value - 25;
    }
}

