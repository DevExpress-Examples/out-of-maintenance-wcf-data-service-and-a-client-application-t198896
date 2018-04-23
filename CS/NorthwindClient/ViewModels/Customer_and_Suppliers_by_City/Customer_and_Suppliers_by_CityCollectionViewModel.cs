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
    /// Represents the Customer_and_Suppliers_by_Cities collection view model.
    /// </summary>
    public partial class Customer_and_Suppliers_by_CityCollectionViewModel : ReadOnlyCollectionViewModel<Customer_and_Suppliers_by_City, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Customer_and_Suppliers_by_CityCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Customer_and_Suppliers_by_CityCollectionViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Customer_and_Suppliers_by_CityCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Customer_and_Suppliers_by_CityCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Customer_and_Suppliers_by_CityCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Customer_and_Suppliers_by_CityCollectionViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customer_and_Suppliers_by_Cities) {
        }
    }
}