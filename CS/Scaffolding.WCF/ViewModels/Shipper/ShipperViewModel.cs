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
    /// Represents the single Shipper object view model.
    /// </summary>
    public partial class ShipperViewModel : SingleObjectViewModel<Shipper, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ShipperViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ShipperViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ShipperViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ShipperViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ShipperViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ShipperViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Shippers, x => x.CompanyName) {
        }

        /// <summary>
        /// The view model for the ShipperOrders detail collection.
        /// </summary>
        public CollectionViewModel<Order, int, INorthwindEntitiesUnitOfWork> ShipperOrdersDetails {
            get { return GetDetailsCollectionViewModel((ShipperViewModel x) => x.ShipperOrdersDetails, x => x.Orders, x => x.ShipVia, (x, key) => { x.ShipVia = key; }); }
        }
    }
}
