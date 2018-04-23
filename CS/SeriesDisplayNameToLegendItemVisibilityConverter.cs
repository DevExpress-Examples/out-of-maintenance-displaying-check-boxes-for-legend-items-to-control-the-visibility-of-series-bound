using System;
using System.Windows;
using System.Windows.Data;

namespace CheckBoxesInLegendExample_BoundMode {

    //This converter is used to hide the fake series from the legend
    class SeriesDisplayNameToLegendItemVisibilityConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            string displayName = (string)value;
            if(displayName == "fakeSeries")
                return Visibility.Collapsed;
            else
                return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }

}
