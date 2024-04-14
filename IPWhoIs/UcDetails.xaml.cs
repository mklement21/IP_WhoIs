using DataAccessLayer.Entities;
using FFImageLoading.Svg.Forms;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using SVGImage.SVG;
using System.Net.Http;
using System.Windows;
using SkiaSharp;
using System.IO;
using System.Net;
using System.Windows.Media;
using System.Windows.Interop;
using System.Drawing;

namespace IPWhoIs {
    /// <summary>
    /// Interaction logic for UcDetails.xaml
    /// </summary>
    public partial class UcDetails : UserControl {
        private IpAdrese Address = new IpAdrese();
        public UcDetails(IpAdrese  selectedAddress) {
            InitializeComponent();
            Address = selectedAddress;
            LoadFlag();
            LoadData();
        }

        private void LoadFlag() {
            string imageUrl = Address.country_flag;
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
    }
}
