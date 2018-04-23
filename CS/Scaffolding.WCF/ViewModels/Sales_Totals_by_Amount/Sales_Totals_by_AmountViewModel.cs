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
    /// Represents the single Sales_Totals_by_Amount object view model.
    /// </summary>
    public partial class Sales_Totals_by_AmountViewModel : SingleObjectViewModel<Sales_Totals_by_Amount, Tuple<string, int>, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Sales_Totals_by_AmountViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Sales_Totals_by_AmountViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Sales_Totals_by_AmountViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Sales_Totals_by_AmountViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Sales_Totals_by_AmountViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Sales_Totals_by_AmountViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Sales_Totals_by_Amounts, x => x.CompanyName) {
        }
    }
}
