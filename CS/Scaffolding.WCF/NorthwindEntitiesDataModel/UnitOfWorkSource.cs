using System;
using System.Linq;
using System.Data;
using System.Linq.Expressions;
using System.Collections.Generic;
using Scaffolding.WCF.Common.Utils;
using Scaffolding.WCF.Common.DataModel;
using Scaffolding.WCF.Common.DataModel.DesignTime;
using Scaffolding.WCF.Common.DataModel.WCF;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
using Scaffolding.WCF.NorthwindEntities;
using DevExpress.Mvvm;
using System.Collections;
using System.ComponentModel;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Async.Helpers;

namespace Scaffolding.WCF.NorthwindEntitiesDataModel {
    using NorthwindEntities = Scaffolding.WCF.NorthwindEntities.NorthwindEntities;
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {
        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the current mode (run-time or design-time).
        /// </summary>
        public static IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> GetUnitOfWorkFactory() {
            return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode);
        }

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the given mode (run-time or design-time).
        /// </summary>
        /// <param name="isInDesignTime">Used to determine which implementation of IUnitOfWorkFactory should be returned.</param>
        public static IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> GetUnitOfWorkFactory(bool isInDesignTime) {
            if(isInDesignTime)
                return new DesignTimeUnitOfWorkFactory<INorthwindEntitiesUnitOfWork>(() => new NorthwindEntitiesDesignTimeUnitOfWork());
            Uri svcUri = new Uri("http://localhost:37535/NorthwindWcfDataService.svc");
            return new DbUnitOfWorkFactory<INorthwindEntitiesUnitOfWork, NorthwindEntities>(
                () => new NorthwindEntitiesUnitOfWork(() => new NorthwindEntities(svcUri)),
                () => new NorthwindEntities(svcUri));
        }
    }
}