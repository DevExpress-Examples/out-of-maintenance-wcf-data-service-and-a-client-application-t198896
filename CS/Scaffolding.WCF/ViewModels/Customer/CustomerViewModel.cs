using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using Scaffolding.WCF.Common.Utils;
using Scaffolding.WCF.NorthwindEntitiesDataModel;
using Scaffolding.WCF.Common.DataModel;
using Scaffolding.WCF.NorthwindEntities;
using Scaffolding.WCF.Common.ViewModel;

namespace Scaffolding.WCF.ViewModels {
    /// <summary>
    /// Represents the single Customer object view model.
    /// </summary>
    public partial class CustomerViewModel : SingleObjectViewModel<Customer, string, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customers, x => x.CompanyName) {
        }
        protected override void RefreshLookUpCollections(bool raisePropertyChanged) {
            base.RefreshLookUpCollections(raisePropertyChanged);
            CustomerDemographicsDetailEntities = CreateAddRemoveDetailEntitiesViewModel(x => x.CustomerDemographics, x => x.CustomerDemographics);
        }
        public virtual AddRemoveDetailEntitiesViewModel<Customer, String, CustomerDemographic, String, INorthwindEntitiesUnitOfWork> CustomerDemographicsDetailEntities { get; protected set; }

        /// <summary>
        /// The view model for the CustomerOrders detail collection.
        /// </summary>
        public CollectionViewModel<Order, int, INorthwindEntitiesUnitOfWork> CustomerOrdersDetails {
            get { return GetDetailsCollectionViewModel((CustomerViewModel x) => x.CustomerOrdersDetails, x => x.Orders, x => x.CustomerID, (x, key) => { x.CustomerID = key; }); }
        }
    }
}
