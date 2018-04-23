using DevExpress.Xpf.Printing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraPrinting;
using DevExpress.Xpf.Printing.PreviewControl;
using System.IO;
using DevExpress.XtraPrinting.Native.ExportOptionsControllers;

namespace MinimalisticReportPreviewDemo {
    public class MyDocumentPreviewControl : DocumentPreviewControl {
        public override void Export(ExportFormat? format) {
            if(format.HasValue && format.Value == ExportFormat.Xls) {
                var optionsModel = ExportOptionsViewModel.Create(Document.PrintingSystem, format.Value);

                optionsModel.OpenFileAfterExport = false;
                optionsModel.FileName = "test.xls";

                new DocumentPublishEngine(Document.PrintingSystem).Export(optionsModel);
                System.Windows.MessageBox.Show("!");
                System.Diagnostics.Process.Start("test.xls");
            } else {
                base.Export(format);
            }
        }

        protected override void Export(ExportOptionsViewModel exportOptionsModel) {
            if(string.IsNullOrEmpty(Path.GetExtension(exportOptionsModel.FileName))) {
                var extension = ExportOptionsControllerBase
                    .GetControllerByOptions(exportOptionsModel.ExportOptions)
                    .GetFileExtension(exportOptionsModel.ExportOptions);
                exportOptionsModel.FileName += extension;
            }
            base.Export(exportOptionsModel);
        }
    }
}
