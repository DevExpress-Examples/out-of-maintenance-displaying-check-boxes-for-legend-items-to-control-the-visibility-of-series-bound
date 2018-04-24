Imports DevExpress.Xpf.Charts
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Windows.Media

Namespace CheckBoxesInLegendExample_BoundMode

    ' To simplify this example, this class is not a descendant of the DependencyObject class   
    Friend Class ViewModel

        Private seriesNonVisualWrappersCollection_Renamed As New ObservableCollection(Of SeriesNonVisualWrapper)()
        Private seriesCollection As SeriesCollection
        Private palette As Palette

        Public ReadOnly Property SeriesNonVisualWrappersCollection() As ObservableCollection(Of SeriesNonVisualWrapper)
            Get
                Return seriesNonVisualWrappersCollection_Renamed
            End Get
        End Property
        Private privateChartData As ObservableCollection(Of DataItem)
        Public Property ChartData() As ObservableCollection(Of DataItem)
            Get
                Return privateChartData
            End Get
            Private Set(ByVal value As ObservableCollection(Of DataItem))
                privateChartData = value
            End Set
        End Property

        Public Sub New(ByVal chartData As ObservableCollection(Of DataItem), ByVal seriesCollection As SeriesCollection, ByVal palette As Palette)
            Me.seriesCollection = seriesCollection
            Me.palette = palette
            Me.ChartData = chartData
            UpdateSeriesWrapperCollection()
        End Sub

        Public Sub UpdateSeriesWrapperCollection()
            Me.seriesNonVisualWrappersCollection_Renamed.Clear()
            For i As Integer = 0 To seriesCollection.Count - 1
                SeriesNonVisualWrappersCollection.Add(New SeriesNonVisualWrapper(Me.seriesCollection(i), New SolidColorBrush(Me.palette(i))))
            Next i
        End Sub
    End Class

End Namespace
