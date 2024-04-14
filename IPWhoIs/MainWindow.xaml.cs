using System.Windows;

namespace IPWhoIs {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e) {
            UcSearch ucSearch = new UcSearch();
            contentPanel.Content = ucSearch;
        }

        private void btnSaved_Click(object sender, RoutedEventArgs e) {
            UcSaved ucSaved = new UcSaved();
            contentPanel.Content = ucSaved;
        }
    }
}
