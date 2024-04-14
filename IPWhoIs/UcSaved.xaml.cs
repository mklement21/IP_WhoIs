using BusinessLogicLayer;
using DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace IPWhoIs {
    public partial class UcSaved : UserControl {
        private IPService iPService = new IPService();
        public UcSaved() {
            InitializeComponent();
            LoadData();
        }

        private void LoadData() {
            List<IpAdrese> iPAddresses = iPService.GetAddresses().ToList();
            dgSavedAddresses.ItemsSource = iPAddresses;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (dgSavedAddresses.SelectedItem is IpAdrese selectedAddress) {
                UcDetails ucDetails = new UcDetails(selectedAddress);
                this.Content = ucDetails;
            }
        }
    }
}
