Imports System.Text
Imports DevExpress.Xpf.Core
Imports ReportingWpfOverrideExportCommandVB.ReportingWpfOverrideExportCommand

''' <summary>
''' Interaction logic for MainWindow.xaml
''' </summary>
Partial Public Class MainWindow
	Inherits ThemedWindow
	Public Sub New()
		ApplicationThemeHelper.ApplicationThemeName = Theme.Office2016WhiteName
		InitializeComponent()
	End Sub
	Private Sub ShowPreview(ByVal sender As Object, ByVal e As RoutedEventArgs)
		Dim report As New XtraReport1()
		Dim preview = New MyDocumentPreviewControl() With {.DocumentSource = report}
		Dim window = New DXWindow() With {.Content = preview}
		report.CreateDocument(True)
		window.ShowDialog()
	End Sub
End Class
