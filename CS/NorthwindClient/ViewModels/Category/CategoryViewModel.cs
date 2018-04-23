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
    /// Represents the single Category object view model.
    /// </summary>
    public partial class CategoryViewModel : SingleObjectViewModel<Category, int, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CategoryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CategoryViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CategoryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CategoryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CategoryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CategoryViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Categories, x => x.CategoryName) {
        }

        /// <summary>
        /// The view model for the CategoryProducts detail collection.
        /// </summary>
        public CollectionViewModel<Product, int, INorthwind2012EntitiesUnitOfWork> CategoryProductsDetails {
            get { return GetDetailsCollectionViewModel((CategoryViewModel x) => x.CategoryProductsDetails, x => x.Products, x => x.CategoryID, (x, key) => x.CategoryID = key); }
        }
    }
}
