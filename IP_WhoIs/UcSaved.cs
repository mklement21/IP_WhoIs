using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_WhoIs {
    public partial class UcSaved : UserControl {
        private IPService iPService = new IPService();
        private int[] indexes = {1, 2, 4, 7, 10, 11, 12,13,14,15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };

        public UcSaved() {
            InitializeComponent();
            LoadAdresses();
        }

        private void LoadAdresses() {
            dgvSavedAddresses.DataSource = iPService.GetAddresses().ToList();

            EditDataGrid();

            dgvSavedAddresses.Update();
            dgvSavedAddresses.Refresh();
        }

        private void EditDataGrid() {
            foreach (int i in indexes) {
                dgvSavedAddresses.Columns[i].Visible = false;
            };

            dgvSavedAddresses.Columns["IP"].HeaderText = "IP adresa";
            dgvSavedAddresses.Columns["continent"].HeaderText = "Continent";
            dgvSavedAddresses.Columns["country"].HeaderText = "Country";
            dgvSavedAddresses.Columns["country_code"].HeaderText = "Country code";
            dgvSavedAddresses.Columns["country_phone"].HeaderText = "Country phone";
            dgvSavedAddresses.Columns["country_capital"].HeaderText = "Country capital";
            dgvSavedAddresses.Columns["country_capital"].HeaderText = "Country capital";
            dgvSavedAddresses.Columns["currency_plural"].HeaderText = "Currency";
            dgvSavedAddresses.Columns["favorite"].HeaderText = "Favorite";
        }

        public void RefreshData() {
            LoadAdresses();
        }
    }
}
