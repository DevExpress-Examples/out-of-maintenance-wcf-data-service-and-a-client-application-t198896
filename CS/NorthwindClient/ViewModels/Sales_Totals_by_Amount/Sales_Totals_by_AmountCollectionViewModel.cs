using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using NorthwindClient.Common.Utils;
using NorthwindClient.Northwind2012EntitiesDataModel;
using NorthwindClient.Common.DataModel;
using NorthwindClient.ServiceReference1;
using NorthwindClient.Common.ViewModel;

namespace NorthwindClient.ViewModels {
    /// <summary>
    /// Represents the Sales_Totals_by_Amounts collection view model.
    /// </summary>
    public partial class Sales_Totals_by_AmountCollectionViewModel : ReadOnlyCollectionViewModel<Sales_Totals_by_Amount, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Sales_Totals_by_AmountCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Sales_Totals_by_AmountCollectionViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Sales_Totals_by_AmountCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Sales_Totals_by_AmountCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Sales_Totals_by_AmountCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Sales_Totals_by_AmountCollectionViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Sales_Totals_by_Amounts) {
        }
    }
}