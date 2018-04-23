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
    /// Represents the Category_Sales_for_1997 collection view model.
    /// </summary>
    public partial class Category_Sales_for_1997CollectionViewModel : CollectionViewModel<Category_Sales_for_1997, string, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Category_Sales_for_1997CollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Category_Sales_for_1997CollectionViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Category_Sales_for_1997CollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Category_Sales_for_1997CollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Category_Sales_for_1997CollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Category_Sales_for_1997CollectionViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Category_Sales_for_1997) {
        }
    }
}