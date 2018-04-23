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

namespace NorthwindClient.Northwind2012EntitiesDataModel {
    /// <summary>
    /// A Northwind2012EntitiesUnitOfWork instance that represents the run-time implementation of the INorthwind2012EntitiesUnitOfWork interface.
    /// </summary>
    public class Northwind2012EntitiesUnitOfWork : DbUnitOfWork<Northwind2012Entities>, INorthwind2012EntitiesUnitOfWork {

        public Northwind2012EntitiesUnitOfWork(Func<Northwind2012Entities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Category, int> INorthwind2012EntitiesUnitOfWork.Categories {
            get { return GetRepository(x => x.Categories, x => x.CategoryID); }
        }

        IRepository<CustomerDemographic, string> INorthwind2012EntitiesUnitOfWork.CustomerDemographics {
            get { return GetRepository(x => x.CustomerDemographics, x => x.CustomerTypeID); }
        }

        IRepository<Customer, string> INorthwind2012EntitiesUnitOfWork.Customers {
            get { return GetRepository(x => x.Customers, x => x.CustomerID); }
        }

        IRepository<Employee, int> INorthwind2012EntitiesUnitOfWork.Employees {
            get { return GetRepository(x => x.Employees, x => x.EmployeeID); }
        }

        IReadOnlyRepository<Order_Detail> INorthwind2012EntitiesUnitOfWork.Order_Details {
            get { return GetReadOnlyRepository(x => x.Order_Details); }
        }

        IRepository<Order, int> INorthwind2012EntitiesUnitOfWork.Orders {
            get { return GetRepository(x => x.Orders, x => x.OrderID); }
        }

        IRepository<Product, int> INorthwind2012EntitiesUnitOfWork.Products {
            get { return GetRepository(x => x.Products, x => x.ProductID); }
        }

        IRepository<Region, int> INorthwind2012EntitiesUnitOfWork.Regions {
            get { return GetRepository(x => x.Regions, x => x.RegionID); }
        }

        IRepository<Shipper, int> INorthwind2012EntitiesUnitOfWork.Shippers {
            get { return GetRepository(x => x.Shippers, x => x.ShipperID); }
        }

        IRepository<Supplier, int> INorthwind2012EntitiesUnitOfWork.Suppliers {
            get { return GetRepository(x => x.Suppliers, x => x.SupplierID); }
        }

        IRepository<Territory, string> INorthwind2012EntitiesUnitOfWork.Territories {
            get { return GetRepository(x => x.Territories, x => x.TerritoryID); }
        }

        IReadOnlyRepository<Alphabetical_list_of_product> INorthwind2012EntitiesUnitOfWork.Alphabetical_list_of_products {
            get { return GetReadOnlyRepository(x => x.Alphabetical_list_of_products); }
        }

        IRepository<Category_Sales_for_1997, string> INorthwind2012EntitiesUnitOfWork.Category_Sales_for_1997 {
            get { return GetRepository(x => x.Category_Sales_for_1997, x => x.CategoryName); }
        }

        IReadOnlyRepository<Current_Product_List> INorthwind2012EntitiesUnitOfWork.Current_Product_Lists {
            get { return GetReadOnlyRepository(x => x.Current_Product_Lists); }
        }

        IReadOnlyRepository<Customer_and_Suppliers_by_City> INorthwind2012EntitiesUnitOfWork.Customer_and_Suppliers_by_Cities {
            get { return GetReadOnlyRepository(x => x.Customer_and_Suppliers_by_Cities); }
        }

        IReadOnlyRepository<Invoice> INorthwind2012EntitiesUnitOfWork.Invoices {
            get { return GetReadOnlyRepository(x => x.Invoices); }
        }

        IReadOnlyRepository<Order_Details_Extended> INorthwind2012EntitiesUnitOfWork.Order_Details_Extendeds {
            get { return GetReadOnlyRepository(x => x.Order_Details_Extendeds); }
        }

        IRepository<Order_Subtotal, int> INorthwind2012EntitiesUnitOfWork.Order_Subtotals {
            get { return GetRepository(x => x.Order_Subtotals, x => x.OrderID); }
        }

        IReadOnlyRepository<Orders_Qry> INorthwind2012EntitiesUnitOfWork.Orders_Qries {
            get { return GetReadOnlyRepository(x => x.Orders_Qries); }
        }

        IReadOnlyRepository<Product_Sales_for_1997> INorthwind2012EntitiesUnitOfWork.Product_Sales_for_1997 {
            get { return GetReadOnlyRepository(x => x.Product_Sales_for_1997); }
        }

        IRepository<Products_Above_Average_Price, string> INorthwind2012EntitiesUnitOfWork.Products_Above_Average_Prices {
            get { return GetRepository(x => x.Products_Above_Average_Prices, x => x.ProductName); }
        }

        IReadOnlyRepository<Products_by_Category> INorthwind2012EntitiesUnitOfWork.Products_by_Categories {
            get { return GetReadOnlyRepository(x => x.Products_by_Categories); }
        }

        IReadOnlyRepository<Sales_by_Category> INorthwind2012EntitiesUnitOfWork.Sales_by_Categories {
            get { return GetReadOnlyRepository(x => x.Sales_by_Categories); }
        }

        IReadOnlyRepository<Sales_Totals_by_Amount> INorthwind2012EntitiesUnitOfWork.Sales_Totals_by_Amounts {
            get { return GetReadOnlyRepository(x => x.Sales_Totals_by_Amounts); }
        }

        IRepository<Summary_of_Sales_by_Quarter, int> INorthwind2012EntitiesUnitOfWork.Summary_of_Sales_by_Quarters {
            get { return GetRepository(x => x.Summary_of_Sales_by_Quarters, x => x.OrderID); }
        }

        IRepository<Summary_of_Sales_by_Year, int> INorthwind2012EntitiesUnitOfWork.Summary_of_Sales_by_Years {
            get { return GetRepository(x => x.Summary_of_Sales_by_Years, x => x.OrderID); }
        }
    }
}
