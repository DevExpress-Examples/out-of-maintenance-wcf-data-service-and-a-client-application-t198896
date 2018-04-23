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
    /// A Northwind2012EntitiesDesignTimeUnitOfWork instance that represents the design-time implementation of the INorthwind2012EntitiesUnitOfWork interface.
    /// </summary>
    public class Northwind2012EntitiesDesignTimeUnitOfWork : DesignTimeUnitOfWork, INorthwind2012EntitiesUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the Northwind2012EntitiesDesignTimeUnitOfWork class.
        /// </summary>
        public Northwind2012EntitiesDesignTimeUnitOfWork() {
        }

        IRepository<Category, int> INorthwind2012EntitiesUnitOfWork.Categories {
            get { return GetRepository((Category x) => x.CategoryID); }
        }

        IRepository<CustomerDemographic, string> INorthwind2012EntitiesUnitOfWork.CustomerDemographics {
            get { return GetRepository((CustomerDemographic x) => x.CustomerTypeID); }
        }

        IRepository<Customer, string> INorthwind2012EntitiesUnitOfWork.Customers {
            get { return GetRepository((Customer x) => x.CustomerID); }
        }

        IRepository<Employee, int> INorthwind2012EntitiesUnitOfWork.Employees {
            get { return GetRepository((Employee x) => x.EmployeeID); }
        }

        IReadOnlyRepository<Order_Detail> INorthwind2012EntitiesUnitOfWork.Order_Details {
            get { return GetReadOnlyRepository<Order_Detail>(); }
        }

        IRepository<Order, int> INorthwind2012EntitiesUnitOfWork.Orders {
            get { return GetRepository((Order x) => x.OrderID); }
        }

        IRepository<Product, int> INorthwind2012EntitiesUnitOfWork.Products {
            get { return GetRepository((Product x) => x.ProductID); }
        }

        IRepository<Region, int> INorthwind2012EntitiesUnitOfWork.Regions {
            get { return GetRepository((Region x) => x.RegionID); }
        }

        IRepository<Shipper, int> INorthwind2012EntitiesUnitOfWork.Shippers {
            get { return GetRepository((Shipper x) => x.ShipperID); }
        }

        IRepository<Supplier, int> INorthwind2012EntitiesUnitOfWork.Suppliers {
            get { return GetRepository((Supplier x) => x.SupplierID); }
        }

        IRepository<Territory, string> INorthwind2012EntitiesUnitOfWork.Territories {
            get { return GetRepository((Territory x) => x.TerritoryID); }
        }

        IReadOnlyRepository<Alphabetical_list_of_product> INorthwind2012EntitiesUnitOfWork.Alphabetical_list_of_products {
            get { return GetReadOnlyRepository<Alphabetical_list_of_product>(); }
        }

        IRepository<Category_Sales_for_1997, string> INorthwind2012EntitiesUnitOfWork.Category_Sales_for_1997 {
            get { return GetRepository((Category_Sales_for_1997 x) => x.CategoryName); }
        }

        IReadOnlyRepository<Current_Product_List> INorthwind2012EntitiesUnitOfWork.Current_Product_Lists {
            get { return GetReadOnlyRepository<Current_Product_List>(); }
        }

        IReadOnlyRepository<Customer_and_Suppliers_by_City> INorthwind2012EntitiesUnitOfWork.Customer_and_Suppliers_by_Cities {
            get { return GetReadOnlyRepository<Customer_and_Suppliers_by_City>(); }
        }

        IReadOnlyRepository<Invoice> INorthwind2012EntitiesUnitOfWork.Invoices {
            get { return GetReadOnlyRepository<Invoice>(); }
        }

        IReadOnlyRepository<Order_Details_Extended> INorthwind2012EntitiesUnitOfWork.Order_Details_Extendeds {
            get { return GetReadOnlyRepository<Order_Details_Extended>(); }
        }

        IRepository<Order_Subtotal, int> INorthwind2012EntitiesUnitOfWork.Order_Subtotals {
            get { return GetRepository((Order_Subtotal x) => x.OrderID); }
        }

        IReadOnlyRepository<Orders_Qry> INorthwind2012EntitiesUnitOfWork.Orders_Qries {
            get { return GetReadOnlyRepository<Orders_Qry>(); }
        }

        IReadOnlyRepository<Product_Sales_for_1997> INorthwind2012EntitiesUnitOfWork.Product_Sales_for_1997 {
            get { return GetReadOnlyRepository<Product_Sales_for_1997>(); }
        }

        IRepository<Products_Above_Average_Price, string> INorthwind2012EntitiesUnitOfWork.Products_Above_Average_Prices {
            get { return GetRepository((Products_Above_Average_Price x) => x.ProductName); }
        }

        IReadOnlyRepository<Products_by_Category> INorthwind2012EntitiesUnitOfWork.Products_by_Categories {
            get { return GetReadOnlyRepository<Products_by_Category>(); }
        }

        IReadOnlyRepository<Sales_by_Category> INorthwind2012EntitiesUnitOfWork.Sales_by_Categories {
            get { return GetReadOnlyRepository<Sales_by_Category>(); }
        }

        IReadOnlyRepository<Sales_Totals_by_Amount> INorthwind2012EntitiesUnitOfWork.Sales_Totals_by_Amounts {
            get { return GetReadOnlyRepository<Sales_Totals_by_Amount>(); }
        }

        IRepository<Summary_of_Sales_by_Quarter, int> INorthwind2012EntitiesUnitOfWork.Summary_of_Sales_by_Quarters {
            get { return GetRepository((Summary_of_Sales_by_Quarter x) => x.OrderID); }
        }

        IRepository<Summary_of_Sales_by_Year, int> INorthwind2012EntitiesUnitOfWork.Summary_of_Sales_by_Years {
            get { return GetRepository((Summary_of_Sales_by_Year x) => x.OrderID); }
        }
    }
}
