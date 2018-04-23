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
    /// Represents the single Order object view model.
    /// </summary>
    public partial class OrderViewModel : SingleObjectViewModel<Order, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Orders, x => x.ShipName) {
        }


        /// <summary>
		/// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomers {
            get { return GetLookUpEntitiesViewModel((OrderViewModel x) => x.LookUpCustomers, x => x.Customers); }
        }


        /// <summary>
		/// The view model that contains a look-up collection of Employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Employee> LookUpEmployees {
            get { return GetLookUpEntitiesViewModel((OrderViewModel x) => x.LookUpEmployees, x => x.Employees); }
        }


        /// <summary>
		/// The view model that contains a look-up collection of Shippers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Shipper> LookUpShippers {
            get { return GetLookUpEntitiesViewModel((OrderViewModel x) => x.LookUpShippers, x => x.Shippers); }
        }

        /// <summary>
        /// The view model for the OrderOrder_Details detail collection.
        /// </summary>
        public CollectionViewModel<Order_Detail, Tuple<int, int>, INorthwindEntitiesUnitOfWork> OrderOrder_DetailsDetails {
            get { return GetDetailsCollectionViewModel((OrderViewModel x) => x.OrderOrder_DetailsDetails, x => x.Order_Details, x => x.OrderID, (x, key) => { x.OrderID = key; }); }
        }
    }
}
