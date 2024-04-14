using BusinessLogicLayer;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Interaction logic for UcSaved.xaml
    /// </summary>
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
    }
}
