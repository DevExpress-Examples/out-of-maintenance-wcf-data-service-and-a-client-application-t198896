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

    class InstantFeedbackSource<TEntity> : IInstantFeedbackSource<TEntity>
        where TEntity : class {

        readonly WcfInstantFeedbackDataSource source;
        readonly PropertyDescriptorCollection threadSafeProperties;

        public InstantFeedbackSource(WcfInstantFeedbackDataSource source, PropertyDescriptorCollection threadSafeProperties) {
            this.source = source;
            this.threadSafeProperties = threadSafeProperties;
        }

        bool IListSource.ContainsListCollection { get { return ((IListSource)source).ContainsListCollection; } }
        IList IListSource.GetList() {
            return source.Data.GetList();
        }

        TProperty IInstantFeedbackSource<TEntity>.GetPropertyValue<TProperty>(object threadSafeProxy, Expression<Func<TEntity, TProperty>> propertyExpression) {
            var propertyName = ExpressionHelper.GetPropertyName(propertyExpression);
            var threadSafeProperty = threadSafeProperties[propertyName];
            return (TProperty)threadSafeProperty.GetValue(threadSafeProxy);
        }

        bool IInstantFeedbackSource<TEntity>.IsLoadedProxy(object threadSafeProxy) {
            return threadSafeProxy is ReadonlyThreadSafeProxyForObjectFromAnotherThread;
        }

        void IInstantFeedbackSource<TEntity>.Refresh() {
            source.Refresh();
        }
    }
}