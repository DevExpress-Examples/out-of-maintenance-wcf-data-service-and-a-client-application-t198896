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
    /// Represents the single Order_Subtotal object view model.
    /// </summary>
    public partial class Order_SubtotalViewModel : SingleObjectViewModel<Order_Subtotal, int, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Order_SubtotalViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Order_SubtotalViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Order_SubtotalViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Order_SubtotalViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Order_SubtotalViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Order_SubtotalViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Order_Subtotals, x => x.OrderID) {
        }
    }
}
