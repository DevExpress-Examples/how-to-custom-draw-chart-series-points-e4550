Imports System
Imports System.Windows
Imports System.Windows.Media
Imports DevExpress.Xpf.Charts

Namespace CustomDrawChart

	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chbCustomDraw_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If chart IsNot Nothing Then
				chart.UpdateData()
			End If
		End Sub

		Private Sub chbCustomDraw_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If chart IsNot Nothing Then
				chart.UpdateData()
			End If
		End Sub

		Private Sub chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
			If CBool(chbCustomDraw.IsChecked) Then
				Dim color As String = CorrectDrawOptions(e.SeriesPoint.Value, e.DrawOptions)
				If Not String.IsNullOrEmpty(color) Then
					e.LabelText = color & ": " & e.LabelText
				End If
			End If
		End Sub

		Private Function CorrectDrawOptions(ByVal val As Double, ByVal drawOptions As DrawOptions) As String
			If drawOptions Is Nothing Then
				Return ""
			End If
			If val < 1 Then
				drawOptions.Color = Color.FromArgb(&HFF, &H51, &H89, &H3)
				Return "Green"
			ElseIf val < 2 Then
				drawOptions.Color = Color.FromArgb(&HFF, &HF9, &HAA, &HF)
				Return "Yellow"
			Else
				drawOptions.Color = Color.FromArgb(&HFF, &HC7, &H39, &HC)
				Return "Red"
			End If
		End Function
	End Class
End Namespace

