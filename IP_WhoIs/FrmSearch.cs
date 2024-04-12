using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace IP_WhoIs {
    public partial class FrmSearch : Form {
        private UcSaved ucSaved = new UcSaved();

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
                        JObject jsonData = JObject.Parse(apiResponse);
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
        }

        private void btnNavSearch_Click(object sender, EventArgs e) {
            pnlMain.Dock = DockStyle.Fill;
            this.Controls.Add(pnlMain);
            this.Controls.Remove(ucSaved);
        }
    }
}
