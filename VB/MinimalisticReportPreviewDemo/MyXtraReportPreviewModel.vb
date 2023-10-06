Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports.UI

Namespace MinimalisticReportPreviewDemo

    Public Class MyXtraReportPreviewModel
        Inherits XtraReportPreviewModel

        Public Sub New(ByVal report As XtraReport)
            MyBase.New(report)
        End Sub

        Protected Overrides Sub Export(ByVal parameter As Object)
            If parameter IsNot Nothing Then
                If Equals(parameter.ToString(), "Xls") Then
                    PrintingSystem.ExportToXls("test.xls")
                    System.Windows.MessageBox.Show("!")
                    System.Diagnostics.Process.Start("test.xls")
                Else
                    MyBase.Export(parameter)
                End If
            End If
        End Sub
    End Class
End Namespace
