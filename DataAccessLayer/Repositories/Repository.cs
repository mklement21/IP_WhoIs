﻿using DataAccessLayer.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Repositories {
    public abstract class Repository<T> : IDisposable where T : class {
        public DBModelEntities Context { get; set; }
        public DbSet<T> Entities { get; set; }

        public Repository(DBModelEntities context) {
            Context = context;
            Entities = Context.Set<T>();
        }

        public virtual IQueryable<T> GetAll() {
            var query = from e in Entities select e;
            return query;
        }

        public int SaveChanges() {
            return Context.SaveChanges();
        }

        public virtual int Add(T entity, bool saveChanges = true) {
            Entities.Add(entity);
            if (saveChanges) {
                return SaveChanges();
            } else {
                return 0;
            }
        }

        public void Dispose() {
            Context.Dispose();
        }
    }
}
