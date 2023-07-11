Imports DevExpress.Xpf.Printing
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraPrinting
Imports DevExpress.Xpf.Printing.PreviewControl
Imports System.IO
Imports DevExpress.XtraPrinting.Native.ExportOptionsControllers

Namespace MinimalisticReportPreviewDemo
    Public Class MyDocumentPreviewControl
        Inherits DocumentPreviewControl

        Public Overrides Sub Export(ByVal format? As ExportFormat)
            If format.HasValue AndAlso format.Value = ExportFormat.Xls Then
                Dim optionsModel = ExportOptionsViewModel.Create(Document.PrintingSystem, format.Value)

                optionsModel.OpenFileAfterExport = False
                optionsModel.FileName = "test.xls"

                CType(New DocumentPublishEngine(Document.PrintingSystem), DocumentPublishEngine).Export(optionsModel)
                System.Windows.MessageBox.Show("!")
                System.Diagnostics.Process.Start("test.xls")
            Else
                MyBase.Export(format)
            End If
        End Sub

        Protected Overrides Sub Export(ByVal exportOptionsModel As ExportOptionsViewModel)
            If String.IsNullOrEmpty(Path.GetExtension(exportOptionsModel.FileName)) Then
                Dim extension = ExportOptionsControllerBase.GetControllerByOptions(exportOptionsModel.ExportOptions).GetFileExtension(exportOptionsModel.ExportOptions)
                exportOptionsModel.FileName += extension
            End If
            MyBase.Export(exportOptionsModel)
        End Sub
    End Class
End Namespace
