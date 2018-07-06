using DeliveryServiceApp.DbFactory;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceApp.Repository
{
    public class RepositoryBase
    {
        private readonly DbContext _Context;
        public RepositoryBase(DeliveryServiceAppDbType dbType)
        {
            switch (dbType)
            {
                case DeliveryServiceAppDbType.Central:
                    _Context = AppDbfactory.GetDefaultCentralContext;
                    break;
                case DeliveryServiceAppDbType.Kitchen:
                    _Context = AppDbfactory.GetDefaultKitchenContext;
                    break;
                case DeliveryServiceAppDbType.Customer:
                   // _Context = AppDbfactory.GetDefaultCustomerContext;
                    break;
            }
        }

        public RepositoryBase(DeliveryServiceAppDbType dbType,int entityId)
        {
            switch (dbType)
            {
                case DeliveryServiceAppDbType.Kitchen:
                    _Context = AppDbfactory.GetSpecificKitchenContext(entityId);
                    break;
                case DeliveryServiceAppDbType.Customer:
                   // _Context = AppDbfactory.GetSpecificCustometrContext(entityId);
                    break;
            }
        }

        public RepositoryBase(DeliveryServiceAppDbType dbType, string entityEmail)
        {
            switch (dbType)
            {
                case DeliveryServiceAppDbType.Kitchen:
                    _Context = AppDbfactory.GetSpecificKitchenContext(entityEmail);
                    break;
                case DeliveryServiceAppDbType.Customer:
                    // _Context = AppDbfactory.GetSpecificCustometrContext(entityEmail);
                    break;
            }
        }

        public bool Add<T>(T entity) where T : class
        {
            this._Context.Entry(entity).State = System.Data.Entity.EntityState.Added;
            this._Context.SaveChanges();
            return true;
        }
        public bool AddBulk<T>(T entity) where T : class
        {
            this._Context.Entry(entity).State = System.Data.Entity.EntityState.Added;
            return true;
        }
        public bool UpdateBulk<T>(T entity) where T : class
        {
            this._Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return true;
        }
        public bool Update<T>(T entity) where T : class
        {
            this._Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            this._Context.SaveChanges();
            return true;
        }

        public bool Remove<T>(T entity) where T : class
        {
            return true;
        }

        public IQueryable<T> Get<T>(Expression<Func<T, bool>> condition) where T : class
        {
            return this._Context.Set<T>().Where(condition);
        }

        public IQueryable<T> GetWith<T>(string includeEntities, Expression<Func<T, bool>> condition) where T : class
        {
            return this._Context.Set<T>().Include(includeEntities).Where(condition);
        }

        public DbContextTransaction CreateTransaction
        {
            get
            {
                return _Context.Database.BeginTransaction();
            }
        }

        public bool SaveChanges()
        {
            this._Context.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            this._Context.Dispose();
        }
    }

    public enum DeliveryServiceAppDbType
    {
        Central,
        Kitchen,
        Customer
    }
}
