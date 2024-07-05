using DataAccessLayer.Entities;
using System;
using System.Windows.Controls;
using System.Net.Http;
using System.Windows;
using BusinessLogicLayer;
using Microsoft.Win32;
using System.Net;
using System.IO;

namespace IPWhoIs {
    public partial class UcDetails : UserControl {
        private const string ApiKey = "AIzaSyCzcBF_K96MrX_4vlP_7QOT9QVgPOhaJGc";

        private IpAdrese Address = new IpAdrese();
        private IPService IPService = new IPService();
        public UcDetails(IpAdrese selectedAddress) {
            InitializeComponent();
            Address = selectedAddress;
            LoadData();
            LoadFlagFromUrl();
            IsFavorite();
            LoadMap(selectedAddress.latitude, selectedAddress.longitude);
        }

        private void LoadMap(double? latitude, double? longitude) {
            if (latitude == null || longitude == null) {
                MessageBox.Show("Invalid coordinates.");
                return;
            }

            string url = $"https://maps.googleapis.com/maps/api/staticmap?center={latitude},{longitude}&zoom=10&size=600x400&key={ApiKey}";

            try {
                webBrowserMap.Source = new Uri(url);
            } catch (Exception ex) {
                MessageBox.Show($"Error loading map: {ex.Message}");
            }
        }

        private void IsFavorite() {
            if (Address.favorite == true) {
                btnFavorite.Content = "Remove from Favorite";
            } else {
                btnFavorite.Content = "Add to Favorite";
            }
        }

        public async void LoadFlagFromUrl() {
            string imageUrl = Address.country_flag;
            try {
                HttpClient httpClient = new HttpClient();

                string svgData = await httpClient.GetStringAsync(imageUrl);

                webBrowser.NavigateToString(svgData);
            } catch (Exception ex) {
                MessageBox.Show($"Error loading SVG: {ex.Message}");
            }
        }

        private void LoadData() {
            txtIP.Text = Address.IP;
            txtSuccess.Text = Address.success.ToString();
            txtType.Text = Address.type;
            txtContinent.Text = Address.continent;
            txtContinentCode.Text = Address.continent_code;
            txtCountry.Text = Address.country;
            txtCountryCode.Text = Address.country_code;
            txtCountryCapital.Text = Address.country_capital;
            txtCountryPhone.Text = Address.country_phone;
            txtCountryNeighbours.Text = Address.country_neighbours;
            txtRegin.Text = Address.region;
            txtCity.Text = Address.city;
            txtLatitude.Text = Address.latitude.ToString();
            txtLongitude.Text = Address.longitude.ToString();
            txtAsn.Text = Address.asn;
            txtOrg.Text = Address.org;
            txtIsp.Text = Address.isp;
            txtTimezone.Text = Address.timezone;
            txtTimezoneName.Text = Address.timezone_name;
            txtTimezone_dstOffset.Text = Address.timezone_dstOffset.ToString();
            txtTimezone_gmtOffset.Text = Address.timezone_gmtOffset.ToString();
            txtCurrency.Text = Address.currency;
            txtCurrencyCode.Text = Address.currency_code;
            txtCurrencySymbol.Text = Address.currency_symbol;
            txtCurrencyRates.Text = Address.currency_rates.ToString();
            txtCurrencyPlural.Text = Address.currency_plural;
            txtFavorite.Text = Address.favorite.ToString();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e) {

            if (Address != null) {
                var result = MessageBox.Show($"Are you sure you want to delete the address {Address.IP}?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes) {
                    IPService.RemoveAddress(Address);
                    MessageBox.Show($"Successfully removed address {Address.IP}");

                    UcSaved ucSaved = new UcSaved();
                    this.Content = ucSaved;
                }
            }
        }

        private void btnFavorite_Click(object sender, RoutedEventArgs e) {
            bool result;
            if (Address.favorite == true) {
                Address.favorite = false;
                result = IPService.UpdateAddress(Address);
            } else {
                Address.favorite = true;
                result = IPService.UpdateAddress(Address);
            }

            if (result) {
                string text = result ? "added to" : "removed from";
                MessageBox.Show($"Address {Address.IP} successfully {text} favorites!");
            }
            IsFavorite();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e) {
            try {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text file (*.txt)|*.txt";
                saveFileDialog.FileName = "IPAddress.txt";

                if (saveFileDialog.ShowDialog() == true) {
                    string filePath = saveFileDialog.FileName;

                    using (StreamWriter streamWriter = new StreamWriter(filePath)) {
                        streamWriter.WriteLine($"IP");
                    }
                    MessageBox.Show("Address details successfully exported to " + filePath);
                }

            } catch (Exception ex) {
                MessageBox.Show($"Error exporting data: {ex.Message}");
            }
        }
    }
}
