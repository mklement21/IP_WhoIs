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
    }
}
