Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports System.Windows

Namespace CheckBoxesInLegendExample_BoundMode

    Public Partial Class MainWindow
        Inherits Window

        Private viewModel As ViewModel

        Private chartData As ObservableCollection(Of DataItem) = New ObservableCollection(Of DataItem) From {New DataItem() With {.Series = "fakeSeries"}, New DataItem() With {.Series = "Series1", .Argument = 1, .Value = 1}, New DataItem() With {.Series = "Series1", .Argument = 2, .Value = 1}, New DataItem() With {.Series = "Series2", .Argument = 1, .Value = 2}, New DataItem() With {.Series = "Series2", .Argument = 2, .Value = 2}} 'This series source is used to support showing the legend when all other series are invisible

        Public Sub New()
            Me.InitializeComponent()
            viewModel = New ViewModel(chartData, Me.chart.Diagram.Series, Me.chart.Palette)
            AddHandler Me.chart.Diagram.Series.CollectionChanged, AddressOf Me.Series_CollectionChanged
            DataContext = viewModel
        End Sub

        Private Sub Series_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
            viewModel.UpdateSeriesWrapperCollection()
        End Sub

        Private Sub addSeries_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim seriesCount As Integer = Me.chart.Diagram.Series.Count
            Dim item As DataItem = New DataItem()
            item.Series = "Series" & seriesCount
            item.Argument = 1
            item.Value = 1
            chartData.Add(item)
            Dim item2 As DataItem = New DataItem()
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
