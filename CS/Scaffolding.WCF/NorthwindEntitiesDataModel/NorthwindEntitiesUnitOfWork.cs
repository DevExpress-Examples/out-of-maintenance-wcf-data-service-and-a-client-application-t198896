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
    using NorthwindEntities = Scaffolding.WCF.NorthwindEntities.NorthwindEntities;
    /// <summary>
    /// A NorthwindEntitiesUnitOfWork instance that represents the run-time implementation of the INorthwindEntitiesUnitOfWork interface.
    /// </summary>
    public class NorthwindEntitiesUnitOfWork : DbUnitOfWork<NorthwindEntities>, INorthwindEntitiesUnitOfWork {

        public NorthwindEntitiesUnitOfWork(Func<NorthwindEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Category, int> INorthwindEntitiesUnitOfWork.Categories {
            get { return GetRepository(x => x.Categories, (Category x) => x.CategoryID); }
        }

        IRepository<Category_Sales_for_1997, string> INorthwindEntitiesUnitOfWork.Category_Sales_for_1997 {
            get { return GetRepository(x => x.Category_Sales_for_1997, (Category_Sales_for_1997 x) => x.CategoryName); }
        }

        IRepository<Current_Product_List, Tuple<int, string>> INorthwindEntitiesUnitOfWork.Current_Product_Lists {
            get { return GetRepository(x => x.Current_Product_Lists, (Current_Product_List x) => Tuple.Create(x.ProductID, x.ProductName)); }
        }

        IRepository<CustomerDemographic, string> INorthwindEntitiesUnitOfWork.CustomerDemographics {
            get { return GetRepository(x => x.CustomerDemographics, (CustomerDemographic x) => x.CustomerTypeID); }
        }

        IRepository<Customer, string> INorthwindEntitiesUnitOfWork.Customers {
            get { return GetRepository(x => x.Customers, (Customer x) => x.CustomerID); }
        }

        IRepository<Employee, int> INorthwindEntitiesUnitOfWork.Employees {
            get { return GetRepository(x => x.Employees, (Employee x) => x.EmployeeID); }
        }

        IReadOnlyRepository<Invoice> INorthwindEntitiesUnitOfWork.Invoices {
            get { return GetReadOnlyRepository(x => x.Invoices); }
        }

        IRepository<Order_Detail, Tuple<int, int>> INorthwindEntitiesUnitOfWork.Order_Details {
            get { return GetRepository(x => x.Order_Details, (Order_Detail x) => Tuple.Create(x.OrderID, x.ProductID)); }
        }

        IRepository<Order_Details_Extended, Tuple<float, int, int, string, short, decimal>> INorthwindEntitiesUnitOfWork.Order_Details_Extendeds {
            get { return GetRepository(x => x.Order_Details_Extendeds, (Order_Details_Extended x) => Tuple.Create(x.Discount, x.OrderID, x.ProductID, x.ProductName, x.Quantity, x.UnitPrice)); }
        }

        IRepository<Order_Subtotal, int> INorthwindEntitiesUnitOfWork.Order_Subtotals {
            get { return GetRepository(x => x.Order_Subtotals, (Order_Subtotal x) => x.OrderID); }
        }

        IRepository<Order, int> INorthwindEntitiesUnitOfWork.Orders {
            get { return GetRepository(x => x.Orders, (Order x) => x.OrderID); }
        }

        IRepository<Orders_Qry, Tuple<string, int>> INorthwindEntitiesUnitOfWork.Orders_Qries {
            get { return GetRepository(x => x.Orders_Qries, (Orders_Qry x) => Tuple.Create(x.CompanyName, x.OrderID)); }
        }

        IRepository<Product_Sales_for_1997, Tuple<string, string>> INorthwindEntitiesUnitOfWork.Product_Sales_for_1997 {
            get { return GetRepository(x => x.Product_Sales_for_1997, (Product_Sales_for_1997 x) => Tuple.Create(x.CategoryName, x.ProductName)); }
        }

        IRepository<Product, int> INorthwindEntitiesUnitOfWork.Products {
            get { return GetRepository(x => x.Products, (Product x) => x.ProductID); }
        }

        IRepository<Products_by_Category, Tuple<string, bool, string>> INorthwindEntitiesUnitOfWork.Products_by_Categories {
            get { return GetRepository(x => x.Products_by_Categories, (Products_by_Category x) => Tuple.Create(x.CategoryName, x.Discontinued, x.ProductName)); }
        }

        IRepository<Region, int> INorthwindEntitiesUnitOfWork.Regions {
            get { return GetRepository(x => x.Regions, (Region x) => x.RegionID); }
        }

        IRepository<Sales_by_Category, Tuple<int, string, string>> INorthwindEntitiesUnitOfWork.Sales_by_Categories {
            get { return GetRepository(x => x.Sales_by_Categories, (Sales_by_Category x) => Tuple.Create(x.CategoryID, x.CategoryName, x.ProductName)); }
        }

        IRepository<Sales_Totals_by_Amount, Tuple<string, int>> INorthwindEntitiesUnitOfWork.Sales_Totals_by_Amounts {
            get { return GetRepository(x => x.Sales_Totals_by_Amounts, (Sales_Totals_by_Amount x) => Tuple.Create(x.CompanyName, x.OrderID)); }
        }

        IRepository<Shipper, int> INorthwindEntitiesUnitOfWork.Shippers {
            get { return GetRepository(x => x.Shippers, (Shipper x) => x.ShipperID); }
        }

        IRepository<Supplier, int> INorthwindEntitiesUnitOfWork.Suppliers {
            get { return GetRepository(x => x.Suppliers, (Supplier x) => x.SupplierID); }
        }

        IRepository<Territory, string> INorthwindEntitiesUnitOfWork.Territories {
            get { return GetRepository(x => x.Territories, (Territory x) => x.TerritoryID); }
        }
    }
}
