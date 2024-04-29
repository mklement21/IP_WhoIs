using System.Net.Http;
using System.Net;
using System;
using System.Windows;

namespace IPWhoIs {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            LoadLogoFromUrl();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e) {
            UcSearch ucSearch = new UcSearch();
            contentPanel.Content = ucSearch;
        }

        private void btnSaved_Click(object sender, RoutedEventArgs e) {
            UcSaved ucSaved = new UcSaved();
            contentPanel.Content = ucSaved;
        }

        public async void LoadLogoFromUrl() {
            string imageUrl = "https://ipwhois.io/img/logo.svg";
            try {
                HttpClient httpClient = new HttpClient();

                string svgData = await httpClient.GetStringAsync(imageUrl);

                webBrowser.NavigateToString(svgData);
            } catch (Exception ex) {
                MessageBox.Show($"Error loading SVG: {ex.Message}");
            }
        }
    }
}
