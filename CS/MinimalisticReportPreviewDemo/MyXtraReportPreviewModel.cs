using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;

namespace MinimalisticReportPreviewDemo {
    public class MyXtraReportPreviewModel : XtraReportPreviewModel {
        public MyXtraReportPreviewModel(XtraReport report) : base(report) { }

        protected override void Export(object parameter) {
            if(parameter != null) {
                if(parameter.ToString() == "Xls") {
                    PrintingSystem.ExportToXls("test.xls");
                    System.Windows.MessageBox.Show("!");
                    System.Diagnostics.Process.Start("test.xls");
                } else
                    base.Export(parameter);
            }
        }
    }
}
