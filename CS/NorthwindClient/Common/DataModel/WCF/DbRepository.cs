using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using NorthwindClient.Common.Utils;
using NorthwindClient.Common.DataModel;
using System.Data.Services.Client;

namespace NorthwindClient.Common.DataModel.WCF {
    public class DbRepository<TEntity, TPrimaryKey, TDbContext> : DbReadOnlyRepository<TEntity, TDbContext>, IRepository<TEntity, TPrimaryKey>
        where TEntity : class, new()
        where TDbContext : DataServiceContext {

        readonly string dbSetName;
        readonly Expression<Func<TEntity, TPrimaryKey>> getPrimaryKeyExpression;
        readonly EntityTraits<TEntity, TPrimaryKey> entityTraits;

        public DbRepository(DbUnitOfWork<TDbContext> unitOfWork, Expression<Func<TDbContext, DataServiceQuery<TEntity>>> dbSetAccessorExpression, Expression<Func<TEntity, TPrimaryKey>> getPrimaryKeyExpression)
            : base(unitOfWork, dbSetAccessorExpression.Compile()) {
            Expression body = dbSetAccessorExpression.Body;
            while (body is MethodCallExpression) {
                body = ((MethodCallExpression)body).Object;
            }
            this.dbSetName = ((MemberExpression)body).Member.Name;
            this.getPrimaryKeyExpression = getPrimaryKeyExpression;
            this.entityTraits = ExpressionHelper.GetEntityTraits(this, getPrimaryKeyExpression);
        }
        TEntity IRepository<TEntity, TPrimaryKey>.Find(TPrimaryKey key) {
            try {
                var entity = LocalCollection.SingleOrDefault(x => object.Equals(GetPrimaryKeyCore(x), key));
                if (entity != null)
                    return entity;
                entity = FindCore(key);
                if (entity != null)
                    LocalCollection.Load(entity);
                return entity;
            }
            catch (DataServiceQueryException) {
                return null;
            }
        }
        void IRepository<TEntity, TPrimaryKey>.Remove(TEntity entity) {
            RemoveCore(entity);
        }
        TEntity IRepository<TEntity, TPrimaryKey>.Create() {
            return CreateCore();
        }
        void IRepository<TEntity, TPrimaryKey>.Attach(TEntity entity) {
            AttachCore(entity);
        }
        void IRepository<TEntity, TPrimaryKey>.Detach(TEntity entity) {
            DetachCore(entity);
        }
        void IRepository<TEntity, TPrimaryKey>.Update(TEntity entity) {
            UpdateCore(entity);
        }
        EntityState IRepository<TEntity, TPrimaryKey>.GetState(TEntity entity) {
            return GetStateCore(entity);
        }
        Expression<Func<TEntity, TPrimaryKey>> IRepository<TEntity, TPrimaryKey>.GetPrimaryKeyExpression {
            get { return this.getPrimaryKeyExpression; }
        }
        void IRepository<TEntity, TPrimaryKey>.SetPrimaryKey(TEntity entity, TPrimaryKey key) {
            SetPrimaryKeyCore(entity, key);
        }
        TPrimaryKey IRepository<TEntity, TPrimaryKey>.GetPrimaryKey(TEntity entity) {
            return GetPrimaryKeyCore(entity);
        }
        bool IRepository<TEntity, TPrimaryKey>.HasPrimaryKey(TEntity entity) {
            return entityTraits.HasPrimaryKey(entity);
        }
        protected virtual TEntity CreateCore() {
            TEntity newEntity = new TEntity();
            LocalCollection.Add(newEntity);
            return newEntity;
        }
        protected virtual void AttachCore(TEntity entity) {
            UnitOfWork.Context.AttachTo(dbSetName, entity);
            UnitOfWork.Context.UpdateObject(entity);
        }
        protected virtual void DetachCore(TEntity entity) {
            UnitOfWork.Context.Detach(entity);
        }
        protected virtual void UpdateCore(TEntity entity) {
            UnitOfWork.Context.UpdateObject(entity);
        }
        protected virtual EntityState GetStateCore(TEntity entity) {
            var descriptor = UnitOfWork.Context.GetEntityDescriptor(entity);
            return descriptor != null ? GetEntityState(descriptor.State) : EntityState.Detached;
        }
        static EntityState GetEntityState(EntityStates entityStates) {
            switch (entityStates) {
                case EntityStates.Added:
                    return EntityState.Added;
                case EntityStates.Deleted:
                    return EntityState.Deleted;
                case EntityStates.Detached:
                    return EntityState.Detached;
                case EntityStates.Modified:
                    return EntityState.Modified;
                case EntityStates.Unchanged:
                    return EntityState.Unchanged;
                default:
                    throw new NotImplementedException();
            }
        }
        protected virtual TEntity FindCore(TPrimaryKey key) {
            return DbSet.Where(this.GetPrimaryKeyEqualsExpression(key)).Take(1).ToArray().FirstOrDefault();
        }
        protected virtual void RemoveCore(TEntity entity) {
            try {
                LocalCollection.Remove(entity);
            }
            catch (Exception ex) {
                throw DbExceptionsConverter.Convert(ex);
            }
        }
        protected virtual TPrimaryKey GetPrimaryKeyCore(TEntity entity) {
            return entityTraits.GetPrimaryKey(entity);
        }
        protected virtual void SetPrimaryKeyCore(TEntity entity, TPrimaryKey key) {
            var setPrimaryKeyaction = entityTraits.SetPrimaryKey;
            setPrimaryKeyaction(entity, key);
        }
        TEntity IRepository<TEntity, TPrimaryKey>.Reload(TEntity entity) {
            int index = this.LocalCollection.IndexOf(entity);
            UnitOfWork.Context.Detach(entity);
            TEntity newEntity = FindCore(GetPrimaryKeyCore(entity));
            if (newEntity == null)
                LocalCollection.RemoveAt(index);
            else if (index >= 0)
                LocalCollection[index] = newEntity;
            return newEntity;
        }
    }
}