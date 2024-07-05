using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
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

        public bool TxtExpotData(IpAdrese address, string) {
            bool isSuccessful = false;

            return isSuccessful;
        }
    }
}
