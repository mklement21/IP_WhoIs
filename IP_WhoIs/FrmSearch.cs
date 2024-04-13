using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using BusinessLogicLayer;
using System.Net;
using System.Drawing;
using Exceptions;

namespace IP_WhoIs {
    public partial class FrmSearch : Form {
        private UcSaved ucSaved = new UcSaved();
        private JObject jsonData;
        private IPService iPService = new IPService();

        public FrmSearch() {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e) {
            string urlAPI = txtSearchInput.Text.ToString();

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
            txtIPAddress.Text = (string)jsonData["ip"];
            txtContinet.Text = (string)jsonData["continent"];
            txtContinentCode.Text = (string)jsonData["continent_code"];
            txtCountryCapital.Text = (string)jsonData["country_capital"];
            txtCity.Text = (string)jsonData["city"];
            txtTimezone.Text = (string)jsonData["timezone"];
        }

        private void btnNavSaved_Click(object sender, EventArgs e) {
            this.Controls.Remove(pnlMain);
            ucSaved.Dock = DockStyle.Fill;
            this.Controls.Add(ucSaved);
            ucSaved.RefreshData();
        }

        private void btnNavSearch_Click(object sender, EventArgs e) {
            pnlMain.Dock = DockStyle.Fill;
            this.Controls.Add(pnlMain);
            this.Controls.Remove(ucSaved);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            ImportIP(jsonData);
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
                } else {
                    MessageBox.Show("Data not saved.");
                }
            } catch (AddressException ex) {
                MessageBox.Show(ex.ExMessage);
            } 
        }
    }
}
