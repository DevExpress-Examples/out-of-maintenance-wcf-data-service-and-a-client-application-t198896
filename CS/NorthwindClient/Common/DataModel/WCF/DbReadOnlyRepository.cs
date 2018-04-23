using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using NorthwindClient.Common.Utils;
using NorthwindClient.Common.DataModel;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
namespace NorthwindClient.Common.DataModel.WCF {
    public class DbReadOnlyRepository<TEntity, TDbContext> : DbRepositoryQuery<TEntity>, IReadOnlyRepository<TEntity>
        where TEntity : class
        where TDbContext : DataServiceContext {

        readonly Func<TDbContext, DataServiceQuery<TEntity>> dbSetAccessor;
        readonly DbUnitOfWork<TDbContext> unitOfWork;
        readonly Lazy<DataServiceCollection<TEntity>> localCollection;

        protected DbUnitOfWork<TDbContext> UnitOfWork {
            get { return unitOfWork; }
        }
        protected DataServiceQuery<TEntity> DbSet { get { return dbSetAccessor(unitOfWork.Context); } }
        public DbReadOnlyRepository(DbUnitOfWork<TDbContext> unitOfWork, Func<TDbContext, DataServiceQuery<TEntity>> dbSetAccessor)
            : base(() => dbSetAccessor(unitOfWork.Context), null) {
            this.dbSetAccessor = dbSetAccessor;
            this.unitOfWork = unitOfWork;
            this.localCollection = new Lazy<DataServiceCollection<TEntity>>(() => new DataServiceCollection<TEntity>(DbSet.Where(x => false)));
        }
        IUnitOfWork IReadOnlyRepository<TEntity>.UnitOfWork {
            get { return unitOfWork; }
        }
        protected DataServiceCollection<TEntity> LocalCollection {
            get {
                return localCollection.Value;
            }
        }
        protected override void LoadItem(TEntity item) {
            if (item != null)
                LocalCollection.Load(item);
        }
    }
    public class DbRepositoryQuery<TEntity> : QueryableWrapper<TEntity, TEntity>, IRepositoryQuery<TEntity> where TEntity : class {
        readonly Lazy<DataServiceQuery<TEntity>> query;
        DataServiceQuery<TEntity> Query { get { return query.Value; } }
        public DbRepositoryQuery(Func<DataServiceQuery<TEntity>> getQuery, Action<TEntity> loadItemCallback)
            : base(getQuery, loadItemCallback) {
            this.query = new Lazy<DataServiceQuery<TEntity>>(getQuery);
        }
        IRepositoryQuery<TEntity> IRepositoryQuery<TEntity>.Include<TProperty>(Expression<Func<TEntity, TProperty>> path) {
            return new DbRepositoryQuery<TEntity>(() => Query.Expand(path), LoadItemCallback);
        }
        IRepositoryQuery<TEntity> IRepositoryQuery<TEntity>.Where(Expression<Func<TEntity, bool>> predicate) {
            return new DbRepositoryQuery<TEntity>(() => (DataServiceQuery<TEntity>)Query.Where(predicate), LoadItemCallback);
        }
    }
}