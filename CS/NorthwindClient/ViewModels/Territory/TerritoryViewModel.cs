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
    /// Represents the single Territory object view model.
    /// </summary>
    public partial class TerritoryViewModel : SingleObjectViewModel<Territory, string, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TerritoryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TerritoryViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TerritoryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TerritoryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TerritoryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TerritoryViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Territories, x => x.TerritoryDescription) {
        }

        /// <summary>
        /// The look-up collection of Regions for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Region> LookUpRegions {
            get { return GetLookUpEntitiesViewModel((TerritoryViewModel x) => x.LookUpRegions, x => x.Regions); }
        }
    }
}
