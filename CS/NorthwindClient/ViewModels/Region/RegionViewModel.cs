using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using NorthwindClient.Common.Utils;
using NorthwindClient.Northwind2012EntitiesDataModel;
using NorthwindClient.Common.DataModel;
using NorthwindClient.ServiceReference1;
using NorthwindClient.Common.ViewModel;

namespace NorthwindClient.ViewModels {
    /// <summary>
    /// Represents the single Region object view model.
    /// </summary>
    public partial class RegionViewModel : SingleObjectViewModel<Region, int, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of RegionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static RegionViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new RegionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the RegionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the RegionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected RegionViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Regions, x => x.RegionDescription) {
        }

        /// <summary>
        /// The view model for the RegionTerritories detail collection.
        /// </summary>
        public CollectionViewModel<Territory, string, INorthwind2012EntitiesUnitOfWork> RegionTerritoriesDetails {
            get { return GetDetailsCollectionViewModel((RegionViewModel x) => x.RegionTerritoriesDetails, x => x.Territories, x => x.RegionID, (x, key) => x.RegionID = key); }
        }
    }
}
