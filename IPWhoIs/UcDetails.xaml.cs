using DataAccessLayer.Entities;
using System;
using System.Windows.Controls;
using System.Net.Http;
using System.Windows;
using BusinessLogicLayer;

namespace IPWhoIs {
    public partial class UcDetails : UserControl {
        private IpAdrese Address = new IpAdrese();
        private IPService IPService = new IPService();
        public UcDetails(IpAdrese  selectedAddress) {
            InitializeComponent();
            Address = selectedAddress;
            LoadData();
            LoadFlagFromUrl();
            IsFavorite();
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
    }
}
