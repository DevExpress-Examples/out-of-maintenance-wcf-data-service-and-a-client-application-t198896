using DevExpress.Xpf.Core.ServerMode;
//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Data.Services.Providers;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace Scaffolding.WCF.Service {
    public class NorthwindWcfDataService : EntityFrameworkDataService<NorthwindEntities> {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config) {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("GetString", ServiceOperationRights.All);
            config.SetServiceOperationAccessRule("GetProductsExtendedData", ServiceOperationRights.AllRead);
            config.SetServiceOperationAccessRule("GetEmployeesExtendedData", ServiceOperationRights.AllRead);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }

        [WebGet]
        public string GetString() {
            return "some string";
        }

        [WebGet(UriTemplate = "GetProductsExtendedData?extendedDataInfo={extendedDataInfo}")]
        public string GetProductsExtendedData(string extendedDataInfo) {
            return ExtendedDataHelper.GetExtendedData(CurrentDataSource.Products, extendedDataInfo);
        }

        [WebGet(UriTemplate = "GetEmployeesExtendedData?extendedDataInfo={extendedDataInfo}")]
        public string GetEmployeesExtendedData(string extendedDataInfo) {
            return ExtendedDataHelper.GetExtendedData(CurrentDataSource.Employees, extendedDataInfo);
        }
    }
}
