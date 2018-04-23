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
    /// Represents the single Orders_Qry object view model.
    /// </summary>
    public partial class Orders_QryViewModel : SingleObjectViewModel<Orders_Qry, Tuple<string, int>, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Orders_QryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Orders_QryViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Orders_QryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Orders_QryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Orders_QryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Orders_QryViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Orders_Qries, x => x.ShipName) {
        }
    }
}
