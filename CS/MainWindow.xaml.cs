using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;

namespace CheckBoxesInLegendExample_BoundMode {
    
    public partial class MainWindow : Window {

        ViewModel viewModel;
        ObservableCollection<DataItem> chartData = new ObservableCollection<DataItem>{
            new DataItem(){Series="fakeSeries"},//This series source is used to support showing the legend when all other series are invisible
            new DataItem(){Series="Series1", Argument=1, Value=1},
            new DataItem(){Series="Series1", Argument=2, Value=1},
            new DataItem(){Series="Series2", Argument=1, Value=2},
            new DataItem(){Series="Series2", Argument=2, Value=2}
        };

        public MainWindow() {
            InitializeComponent();
            viewModel = new ViewModel(chartData, chart.Diagram.Series, chart.Palette);
            chart.Diagram.Series.CollectionChanged += Series_CollectionChanged;
            DataContext = viewModel;
        }

        void Series_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) {
            viewModel.UpdateSeriesWrapperCollection();
        }
        void addSeries_Click_1(object sender, RoutedEventArgs e) {
            int seriesCount = chart.Diagram.Series.Count;
            DataItem item = new DataItem();
            item.Series = "Series" + seriesCount;
            item.Argument = 1;
            item.Value = 1;
            chartData.Add(item);
            DataItem item2 = new DataItem();
            item2.Series = "Series" + seriesCount;
            item2.Argument = 2;
            item2.Value = 3;
            chartData.Add(item2);
        }
        void deleteSeries_Click_1(object sender, RoutedEventArgs e) {
            if(chartData.Count > 1) {
                chartData.RemoveAt(chartData.Count - 1);
                chartData.RemoveAt(chartData.Count - 1);
            }
        }
    }

}