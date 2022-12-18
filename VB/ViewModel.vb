Imports DevExpress.Xpf.Charts
Imports System.Collections.ObjectModel
Imports System.Windows.Media

Namespace CheckBoxesInLegendExample_BoundMode

    ' To simplify this example, this class is not a descendant of the DependencyObject class   
    Friend Class ViewModel

        Private _ChartData As ObservableCollection(Of CheckBoxesInLegendExample_BoundMode.DataItem)

        Private seriesNonVisualWrappersCollectionField As ObservableCollection(Of SeriesNonVisualWrapper) = New ObservableCollection(Of SeriesNonVisualWrapper)()

        Private seriesCollection As SeriesCollection

        Private palette As Palette

        Public ReadOnly Property SeriesNonVisualWrappersCollection As ObservableCollection(Of SeriesNonVisualWrapper)
            Get
                Return seriesNonVisualWrappersCollectionField
            End Get
        End Property

        Public Property ChartData As ObservableCollection(Of DataItem)
            Get
                Return _ChartData
            End Get

            Private Set(ByVal value As ObservableCollection(Of DataItem))
                _ChartData = value
            End Set
        End Property

        Public Sub New(ByVal chartData As ObservableCollection(Of DataItem), ByVal seriesCollection As SeriesCollection, ByVal palette As Palette)
            Me.seriesCollection = seriesCollection
            Me.palette = palette
            Me.ChartData = chartData
            UpdateSeriesWrapperCollection()
        End Sub

        Public Sub UpdateSeriesWrapperCollection()
            seriesNonVisualWrappersCollectionField.Clear()
            For i As Integer = 0 To seriesCollection.Count - 1
                SeriesNonVisualWrappersCollection.Add(New SeriesNonVisualWrapper(seriesCollection(i), New SolidColorBrush(palette(i))))
            Next
        End Sub
    End Class
End Namespace
