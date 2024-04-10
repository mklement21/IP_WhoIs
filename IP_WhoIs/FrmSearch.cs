using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_WhoIs {
    public partial class FrmSearch : Form {
        public FrmSearch() {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e) {
            string urlAPI = "https://ipwhois.app/json/193.198.57.183";

            try {
                using (HttpClient httpClient = new HttpClient()) {
                    HttpResponseMessage response = await httpClient.GetAsync(urlAPI);

                    if (response.IsSuccessStatusCode) {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        txtAPI.Text = apiResponse;
                    } else {
                        MessageBox.Show($"Failed to fetch data with status code : {response.StatusCode}");
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error message : {ex.Message}");
            }
        }
    }
}
