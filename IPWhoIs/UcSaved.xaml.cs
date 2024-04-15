using BusinessLogicLayer;
using DataAccessLayer.Entities;
using System;
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
            LoadCombo();
        }

        private void LoadCombo() {
            cbSort.SelectedItem = "Select";
            cbSort.Items.Add("Select");
            cbSort.Items.Add("Sort by Country ascending");
            cbSort.Items.Add("Sort by Country descending");
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

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e) {
            string filter = txtFilter.Text.ToString();
            List<IpAdrese> filteredAddresses = iPService.GetAddressByCountry(filter);
            dgSavedAddresses.ItemsSource = filteredAddresses.ToList(); 
        }

        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selected = cbSort.SelectedItem;

            if (selected != null) {
                switch (selected) {
                    case "Sort by Country ascending":
                        dgSavedAddresses.ItemsSource = iPService.GetBySortAsc().ToList();
                        break;

                    case "Sort by Country descending":
                        dgSavedAddresses.ItemsSource = iPService.GetBySortDesc().ToList();
                        break;

                    default:
                        LoadData();
                        break;
                }
            }
        }
    }
}
