using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer {
    public class IPService {

        public bool AddAddress(IpAdrese address) {
            bool isSuccesfull = false;
            using (var repo = new IPRepository()) {
                int affectedRows = repo.Add(address);
                isSuccesfull = affectedRows > 0;
            }
            return isSuccesfull;
        }

        public List<IpAdrese> GetAddresses() {
            using (var repo = new IPRepository()) {
                return repo.GetAll().ToList();
            }
        }

        public bool RemoveAddress(IpAdrese address) {
            bool isSuccessful = false;
            using (var repo = new IPRepository()) {
                int affectedRows = repo.Remove(address);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public List<IpAdrese> GetAddressByCountry(string country) {
            using (var repo = new IPRepository()) {
                return repo.GetAddressFilter(country).ToList();
            }
        }

        public List<IpAdrese> GetBySortAsc() {
            using (var repo = new IPRepository()) {
                return repo.GetByCountryAsc().ToList();
            }
        }

        public List<IpAdrese> GetBySortDesc() {
            using (var repo = new IPRepository()) {
                return repo.GetByCountryDesc().ToList();
            }
        }

        public bool UpdateAddress(IpAdrese address) {
            bool isSuccessful = false;
            using (var repo = new IPRepository()) {
                int affectedRows = repo.Update(address);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public bool TxtExpotData(IpAdrese address, string filePath) {
            try {
                using (StreamWriter streamWriter = new StreamWriter(filePath)) {
                    streamWriter.WriteLine($"IP: {address.IP}");
                    streamWriter.WriteLine($"Success: {address.success}");
                    streamWriter.WriteLine($"Type: {address.type}");
                    streamWriter.WriteLine($"Continent: {address.continent}");
                    streamWriter.WriteLine($"Continent Code: {address.continent_code}");
                    streamWriter.WriteLine($"Country: {address.country}");
                    streamWriter.WriteLine($"Country Code: {address.country_code}");
                    streamWriter.WriteLine($"Country Capital: {address.country_capital}");
                    streamWriter.WriteLine($"Country Phone: {address.country_phone}");
                    streamWriter.WriteLine($"Country Neighbours: {address.country_neighbours}");
                    streamWriter.WriteLine($"Region: {address.region}");
                    streamWriter.WriteLine($"City: {address.city}");
                    streamWriter.WriteLine($"Latitude: {address.latitude}");
                    streamWriter.WriteLine($"Longitude: {address.longitude}");
                    streamWriter.WriteLine($"ASN: {address.asn}");
                    streamWriter.WriteLine($"Org: {address.org}");
                    streamWriter.WriteLine($"ISP: {address.isp}");
                    streamWriter.WriteLine($"Timezone: {address.timezone}");
                    streamWriter.WriteLine($"Timezone Name: {address.timezone_name}");
                    streamWriter.WriteLine($"Timezone DST Offset: {address.timezone_dstOffset}");
                    streamWriter.WriteLine($"Timezone GMT Offset: {address.timezone_gmtOffset}");
                    streamWriter.WriteLine($"Currency: {address.currency}");
                    streamWriter.WriteLine($"Currency Code: {address.currency_code}");
                    streamWriter.WriteLine($"Currency Symbol: {address.currency_symbol}");
                    streamWriter.WriteLine($"Currency Rates: {address.currency_rates}");
                    streamWriter.WriteLine($"Currency Plural: {address.currency_plural}");
                    streamWriter.WriteLine($"Favorite: {address.favorite}");
                }
                return true;
            } catch (Exception ex) {
                return false;
            }
        }
    }
}
