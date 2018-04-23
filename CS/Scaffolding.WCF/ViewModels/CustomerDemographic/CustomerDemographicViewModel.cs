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
    /// Represents the single CustomerDemographic object view model.
    /// </summary>
    public partial class CustomerDemographicViewModel : SingleObjectViewModel<CustomerDemographic, string, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerDemographicViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerDemographicViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerDemographicViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerDemographicViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerDemographicViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerDemographicViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CustomerDemographics, x => x.CustomerDesc) {
        }
        protected override void RefreshLookUpCollections(bool raisePropertyChanged) {
            base.RefreshLookUpCollections(raisePropertyChanged);
            CustomersDetailEntities = CreateAddRemoveDetailEntitiesViewModel(x => x.Customers, x => x.Customers);
        }
        public virtual AddRemoveDetailEntitiesViewModel<CustomerDemographic, String, Customer, String, INorthwindEntitiesUnitOfWork> CustomersDetailEntities { get; protected set; }
    }
}
