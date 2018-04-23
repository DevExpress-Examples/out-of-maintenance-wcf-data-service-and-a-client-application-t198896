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
    /// Represents the Product_Sales_for_1997 collection view model.
    /// </summary>
    public partial class Product_Sales_for_1997CollectionViewModel : CollectionViewModel<Product_Sales_for_1997, Tuple<string, string>, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Product_Sales_for_1997CollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Product_Sales_for_1997CollectionViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Product_Sales_for_1997CollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Product_Sales_for_1997CollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Product_Sales_for_1997CollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Product_Sales_for_1997CollectionViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Product_Sales_for_1997) {
        }
    }
}