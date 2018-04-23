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
    /// Represents the Alphabetical_list_of_products collection view model.
    /// </summary>
    public partial class Alphabetical_list_of_productCollectionViewModel : ReadOnlyCollectionViewModel<Alphabetical_list_of_product, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Alphabetical_list_of_productCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Alphabetical_list_of_productCollectionViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Alphabetical_list_of_productCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Alphabetical_list_of_productCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Alphabetical_list_of_productCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Alphabetical_list_of_productCollectionViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Alphabetical_list_of_products) {
        }
    }
}