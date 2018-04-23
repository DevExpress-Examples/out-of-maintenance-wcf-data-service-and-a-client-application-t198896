using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using NorthwindClient.Common.Utils;
using NorthwindClient.Common.DataModel;
using NorthwindClient.Common.DataModel.WCF;
using NorthwindClient.ServiceReference1;
using DevExpress.Mvvm;

namespace NorthwindClient.Northwind2012EntitiesDataModel {
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

        #region inner classes
        class DbUnitOfWorkFactory : IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> {
            public static readonly IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> Instance = new DbUnitOfWorkFactory();
            Uri svcUri = new Uri("http://localhost:59326/NorthwindWcfDataService.svc");
            DbUnitOfWorkFactory() { }
            INorthwind2012EntitiesUnitOfWork IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork>.CreateUnitOfWork() {
                return new Northwind2012EntitiesUnitOfWork(() => new Northwind2012Entities(svcUri));
            }
        }

        class DesignUnitOfWorkFactory : IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> {
            public static readonly IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> Instance = new DesignUnitOfWorkFactory();
            DesignUnitOfWorkFactory() { }
            INorthwind2012EntitiesUnitOfWork IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork>.CreateUnitOfWork() {
                return new Northwind2012EntitiesDesignTimeUnitOfWork();
            }
        }
        #endregion

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the current mode (run-time or design-time).
        /// </summary>
        public static IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> GetUnitOfWorkFactory() {
            return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode);
        }

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the given mode (run-time or design-time).
        /// </summary>
        /// <param name="isInDesignTime">Used to determine which implementation of IUnitOfWorkFactory should be returned.</param>
        public static IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> GetUnitOfWorkFactory(bool isInDesignTime) {
            return isInDesignTime ? DesignUnitOfWorkFactory.Instance : DbUnitOfWorkFactory.Instance;
        }
    }
}