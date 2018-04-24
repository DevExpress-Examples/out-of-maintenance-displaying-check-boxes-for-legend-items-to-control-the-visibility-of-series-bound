Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports System.Windows

Namespace CheckBoxesInLegendExample_BoundMode

    Partial Public Class MainWindow
        Inherits Window

        Private viewModel As ViewModel
        Private chartData As New ObservableCollection(Of DataItem) From { _
            New DataItem() With {.Series="fakeSeries"}, _
            New DataItem() With { _
                .Series="Series1", _
                .Argument=1, _
                .Value=1 _
            }, _
            New DataItem() With { _
                .Series="Series1", _
                .Argument=2, _
                .Value=1 _
            }, _
            New DataItem() With { _
                .Series="Series2", _
                .Argument=1, _
                .Value=2 _
            }, _
            New DataItem() With { _
                .Series="Series2", _
                .Argument=2, _
                .Value=2 _
            } _
        }

        Public Sub New()
            InitializeComponent()
            viewModel = New ViewModel(chartData, chart.Diagram.Series, chart.Palette)
            AddHandler chart.Diagram.Series.CollectionChanged, AddressOf Series_CollectionChanged
            DataContext = viewModel
        End Sub

        Private Sub Series_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
            viewModel.UpdateSeriesWrapperCollection()
        End Sub
        Private Sub addSeries_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim seriesCount As Integer = chart.Diagram.Series.Count
            Dim item As New DataItem()
            item.Series = "Series" & seriesCount
            item.Argument = 1
            item.Value = 1
            chartData.Add(item)
            Dim item2 As New DataItem()
            item2.Series = "Series" & seriesCount
            item2.Argument = 2
            item2.Value = 3
            chartData.Add(item2)
        End Sub
        Private Sub deleteSeries_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If chartData.Count > 1 Then
                chartData.RemoveAt(chartData.Count - 1)
                chartData.RemoveAt(chartData.Count - 1)
            End If
        End Sub
    End Class

End Namespace