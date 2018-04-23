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
    /// Represents the single Products_by_Category object view model.
    /// </summary>
    public partial class Products_by_CategoryViewModel : SingleObjectViewModel<Products_by_Category, Tuple<string, bool, string>, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Products_by_CategoryViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Products_by_CategoryViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Products_by_CategoryViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Products_by_CategoryViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Products_by_CategoryViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Products_by_CategoryViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Products_by_Categories, x => x.CategoryName) {
        }
    }
}
