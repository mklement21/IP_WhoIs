using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Xml.Linq;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using BusinessLogicLayer;
using System.Net;
using System.Drawing;
using Exceptions;

namespace IPWhoIs {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e) {
            UcSearch ucSearch = new UcSearch();
            contentPanel.Content = ucSearch;
        }

        private void btnSaved_Click(object sender, RoutedEventArgs e) {
            UcSaved ucSaved = new UcSaved();
            contentPanel.Content = ucSaved;
        }
    }
}
