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
    /// Represents the single Territory object view model.
    /// </summary>
    public partial class TerritoryViewModel : SingleObjectViewModel<Territory, string, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TerritoryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TerritoryViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TerritoryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TerritoryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TerritoryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TerritoryViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Territories, x => x.TerritoryDescription) {
        }


        /// <summary>
		/// The view model that contains a look-up collection of Regions for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Region> LookUpRegions {
            get { return GetLookUpEntitiesViewModel((TerritoryViewModel x) => x.LookUpRegions, x => x.Regions); }
        }
        protected override void RefreshLookUpCollections(bool raisePropertyChanged) {
            base.RefreshLookUpCollections(raisePropertyChanged);
            EmployeesDetailEntities = CreateAddRemoveDetailEntitiesViewModel(x => x.Employees, x => x.Employees);
        }
        public virtual AddRemoveDetailEntitiesViewModel<Territory, String, Employee, Int32, INorthwindEntitiesUnitOfWork> EmployeesDetailEntities { get; protected set; }
    }
}
