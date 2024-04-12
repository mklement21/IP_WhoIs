using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories {
    public abstract class Repository<T> : IDisposable where T : class {
        public DBModelEntities Context { get; set; }
        public DbSet<T> Entities { get; set; }

        public Repository(DBModelEntities context) {
            Context = context;
            Entities = Context.Set<T>();
        }

        public void Dispose() {
            Context.Dispose();
        }
    }
}
