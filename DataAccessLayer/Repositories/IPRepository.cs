using DataAccessLayer.Entities;
using Exceptions;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;

namespace DataAccessLayer.Repositories {
    public class IPRepository : Repository<IpAdrese> {
        public IPRepository() : base(new DBModelEntities()) {
        }

        public override IQueryable<IpAdrese> GetAll() {
            var query = Entities.OrderBy(c => c.favorite == true ? 0 : 1).ThenBy(c => c.country);
            return query;
        }

        public override int Add(IpAdrese entity, bool saveChanges = true) {
            var existingIP = Entities.Any(a => a.IP == entity.IP);

            if ( existingIP ) {
                throw new AddressException("IP address already exsists.");
            }

            var newIP = new IpAdrese {
                IP = entity.IP,
                success = entity.success,
                type = entity.type,
                continent = entity.continent,
                continent_code = entity.continent_code,
                country = entity.country,
                country_code = entity.country_code,
                country_flag = entity.country_flag,
                country_capital = entity.country_capital,
                country_phone = entity.country_phone,
                country_neighbours = entity.country_neighbours,
                region = entity.region,
                city = entity.city,
                latitude = entity.latitude,
                longitude = entity.longitude,
                asn = entity.asn,
                org = entity.org,
                isp = entity.isp,
                timezone = entity.timezone,
                timezone_name = entity.timezone_name,
                timezone_dstOffset = entity.timezone_dstOffset,
                timezone_gmtOffset = entity.timezone_gmtOffset,
                timezone_gmt = entity.timezone_gmt,
                currency = entity.currency,
                currency_code = entity.currency_code,
                currency_symbol = entity.currency_symbol,
                currency_rates = entity.currency_rates,
                currency_plural = entity.currency_plural,
                favorite = entity.favorite,
            };

            if (saveChanges) {
                Entities.Add(newIP);
                return SaveChanges();
            } else {
                return 0;
            }
        }

        public IQueryable<IpAdrese> GetAddressFilter(string country) {
            var query = from countries in Entities.OrderBy(c => c.favorite == true).Where( c => c.country.StartsWith(country))
                        select countries;
            return query;
        }

        public IQueryable<IpAdrese> GetByCountryAsc() {
            var query = Entities.Select(c => c).OrderBy(c => c.favorite == true ? 0 : 1).ThenBy(c => c.country);
            return query;
        }

        public IQueryable<IpAdrese> GetByCountryDesc() {
            var query = Entities.Select(c => c).OrderBy(c => c.favorite == true ? 0 : 1).ThenByDescending(c => c.country); ;
            return query;
        }

        public int AddFavorite(IpAdrese address, bool saveChanges = true) {
            address.favorite = true;

            if (saveChanges) {
                return SaveChanges();
            } else {
                return 0;
            }
        }

        public override int Update(IpAdrese entity, bool saveChanges = true) {
            IpAdrese address = Entities.SingleOrDefault( a => a.IP == entity.IP);
            address.success = entity.success;
            address.type = entity.type;
            address.continent = entity.continent;
            address.continent_code = entity.continent_code;
            address.country = entity.country;
            address.country_code = entity.country_code;
            address.country_flag = entity.country_flag;
            address.country_capital = entity.country_capital;
            address.country_phone = entity.country_phone;
            address.country_neighbours = entity.country_neighbours;
            address.region = entity.region;
            address.city = entity.city;
            address.latitude = entity.latitude;
            address.longitude = entity.longitude;
            address.asn = entity.asn;
            address.org = entity.org;
            address.isp = entity.isp;
            address.timezone = entity.timezone;
            address.timezone_name = entity.timezone_name;
            address.timezone_dstOffset = entity.timezone_dstOffset;
            address.timezone_gmtOffset = entity.timezone_gmtOffset;
            address.timezone_gmt = entity.timezone_gmt;
            address.currency = entity.currency;
            address.currency_code = entity.currency_code;
            address.currency_symbol = entity.currency_symbol;
            address.currency_rates = entity.currency_rates;
            address.currency_plural = entity.currency_plural;
            address.favorite = entity.favorite;

            if (saveChanges) {
                return SaveChanges();
            } else {
                return 0;
            }
        }
    }
}
