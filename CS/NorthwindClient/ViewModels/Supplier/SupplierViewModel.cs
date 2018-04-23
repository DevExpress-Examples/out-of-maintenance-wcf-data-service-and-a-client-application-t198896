using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using NorthwindClient.Common.Utils;
using NorthwindClient.Northwind2012EntitiesDataModel;
using NorthwindClient.Common.DataModel;
using NorthwindClient.ServiceReference1;
using NorthwindClient.Common.ViewModel;

namespace NorthwindClient.ViewModels {
    /// <summary>
    /// Represents the single Supplier object view model.
    /// </summary>
    public partial class SupplierViewModel : SingleObjectViewModel<Supplier, int, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SupplierViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SupplierViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SupplierViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SupplierViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SupplierViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SupplierViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Suppliers, x => x.CompanyName) {
        }

        /// <summary>
        /// The view model for the SupplierProducts detail collection.
        /// </summary>
        public CollectionViewModel<Product, int, INorthwind2012EntitiesUnitOfWork> SupplierProductsDetails {
            get { return GetDetailsCollectionViewModel((SupplierViewModel x) => x.SupplierProductsDetails, x => x.Products, x => x.SupplierID, (x, key) => x.SupplierID = key); }
        }
    }
}
