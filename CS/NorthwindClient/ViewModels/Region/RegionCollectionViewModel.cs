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
    /// Represents the Regions collection view model.
    /// </summary>
    public partial class RegionCollectionViewModel : CollectionViewModel<Region, int, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RegionCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RegionCollectionViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RegionCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RegionCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RegionCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RegionCollectionViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Regions) {
        }
    }
}