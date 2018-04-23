Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Data

Namespace CheckBoxesInLegendExample_BoundMode

	'This converter is used to hide the fake series from the legend
	Friend Class SeriesDisplayNameToLegendItemVisibilityConverter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim displayName As String = CStr(value)
			If displayName = "fakeSeries" Then
				Return Visibility.Collapsed
			Else
				Return Visibility.Visible
			End If
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class

End Namespace
