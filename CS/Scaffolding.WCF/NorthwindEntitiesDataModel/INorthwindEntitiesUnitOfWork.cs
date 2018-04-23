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

namespace Scaffolding.WCF.NorthwindEntitiesDataModel {
    /// <summary>
    /// INorthwindEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface INorthwindEntitiesUnitOfWork : IUnitOfWork {

        /// <summary>
        /// The Category entities repository.
        /// </summary>
        IRepository<Category, int> Categories { get; }

        /// <summary>
        /// The Category_Sales_for_1997 entities repository.
        /// </summary>
        IRepository<Category_Sales_for_1997, string> Category_Sales_for_1997 { get; }

        /// <summary>
        /// The Current_Product_List entities repository.
        /// </summary>
        IRepository<Current_Product_List, Tuple<int, string>> Current_Product_Lists { get; }

        /// <summary>
        /// The CustomerDemographic entities repository.
        /// </summary>
        IRepository<CustomerDemographic, string> CustomerDemographics { get; }

        /// <summary>
        /// The Customer entities repository.
        /// </summary>
        IRepository<Customer, string> Customers { get; }

        /// <summary>
        /// The Employee entities repository.
        /// </summary>
        IRepository<Employee, int> Employees { get; }

        /// <summary>
        /// The Invoice entities repository.
        /// </summary>
        IReadOnlyRepository<Invoice> Invoices { get; }

        /// <summary>
        /// The Order_Detail entities repository.
        /// </summary>
        IRepository<Order_Detail, Tuple<int, int>> Order_Details { get; }

        /// <summary>
        /// The Order_Details_Extended entities repository.
        /// </summary>
        IRepository<Order_Details_Extended, Tuple<float, int, int, string, short, decimal>> Order_Details_Extendeds { get; }

        /// <summary>
        /// The Order_Subtotal entities repository.
        /// </summary>
        IRepository<Order_Subtotal, int> Order_Subtotals { get; }

        /// <summary>
        /// The Order entities repository.
        /// </summary>
        IRepository<Order, int> Orders { get; }

        /// <summary>
        /// The Orders_Qry entities repository.
        /// </summary>
        IRepository<Orders_Qry, Tuple<string, int>> Orders_Qries { get; }

        /// <summary>
        /// The Product_Sales_for_1997 entities repository.
        /// </summary>
        IRepository<Product_Sales_for_1997, Tuple<string, string>> Product_Sales_for_1997 { get; }

        /// <summary>
        /// The Product entities repository.
        /// </summary>
        IRepository<Product, int> Products { get; }

        /// <summary>
        /// The Products_by_Category entities repository.
        /// </summary>
        IRepository<Products_by_Category, Tuple<string, bool, string>> Products_by_Categories { get; }

        /// <summary>
        /// The Region entities repository.
        /// </summary>
        IRepository<Region, int> Regions { get; }

        /// <summary>
        /// The Sales_by_Category entities repository.
        /// </summary>
        IRepository<Sales_by_Category, Tuple<int, string, string>> Sales_by_Categories { get; }

        /// <summary>
        /// The Sales_Totals_by_Amount entities repository.
        /// </summary>
        IRepository<Sales_Totals_by_Amount, Tuple<string, int>> Sales_Totals_by_Amounts { get; }

        /// <summary>
        /// The Shipper entities repository.
        /// </summary>
        IRepository<Shipper, int> Shippers { get; }

        /// <summary>
        /// The Supplier entities repository.
        /// </summary>
        IRepository<Supplier, int> Suppliers { get; }

        /// <summary>
        /// The Territory entities repository.
        /// </summary>
        IRepository<Territory, string> Territories { get; }
    }
}
