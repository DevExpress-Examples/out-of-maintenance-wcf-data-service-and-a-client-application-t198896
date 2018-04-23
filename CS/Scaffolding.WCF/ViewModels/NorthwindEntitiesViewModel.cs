using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Scaffolding.WCF.Common.DataModel;
using Scaffolding.WCF.Common.ViewModel;
using Scaffolding.WCF.NorthwindEntitiesDataModel;
using Scaffolding.WCF.NorthwindEntities;

namespace Scaffolding.WCF.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the NorthwindEntities data model.
    /// </summary>
    public partial class NorthwindEntitiesViewModel : DocumentsViewModel<NorthwindEntitiesModuleDescription, INorthwindEntitiesUnitOfWork> {

        const string TablesGroup = "Tables";

        const string ViewsGroup = "Views";

        /// <summary>
        /// Creates a new instance of NorthwindEntitiesViewModel as a POCO view model.
        /// </summary>
        public static NorthwindEntitiesViewModel Create() {
            return ViewModelSource.Create(() => new NorthwindEntitiesViewModel());
        }

        /// <summary>
        /// Initializes a new instance of the NorthwindEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the NorthwindEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected NorthwindEntitiesViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override NorthwindEntitiesModuleDescription[] CreateModules() {
            return new NorthwindEntitiesModuleDescription[] {
                new NorthwindEntitiesModuleDescription("Categories", "CategoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Categories)),
                new NorthwindEntitiesModuleDescription("Category Sales for 1997", "Category_Sales_for_1997CollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Category_Sales_for_1997)),
                new NorthwindEntitiesModuleDescription("Current Product Lists", "Current_Product_ListCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Current_Product_Lists)),
                new NorthwindEntitiesModuleDescription("Customer Demographics", "CustomerDemographicCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.CustomerDemographics)),
                new NorthwindEntitiesModuleDescription("Customers", "CustomerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customers)),
                new NorthwindEntitiesModuleDescription("Employees", "EmployeeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Employees)),
                new NorthwindEntitiesModuleDescription("Invoices", "InvoiceCollectionView", TablesGroup),
                new NorthwindEntitiesModuleDescription("Order Details", "Order_DetailCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Order_Details)),
                new NorthwindEntitiesModuleDescription("Order Details Extendeds", "Order_Details_ExtendedCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Order_Details_Extendeds)),
                new NorthwindEntitiesModuleDescription("Order Subtotals", "Order_SubtotalCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Order_Subtotals)),
                new NorthwindEntitiesModuleDescription("Orders", "OrderCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Orders)),
                new NorthwindEntitiesModuleDescription("Orders Qries", "Orders_QryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Orders_Qries)),
                new NorthwindEntitiesModuleDescription("Product Sales for 1997", "Product_Sales_for_1997CollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Product_Sales_for_1997)),
                new NorthwindEntitiesModuleDescription("Products", "ProductCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Products)),
                new NorthwindEntitiesModuleDescription("Products by Categories", "Products_by_CategoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Products_by_Categories)),
                new NorthwindEntitiesModuleDescription("Regions", "RegionCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Regions)),
                new NorthwindEntitiesModuleDescription("Sales by Categories", "Sales_by_CategoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Sales_by_Categories)),
                new NorthwindEntitiesModuleDescription("Sales Totals by Amounts", "Sales_Totals_by_AmountCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Sales_Totals_by_Amounts)),
                new NorthwindEntitiesModuleDescription("Shippers", "ShipperCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Shippers)),
                new NorthwindEntitiesModuleDescription("Suppliers", "SupplierCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Suppliers)),
                new NorthwindEntitiesModuleDescription("Territories", "TerritoryCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Territories)),
            };
        }



    }

    public partial class NorthwindEntitiesModuleDescription : ModuleDescription<NorthwindEntitiesModuleDescription> {
        public NorthwindEntitiesModuleDescription(string title, string documentType, string group, Func<NorthwindEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}