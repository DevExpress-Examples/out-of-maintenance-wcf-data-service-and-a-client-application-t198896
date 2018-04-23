using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using Scaffolding.WCF.Common.Utils;
using Scaffolding.WCF.Common.DataModel;
using Scaffolding.WCF.Common.DataModel.DesignTime;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
using DevExpress.Mvvm;
using System.Collections;
using System.ComponentModel;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Async.Helpers;
using DevExpress.Xpf.Core.ServerMode;

namespace Scaffolding.WCF.Common.DataModel.WCF {
    class DbUnitOfWorkFactory<TUnitOfWork, TContext> : IUnitOfWorkFactory<TUnitOfWork>
        where TUnitOfWork : IUnitOfWork
        where TContext : DataServiceContext {
        Func<TUnitOfWork> getUnitOfWork;
        Func<TContext> getContext;

        public DbUnitOfWorkFactory(Func<TUnitOfWork> getUnitOfWork, Func<TContext> getContext) {
            this.getUnitOfWork = getUnitOfWork;
            this.getContext = getContext;
        }

        TUnitOfWork IUnitOfWorkFactory<TUnitOfWork>.CreateUnitOfWork() {
            return getUnitOfWork();
        }

        IInstantFeedbackSource<TProjection> IUnitOfWorkFactory<TUnitOfWork>.CreateInstantFeedbackSource<TEntity, TProjection, TPrimaryKey>(
            Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc,
            Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection) {
            var threadSafeProperties = new TypeInfoProxied(TypeDescriptor.GetProperties(typeof(TProjection)), null).UIDescriptors;
            if(projection == null) {
                projection = x => x as IQueryable<TProjection>;
            }
            var context = getContext();
            context.MergeOption = MergeOption.NoTracking;
            var source = new WcfInstantFeedbackDataSource
            {
                UseExtendedDataQuery = GetDbRepositoryQuery(getRepositoryFunc, projection).UseExtendedDataQuery,
                DataServiceContext = context
            };
            var keyProperties = ExpressionHelper.GetKeyProperties(getRepositoryFunc(getUnitOfWork()).GetPrimaryKeyExpression);
            var keyExpression = keyProperties.Select(p => p.Name).Aggregate((l, r) => l + ";" + r);
            source.GetSource += (s, e) =>
            {
                e.Query = GetDbRepositoryQuery(getRepositoryFunc, projection).Query;
                e.KeyExpression = keyExpression;
                e.Handled = true;
            };
            return new InstantFeedbackSource<TProjection>(source, threadSafeProperties);
        }

        DbRepositoryQuery<TProjection> GetDbRepositoryQuery<TEntity, TProjection, TPrimaryKey>(Func<TUnitOfWork, IRepository<TEntity, TPrimaryKey>> getRepositoryFunc, Func<IRepositoryQuery<TEntity>, IQueryable<TProjection>> projection)
            where TEntity : class, new()
            where TProjection : class {
            var dbRepositoryQuery = projection(getRepositoryFunc(getUnitOfWork())) as DbRepositoryQuery<TProjection>;
            if(dbRepositoryQuery == null)
                throw new InvalidOperationException("WCF projections in the Instant Feedback mode only support the Include and Where operations");
            return dbRepositoryQuery;
        }
    }
}