Imports Microsoft.VisualBasic
Imports System
Namespace CheckBoxesInLegendExample_BoundMode

	Friend Class DataItem
		Private privateSeries As String
		Public Property Series() As String
			Get
				Return privateSeries
			End Get
			Set(ByVal value As String)
				privateSeries = value
			End Set
		End Property
		Private privateArgument As Double
		Public Property Argument() As Double
			Get
				Return privateArgument
			End Get
			Set(ByVal value As Double)
				privateArgument = value
			End Set
		End Property
		Private privateValue As Double
		Public Property Value() As Double
			Get
				Return privateValue
			End Get
			Set(ByVal value As Double)
				privateValue = value
			End Set
		End Property
	End Class

End Namespace
