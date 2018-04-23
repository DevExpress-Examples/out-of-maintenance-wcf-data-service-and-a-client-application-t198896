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
    /// Represents the single Product object view model.
    /// </summary>
    public partial class ProductViewModel : SingleObjectViewModel<Product, int, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProductViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProductViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProductViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProductViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProductViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProductViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Products, x => x.ProductName) {
        }

        /// <summary>
        /// The look-up collection of Categories for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Category> LookUpCategories {
            get { return GetLookUpEntitiesViewModel((ProductViewModel x) => x.LookUpCategories, x => x.Categories); }
        }

        /// <summary>
        /// The look-up collection of Suppliers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Supplier> LookUpSuppliers {
            get { return GetLookUpEntitiesViewModel((ProductViewModel x) => x.LookUpSuppliers, x => x.Suppliers); }
        }

        /// <summary>
        /// The view model for the ProductOrder_Details detail collection.
        /// </summary>
        public ReadOnlyCollectionViewModel<Order_Detail, INorthwind2012EntitiesUnitOfWork> ProductOrder_DetailsDetails {
            get { return GetReadOnlyDetailsCollectionViewModel((ProductViewModel x) => x.ProductOrder_DetailsDetails, x => x.Order_Details, x => x.ProductID); }
        }
    }
}
