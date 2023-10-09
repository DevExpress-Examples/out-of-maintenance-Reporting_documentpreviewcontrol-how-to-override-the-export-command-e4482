using System.Windows;
using DevExpress.Xpf.Core;

namespace ReportingWpfOverrideExportCommand {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            ApplicationThemeHelper.ApplicationThemeName = Theme.Office2016WhiteName;
            InitializeComponent();
        }

        private void ShowPreview(object sender, RoutedEventArgs e) {
            XtraReport1 report = new XtraReport1();
            var preview = new MyDocumentPreviewControl() { DocumentSource = report };
            var window = new DXWindow() { Content = preview };
            report.CreateDocument(true);
            window.ShowDialog();
        }
    }
}
