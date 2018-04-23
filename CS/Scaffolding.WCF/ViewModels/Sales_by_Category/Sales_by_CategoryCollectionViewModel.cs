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
    /// Represents the Sales_by_Categories collection view model.
    /// </summary>
    public partial class Sales_by_CategoryCollectionViewModel : CollectionViewModel<Sales_by_Category, Tuple<int, string, string>, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Sales_by_CategoryCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Sales_by_CategoryCollectionViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Sales_by_CategoryCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Sales_by_CategoryCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Sales_by_CategoryCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Sales_by_CategoryCollectionViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Sales_by_Categories) {
        }
    }
}