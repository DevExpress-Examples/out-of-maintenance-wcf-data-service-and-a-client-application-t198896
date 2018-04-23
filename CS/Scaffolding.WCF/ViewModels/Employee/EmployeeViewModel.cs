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
    /// Represents the single Employee object view model.
    /// </summary>
    public partial class EmployeeViewModel : SingleObjectViewModel<Employee, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EmployeeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EmployeeViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EmployeeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EmployeeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EmployeeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EmployeeViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Employees, x => x.LastName) {
        }


        /// <summary>
		/// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get { return GetLookUpEntitiesViewModel((EmployeeViewModel x) => x.LookUpEmployees, x => x.Employees); }
        }
        protected override void RefreshLookUpCollections(bool raisePropertyChanged) {
            base.RefreshLookUpCollections(raisePropertyChanged);
            TerritoriesDetailEntities = CreateAddRemoveDetailEntitiesViewModel(x => x.Territories, x => x.Territories);
        }
        public virtual AddRemoveDetailEntitiesViewModel<Employee, Int32, Territory, String, INorthwindEntitiesUnitOfWork> TerritoriesDetailEntities { get; protected set; }

        /// <summary>
        /// The view model for the EmployeeEmployees1 detail collection.
        /// </summary>
        public CollectionViewModel<Employee, int, INorthwindEntitiesUnitOfWork> EmployeeEmployees1Details {
            get { return GetDetailsCollectionViewModel((EmployeeViewModel x) => x.EmployeeEmployees1Details, x => x.Employees, x => x.ReportsTo, (x, key) => { x.ReportsTo = key; }); }
        }

        /// <summary>
        /// The view model for the EmployeeOrders detail collection.
        /// </summary>
        public CollectionViewModel<Order, int, INorthwindEntitiesUnitOfWork> EmployeeOrdersDetails {
            get { return GetDetailsCollectionViewModel((EmployeeViewModel x) => x.EmployeeOrdersDetails, x => x.Orders, x => x.EmployeeID, (x, key) => { x.EmployeeID = key; }); }
        }
    }
}
