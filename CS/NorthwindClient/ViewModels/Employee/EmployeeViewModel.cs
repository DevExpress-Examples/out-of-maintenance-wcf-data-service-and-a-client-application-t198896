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
    /// Represents the single Employee object view model.
    /// </summary>
    public partial class EmployeeViewModel : SingleObjectViewModel<Employee, int, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EmployeeViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EmployeeViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EmployeeViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EmployeeViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EmployeeViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EmployeeViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Employees, x => x.LastName) {
        }

        /// <summary>
        /// The look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get { return GetLookUpEntitiesViewModel((EmployeeViewModel x) => x.LookUpEmployees, x => x.Employees); }
        }

        /// <summary>
        /// The view model for the EmployeeEmployees1 detail collection.
        /// </summary>
        public CollectionViewModel<Employee, int, INorthwind2012EntitiesUnitOfWork> EmployeeEmployees1Details {
            get { return GetDetailsCollectionViewModel((EmployeeViewModel x) => x.EmployeeEmployees1Details, x => x.Employees, x => x.ReportsTo, (x, key) => x.ReportsTo = key); }
        }

        /// <summary>
        /// The view model for the EmployeeOrders detail collection.
        /// </summary>
        public CollectionViewModel<Order, int, INorthwind2012EntitiesUnitOfWork> EmployeeOrdersDetails {
            get { return GetDetailsCollectionViewModel((EmployeeViewModel x) => x.EmployeeOrdersDetails, x => x.Orders, x => x.EmployeeID, (x, key) => x.EmployeeID = key); }
        }
    }
}
