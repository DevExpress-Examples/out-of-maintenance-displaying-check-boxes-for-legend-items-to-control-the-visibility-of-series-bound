Imports Microsoft.VisualBasic
Imports DevExpress.Xpf.Charts
Imports System.Windows.Media

Namespace CheckBoxesInLegendExample_BoundMode

	Friend Class SeriesNonVisualWrapper

		Private privateSeries As Series
		Public Property Series() As Series
			Get
				Return privateSeries
			End Get
			Set(ByVal value As Series)
				privateSeries = value
			End Set
		End Property
		Private privateMarkerBrush As Brush
		Public Property MarkerBrush() As Brush
			Get
				Return privateMarkerBrush
			End Get
			Set(ByVal value As Brush)
				privateMarkerBrush = value
			End Set
		End Property
		Private privateMarkerLineBrush As Brush
		Public Property MarkerLineBrush() As Brush
			Get
				Return privateMarkerLineBrush
			End Get
			Set(ByVal value As Brush)
				privateMarkerLineBrush = value
			End Set
		End Property

		' This property is binded to legend marker template.
		Private privateMarkerLineStyle As DevExpress.Xpf.Charts.LineStyle
		Public Property MarkerLineStyle() As DevExpress.Xpf.Charts.LineStyle
			Get
				Return privateMarkerLineStyle
			End Get
			Set(ByVal value As DevExpress.Xpf.Charts.LineStyle)
				privateMarkerLineStyle = value
			End Set
		End Property

		Public Sub New(ByVal series As Series, ByVal markerBrush As Brush)
			Series = series
			MarkerBrush = markerBrush
			MarkerLineStyle = New DevExpress.Xpf.Charts.LineStyle(1)
			MarkerLineBrush = markerBrush
		End Sub
	End Class
End Namespace