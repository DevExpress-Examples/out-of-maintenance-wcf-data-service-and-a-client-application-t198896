using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using NorthwindClient.Common.DataModel;
using NorthwindClient.Common.ViewModel;
using NorthwindClient.Northwind2012EntitiesDataModel;
using NorthwindClient.ServiceReference1;

namespace NorthwindClient.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the Northwind2012Entities data model.
    /// </summary>
    public partial class Northwind2012EntitiesViewModel : DocumentsViewModel<Northwind2012EntitiesModuleDescription, INorthwind2012EntitiesUnitOfWork> {

        const string TablesGroup = "Tables";

        const string ViewsGroup = "Views";

        /// <summary>
        /// Creates a new instance of Northwind2012EntitiesViewModel as a POCO view model.
        /// </summary>
        public static Northwind2012EntitiesViewModel Create() {
            return ViewModelSource.Create(() => new Northwind2012EntitiesViewModel());
        }

        /// <summary>
        /// Initializes a new instance of the Northwind2012EntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Northwind2012EntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected Northwind2012EntitiesViewModel()
            : base(() => UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override Northwind2012EntitiesModuleDescription[] CreateModules() {
            return new Northwind2012EntitiesModuleDescription[] {
                new Northwind2012EntitiesModuleDescription("Categories", "CategoryCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Categories)),
                new Northwind2012EntitiesModuleDescription("Customer Demographics", "CustomerDemographicCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.CustomerDemographics)),
                new Northwind2012EntitiesModuleDescription("Customers", "CustomerCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Customers)),
                new Northwind2012EntitiesModuleDescription("Employees", "EmployeeCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Employees)),
                new Northwind2012EntitiesModuleDescription("Order Details", "Order_DetailCollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Orders", "OrderCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Orders)),
                new Northwind2012EntitiesModuleDescription("Products", "ProductCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Products)),
                new Northwind2012EntitiesModuleDescription("Regions", "RegionCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Regions)),
                new Northwind2012EntitiesModuleDescription("Shippers", "ShipperCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Shippers)),
                new Northwind2012EntitiesModuleDescription("Suppliers", "SupplierCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Suppliers)),
                new Northwind2012EntitiesModuleDescription("Territories", "TerritoryCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Territories)),
                new Northwind2012EntitiesModuleDescription("Alphabetical list of products", "Alphabetical_list_of_productCollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Category Sales for 1997", "Category_Sales_for_1997CollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Category_Sales_for_1997)),
                new Northwind2012EntitiesModuleDescription("Current Product Lists", "Current_Product_ListCollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Customer and Suppliers by Cities", "Customer_and_Suppliers_by_CityCollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Invoices", "InvoiceCollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Order Details Extendeds", "Order_Details_ExtendedCollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Order Subtotals", "Order_SubtotalCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Order_Subtotals)),
                new Northwind2012EntitiesModuleDescription("Orders Qries", "Orders_QryCollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Product Sales for 1997", "Product_Sales_for_1997CollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Products Above Average Prices", "Products_Above_Average_PriceCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Products_Above_Average_Prices)),
                new Northwind2012EntitiesModuleDescription("Products by Categories", "Products_by_CategoryCollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Sales by Categories", "Sales_by_CategoryCollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Sales Totals by Amounts", "Sales_Totals_by_AmountCollectionView", TablesGroup),
                new Northwind2012EntitiesModuleDescription("Summary of Sales by Quarters", "Summary_of_Sales_by_QuarterCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Summary_of_Sales_by_Quarters)),
                new Northwind2012EntitiesModuleDescription("Summary of Sales by Years", "Summary_of_Sales_by_YearCollectionView", TablesGroup, m => GetPeekCollectionViewModelFactory(m, x => x.Summary_of_Sales_by_Years)),
			};
        }


    }

    public partial class Northwind2012EntitiesModuleDescription : ModuleDescription<Northwind2012EntitiesModuleDescription> {
        public Northwind2012EntitiesModuleDescription(string title, string documentType, string group, Func<Northwind2012EntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}