using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using Scaffolding.WCF.Common.Utils;
using Scaffolding.WCF.NorthwindEntitiesDataModel;
using Scaffolding.WCF.Common.DataModel;
using Scaffolding.WCF.NorthwindEntities;
using Scaffolding.WCF.Common.ViewModel;

namespace Scaffolding.WCF.ViewModels {
    /// <summary>
    /// Represents the Sales_Totals_by_Amounts collection view model.
    /// </summary>
    public partial class Sales_Totals_by_AmountCollectionViewModel : CollectionViewModel<Sales_Totals_by_Amount, Tuple<string, int>, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Sales_Totals_by_AmountCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Sales_Totals_by_AmountCollectionViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Sales_Totals_by_AmountCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Sales_Totals_by_AmountCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Sales_Totals_by_AmountCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Sales_Totals_by_AmountCollectionViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Sales_Totals_by_Amounts) {
        }
    }
}