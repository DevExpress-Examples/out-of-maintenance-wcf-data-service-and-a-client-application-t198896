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
    /// Represents the Products_Above_Average_Prices collection view model.
    /// </summary>
    public partial class Products_Above_Average_PriceCollectionViewModel : CollectionViewModel<Products_Above_Average_Price, string, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Products_Above_Average_PriceCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Products_Above_Average_PriceCollectionViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Products_Above_Average_PriceCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Products_Above_Average_PriceCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Products_Above_Average_PriceCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Products_Above_Average_PriceCollectionViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Products_Above_Average_Prices) {
        }
    }
}