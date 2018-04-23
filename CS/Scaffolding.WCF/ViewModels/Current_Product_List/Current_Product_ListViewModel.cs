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
    /// Represents the single Current_Product_List object view model.
    /// </summary>
    public partial class Current_Product_ListViewModel : SingleObjectViewModel<Current_Product_List, Tuple<int, string>, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Current_Product_ListViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Current_Product_ListViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Current_Product_ListViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Current_Product_ListViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Current_Product_ListViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Current_Product_ListViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Current_Product_Lists, x => x.ProductName) {
        }
    }
}
