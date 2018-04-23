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
    /// A NorthwindEntitiesDesignTimeUnitOfWork instance that represents the design-time implementation of the INorthwindEntitiesUnitOfWork interface.
    /// </summary>
    public class NorthwindEntitiesDesignTimeUnitOfWork : DesignTimeUnitOfWork, INorthwindEntitiesUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the NorthwindEntitiesDesignTimeUnitOfWork class.
        /// </summary>
        public NorthwindEntitiesDesignTimeUnitOfWork() {
        }

        IRepository<Category, int> INorthwindEntitiesUnitOfWork.Categories {
            get { return GetRepository((Category x) => x.CategoryID); }
        }

        IRepository<Category_Sales_for_1997, string> INorthwindEntitiesUnitOfWork.Category_Sales_for_1997 {
            get { return GetRepository((Category_Sales_for_1997 x) => x.CategoryName); }
        }

        IRepository<Current_Product_List, Tuple<int, string>> INorthwindEntitiesUnitOfWork.Current_Product_Lists {
            get { return GetRepository((Current_Product_List x) => Tuple.Create(x.ProductID, x.ProductName)); }
        }

        IRepository<CustomerDemographic, string> INorthwindEntitiesUnitOfWork.CustomerDemographics {
            get { return GetRepository((CustomerDemographic x) => x.CustomerTypeID); }
        }

        IRepository<Customer, string> INorthwindEntitiesUnitOfWork.Customers {
            get { return GetRepository((Customer x) => x.CustomerID); }
        }

        IRepository<Employee, int> INorthwindEntitiesUnitOfWork.Employees {
            get { return GetRepository((Employee x) => x.EmployeeID); }
        }

        IReadOnlyRepository<Invoice> INorthwindEntitiesUnitOfWork.Invoices {
            get { return GetReadOnlyRepository<Invoice>(); }
        }

        IRepository<Order_Detail, Tuple<int, int>> INorthwindEntitiesUnitOfWork.Order_Details {
            get { return GetRepository((Order_Detail x) => Tuple.Create(x.OrderID, x.ProductID)); }
        }

        IRepository<Order_Details_Extended, Tuple<float, int, int, string, short, decimal>> INorthwindEntitiesUnitOfWork.Order_Details_Extendeds {
            get { return GetRepository((Order_Details_Extended x) => Tuple.Create(x.Discount, x.OrderID, x.ProductID, x.ProductName, x.Quantity, x.UnitPrice)); }
        }

        IRepository<Order_Subtotal, int> INorthwindEntitiesUnitOfWork.Order_Subtotals {
            get { return GetRepository((Order_Subtotal x) => x.OrderID); }
        }

        IRepository<Order, int> INorthwindEntitiesUnitOfWork.Orders {
            get { return GetRepository((Order x) => x.OrderID); }
        }

        IRepository<Orders_Qry, Tuple<string, int>> INorthwindEntitiesUnitOfWork.Orders_Qries {
            get { return GetRepository((Orders_Qry x) => Tuple.Create(x.CompanyName, x.OrderID)); }
        }

        IRepository<Product_Sales_for_1997, Tuple<string, string>> INorthwindEntitiesUnitOfWork.Product_Sales_for_1997 {
            get { return GetRepository((Product_Sales_for_1997 x) => Tuple.Create(x.CategoryName, x.ProductName)); }
        }

        IRepository<Product, int> INorthwindEntitiesUnitOfWork.Products {
            get { return GetRepository((Product x) => x.ProductID); }
        }

        IRepository<Products_by_Category, Tuple<string, bool, string>> INorthwindEntitiesUnitOfWork.Products_by_Categories {
            get { return GetRepository((Products_by_Category x) => Tuple.Create(x.CategoryName, x.Discontinued, x.ProductName)); }
        }

        IRepository<Region, int> INorthwindEntitiesUnitOfWork.Regions {
            get { return GetRepository((Region x) => x.RegionID); }
        }

        IRepository<Sales_by_Category, Tuple<int, string, string>> INorthwindEntitiesUnitOfWork.Sales_by_Categories {
            get { return GetRepository((Sales_by_Category x) => Tuple.Create(x.CategoryID, x.CategoryName, x.ProductName)); }
        }

        IRepository<Sales_Totals_by_Amount, Tuple<string, int>> INorthwindEntitiesUnitOfWork.Sales_Totals_by_Amounts {
            get { return GetRepository((Sales_Totals_by_Amount x) => Tuple.Create(x.CompanyName, x.OrderID)); }
        }

        IRepository<Shipper, int> INorthwindEntitiesUnitOfWork.Shippers {
            get { return GetRepository((Shipper x) => x.ShipperID); }
        }

        IRepository<Supplier, int> INorthwindEntitiesUnitOfWork.Suppliers {
            get { return GetRepository((Supplier x) => x.SupplierID); }
        }

        IRepository<Territory, string> INorthwindEntitiesUnitOfWork.Territories {
            get { return GetRepository((Territory x) => x.TerritoryID); }
        }
    }
}
