Imports DevExpress.Xpf.Charts
Imports System.Windows.Media

Namespace CheckBoxesInLegendExample_BoundMode

    Friend Class SeriesNonVisualWrapper

        Public Property Series() As Series
        Public Property MarkerBrush() As Brush
        Public Property MarkerLineBrush() As Brush

        ' This property is bound to legend marker template.
        Public Property MarkerLineStyle() As DevExpress.Xpf.Charts.LineStyle

        Public Sub New(ByVal series As Series, ByVal markerBrush As Brush)
            Me.Series = series
            Me.MarkerBrush = markerBrush
            MarkerLineStyle = New DevExpress.Xpf.Charts.LineStyle(1)
            MarkerLineBrush = markerBrush
        End Sub
    End Class
End Namespace