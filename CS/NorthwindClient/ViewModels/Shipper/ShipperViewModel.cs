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
    /// Represents the single Shipper object view model.
    /// </summary>
    public partial class ShipperViewModel : SingleObjectViewModel<Shipper, int, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ShipperViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ShipperViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ShipperViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ShipperViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ShipperViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ShipperViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Shippers, x => x.CompanyName) {
        }

        /// <summary>
        /// The view model for the ShipperOrders detail collection.
        /// </summary>
        public CollectionViewModel<Order, int, INorthwind2012EntitiesUnitOfWork> ShipperOrdersDetails {
            get { return GetDetailsCollectionViewModel((ShipperViewModel x) => x.ShipperOrdersDetails, x => x.Orders, x => x.ShipVia, (x, key) => x.ShipVia = key); }
        }
    }
}
