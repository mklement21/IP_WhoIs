﻿using DataAccessLayer.Entities;
using Exceptions;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Repositories {
    public class IPRepository : Repository<IpAdrese> {
        public IPRepository() : base(new DBModelEntities()) {
        }

        public override IQueryable<IpAdrese> GetAll() {
            var query = from countries in Entities.OrderBy( c => c.country)
                        select countries;
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
    }
}
