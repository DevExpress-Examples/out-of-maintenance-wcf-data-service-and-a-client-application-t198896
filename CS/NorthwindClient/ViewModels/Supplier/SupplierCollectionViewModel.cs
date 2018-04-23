using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using NorthwindClient.Common.Utils;
using NorthwindClient.Northwind2012EntitiesDataModel;
using NorthwindClient.Common.DataModel;
using NorthwindClient.ServiceReference1;
using NorthwindClient.Common.ViewModel;

namespace NorthwindClient.ViewModels {
    /// <summary>
    /// Represents the Suppliers collection view model.
    /// </summary>
    public partial class SupplierCollectionViewModel : CollectionViewModel<Supplier, int, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SupplierCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SupplierCollectionViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SupplierCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SupplierCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SupplierCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SupplierCollectionViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Suppliers) {
        }
    }
}