<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598034/12.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4482)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MinimalisticReportPreviewDemo/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MinimalisticReportPreviewDemo/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MinimalisticReportPreviewDemo/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MinimalisticReportPreviewDemo/MainWindow.xaml.vb))
* **[MyXtraReportPreviewModel.cs](./CS/MinimalisticReportPreviewDemo/MyXtraReportPreviewModel.cs) (VB: [MyXtraReportPreviewModel.vb](./VB/MinimalisticReportPreviewDemo/MyXtraReportPreviewModel.vb))**
<!-- default file list end -->
# DocumentPreviewControl - How to override the Export command 


<p>This example demonstrates how to override commands in the <a href="https://documentation.devexpress.com/#WPF/CustomDocument9697">Document Preview</a> (<a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfPrintingDocumentPreviewControltopic">DocumentPreviewControl</a>). Create a DocumentPreviewControl descendant and override the required (e.g., Export) methods.<br><strong><br>See also</strong><strong>:<br></strong><a href="https://www.devexpress.com/Support/Center/p/E4631">DocumentPreviewControl - How to override the Print and PrintDirect (Quick Print) commands</a> <strong><br></strong><a href="https://www.devexpress.com/Support/Center/p/E2974">How to remove standard bar items and add custom ones to the DocumentPreview toolbar</a></p>


<h3>Description</h3>

The&nbsp;solution demonstrates how to achieve this for <strong>DocumentPreview </strong>by creating a descendant of the XtraReportPreviewModel class.

<br/>


