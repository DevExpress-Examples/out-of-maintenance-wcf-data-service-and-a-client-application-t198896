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
    /// INorthwind2012EntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface INorthwind2012EntitiesUnitOfWork : IUnitOfWork {

        /// <summary>
        /// The Category entities repository.
        /// </summary>
        IRepository<Category, int> Categories { get; }

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
        /// The Order_Detail entities repository.
        /// </summary>
        IReadOnlyRepository<Order_Detail> Order_Details { get; }

        /// <summary>
        /// The Order entities repository.
        /// </summary>
        IRepository<Order, int> Orders { get; }

        /// <summary>
        /// The Product entities repository.
        /// </summary>
        IRepository<Product, int> Products { get; }

        /// <summary>
        /// The Region entities repository.
        /// </summary>
        IRepository<Region, int> Regions { get; }

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

        /// <summary>
        /// The Alphabetical_list_of_product entities repository.
        /// </summary>
        IReadOnlyRepository<Alphabetical_list_of_product> Alphabetical_list_of_products { get; }

        /// <summary>
        /// The Category_Sales_for_1997 entities repository.
        /// </summary>
        IRepository<Category_Sales_for_1997, string> Category_Sales_for_1997 { get; }

        /// <summary>
        /// The Current_Product_List entities repository.
        /// </summary>
        IReadOnlyRepository<Current_Product_List> Current_Product_Lists { get; }

        /// <summary>
        /// The Customer_and_Suppliers_by_City entities repository.
        /// </summary>
        IReadOnlyRepository<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_Cities { get; }

        /// <summary>
        /// The Invoice entities repository.
        /// </summary>
        IReadOnlyRepository<Invoice> Invoices { get; }

        /// <summary>
        /// The Order_Details_Extended entities repository.
        /// </summary>
        IReadOnlyRepository<Order_Details_Extended> Order_Details_Extendeds { get; }

        /// <summary>
        /// The Order_Subtotal entities repository.
        /// </summary>
        IRepository<Order_Subtotal, int> Order_Subtotals { get; }

        /// <summary>
        /// The Orders_Qry entities repository.
        /// </summary>
        IReadOnlyRepository<Orders_Qry> Orders_Qries { get; }

        /// <summary>
        /// The Product_Sales_for_1997 entities repository.
        /// </summary>
        IReadOnlyRepository<Product_Sales_for_1997> Product_Sales_for_1997 { get; }

        /// <summary>
        /// The Products_Above_Average_Price entities repository.
        /// </summary>
        IRepository<Products_Above_Average_Price, string> Products_Above_Average_Prices { get; }

        /// <summary>
        /// The Products_by_Category entities repository.
        /// </summary>
        IReadOnlyRepository<Products_by_Category> Products_by_Categories { get; }

        /// <summary>
        /// The Sales_by_Category entities repository.
        /// </summary>
        IReadOnlyRepository<Sales_by_Category> Sales_by_Categories { get; }

        /// <summary>
        /// The Sales_Totals_by_Amount entities repository.
        /// </summary>
        IReadOnlyRepository<Sales_Totals_by_Amount> Sales_Totals_by_Amounts { get; }

        /// <summary>
        /// The Summary_of_Sales_by_Quarter entities repository.
        /// </summary>
        IRepository<Summary_of_Sales_by_Quarter, int> Summary_of_Sales_by_Quarters { get; }

        /// <summary>
        /// The Summary_of_Sales_by_Year entities repository.
        /// </summary>
        IRepository<Summary_of_Sales_by_Year, int> Summary_of_Sales_by_Years { get; }
    }
}
