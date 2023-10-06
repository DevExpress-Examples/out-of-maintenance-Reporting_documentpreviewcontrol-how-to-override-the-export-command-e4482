Imports System
Imports DevExpress.XtraReports.UI

Namespace MinimalisticReportPreviewDemo

    Public Class Report
        Inherits XtraReport

        Private Detail As DetailBand

        Private topMarginBand1 As TopMarginBand

        Private nwindDataSet1 As nwindDataSet

        Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter

        Private xrLabel1 As XRLabel

        Private ReportHeader As ReportHeaderBand

        Private xrLabel2 As XRLabel

        Private bottomMarginBand1 As BottomMarginBand

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub InitializeComponent()
            Detail = New DetailBand()
            xrLabel1 = New XRLabel()
            topMarginBand1 = New TopMarginBand()
            bottomMarginBand1 = New BottomMarginBand()
            nwindDataSet1 = New nwindDataSet()
            productsTableAdapter = New nwindDataSetTableAdapters.ProductsTableAdapter()
            ReportHeader = New ReportHeaderBand()
            xrLabel2 = New XRLabel()
            CType(nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Detail.Controls.AddRange(New XRControl() {xrLabel1})
            Detail.HeightF = 33.00001F
            Detail.Name = "Detail"
            Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            xrLabel1.BookmarkParent = xrLabel2
            xrLabel1.DataBindings.AddRange(New XRBinding() {New XRBinding("Text", Nothing, "Products.ProductName"), New XRBinding("Bookmark", Nothing, "Products.ProductName")})
            xrLabel1.Font = New System.Drawing.Font("Arial", 9.75F)
            xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            xrLabel1.Name = "xrLabel1"
            xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel1.SizeF = New System.Drawing.SizeF(408.3333F, 23F)
            xrLabel1.StylePriority.UseFont = False
            xrLabel1.StylePriority.UseTextAlignment = False
            xrLabel1.Text = "xrLabel1"
            xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' topMarginBand1
            ' 
            topMarginBand1.HeightF = 48F
            topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            bottomMarginBand1.HeightF = 48F
            bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' nwindDataSet1
            ' 
            nwindDataSet1.DataSetName = "nwindDataSet"
            nwindDataSet1.SchemaSerializationMode = Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' productsTableAdapter
            ' 
            productsTableAdapter.ClearBeforeFill = True
            ' 
            ' ReportHeader
            ' 
            ReportHeader.Controls.AddRange(New XRControl() {xrLabel2})
            ReportHeader.HeightF = 47F
            ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel2
            ' 
            xrLabel2.Bookmark = "Home"
            xrLabel2.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold)
            xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            xrLabel2.Name = "xrLabel2"
            xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            xrLabel2.SizeF = New System.Drawing.SizeF(222.9167F, 23F)
            xrLabel2.StylePriority.UseFont = False
            xrLabel2.Text = "A sample report"
            ' 
            ' Report
            ' 
            Bands.AddRange(New Band() {Detail, topMarginBand1, bottomMarginBand1, ReportHeader})
            Bookmark = "Table of Contents"
            DataAdapter = productsTableAdapter
            DataMember = "Products"
            DataSource = nwindDataSet1
            Margins = New System.Drawing.Printing.Margins(49, 51, 48, 48)
            Version = "10.2"
            CType(nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        End Sub
    End Class
End Namespace
