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
    /// Represents the single Product_Sales_for_1997 object view model.
    /// </summary>
    public partial class Product_Sales_for_1997ViewModel : SingleObjectViewModel<Product_Sales_for_1997, Tuple<string, string>, INorthwindEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Product_Sales_for_1997ViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Product_Sales_for_1997ViewModel Create(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Product_Sales_for_1997ViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Product_Sales_for_1997ViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Product_Sales_for_1997ViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Product_Sales_for_1997ViewModel(IUnitOfWorkFactory<INorthwindEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Product_Sales_for_1997, x => x.CategoryName) {
        }
    }
}
