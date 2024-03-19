<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4482)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Reporting for WPF - Override Export Command in Document Preview

This example demonstrates how to override commands in [DocumentPreview](https://docs.devexpress.com/WPF/9697/controls-and-libraries/printing-exporting/concepts/document-preview). The technique is to create a descendant of [DocumentPreviewControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.DocumentPreviewControl) and override its methods, in this example `Export`.

![Reporting for WinForms - Override Export Command in Document Preview](Images/screenshot.png)

## Files to Review:

* [MainWindow.xaml.cs](./CS/ReportingWpfOverrideExportCommand/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ReportingWpfOverrideExportCommandVB/MainWindow.xaml.vb))
* **[MyDocumentPreviewControl.cs](./CS/ReportingWpfOverrideExportCommand/MyDocumentPreviewControl.cs) (VB: [MyDocumentPreviewControl.vb](./VB/ReportingWpfOverrideExportCommandVB/MyDocumentPreviewControl.vb))**

## Documentation

- [Override Document Preview Commands](https://docs.devexpress.com/XtraReports/115362/wpf-reporting/wpf-reporting-document-preview/api-and-customization/override-document-preview-commands)

## More Examples

- [Reporting for WPF - Override Print and PrintDirect (Quick Print) Commands in Document Preview](https://github.com/DevExpress-Examples/reporting-wpf-override-print-commands)
