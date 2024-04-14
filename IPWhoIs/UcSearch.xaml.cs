using BusinessLogicLayer;
using DataAccessLayer.Entities;
using Exceptions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IPWhoIs {
    /// <summary>
    /// Interaction logic for UcSearch.xaml
    /// </summary>
    public partial class UcSearch : UserControl {
        private JObject jsonData;
        private IPService iPService = new IPService();
        public UcSearch() {
            InitializeComponent();
        }

        private async void btnSearchIP_Click(object sender, RoutedEventArgs e) {
            string urlAPI = txtSearch.Text.ToString();

            try {
                using (HttpClient httpClient = new HttpClient()) {
                    HttpResponseMessage response = await httpClient.GetAsync(urlAPI);

                    if (response.IsSuccessStatusCode) {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        jsonData = JObject.Parse(apiResponse);
                        DisplayData(jsonData);
                    } else {
                        MessageBox.Show($"Failed to fetch data with status code : {response.StatusCode}");
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error message : {ex.Message}");
            }
        }

        private void DisplayData(JObject jsonData) {
            txtSearch.Text = (string)jsonData["ip"];
            txtContinent.Text = (string)jsonData["continent"];
            txtContinentCode.Text = (string)jsonData["continent_code"];
            txtCountryCapital.Text = (string)jsonData["country_capital"];
            txtCity.Text = (string)jsonData["city"];
            txtTimezone.Text = (string)jsonData["timezone"];
        }

        private void ImportIP(JObject jsonData) {
            IpAdrese newAddress = new IpAdrese {
                IP = (string)jsonData["ip"],
                success = (bool)jsonData["success"],
                type = (string)jsonData["type"],
                continent = (string)jsonData["continent"],
                continent_code = (string)jsonData["continent_code"],
                country = (string)jsonData["country"],
                country_code = (string)jsonData["country_code"],
                country_flag = (string)jsonData["country_flag"],
                country_capital = (string)jsonData["country_capital"],
                country_phone = (string)jsonData["country_phone"],
                country_neighbours = (string)jsonData["country_neighbours"],
                region = (string)jsonData["region"],
                city = (string)jsonData["city"],
                latitude = (double)jsonData["latitude"],
                longitude = (double)jsonData["longitude"],
                asn = (string)jsonData["asn"],
                org = (string)jsonData["org"],
                isp = (string)jsonData["isp"],
                timezone = (string)jsonData["timezone"],
                timezone_name = (string)jsonData["timezone_name"],
                timezone_dstOffset = (int)jsonData["timezone_dstOffset"],
                timezone_gmtOffset = (int)jsonData["timezone_gmtOffset"],
                timezone_gmt = (string)jsonData["timezone_gmt"],
                currency = (string)jsonData["currency"],
                currency_code = (string)jsonData["currency_code"],
                currency_symbol = (string)jsonData["currency_symbol"],
                currency_rates = (double)jsonData["currency_rates"],
                currency_plural = (string)jsonData["currency_plural"],
                favorite = false,
            };

            try {
                bool result = iPService.AddAddress(newAddress);

                if (result) {
                    MessageBox.Show("Data saved successfully.");
                }
            } catch (AddressException ex) {
                MessageBox.Show(ex.ExMessage);
            }

        }

        private void btnSaveAddress_Click(object sender, RoutedEventArgs e) {
            ImportIP(jsonData);
        }
    }
}
