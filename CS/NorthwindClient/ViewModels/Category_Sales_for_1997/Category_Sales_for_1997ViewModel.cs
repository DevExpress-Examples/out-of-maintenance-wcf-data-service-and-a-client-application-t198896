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
    /// Represents the single Category_Sales_for_1997 object view model.
    /// </summary>
    public partial class Category_Sales_for_1997ViewModel : SingleObjectViewModel<Category_Sales_for_1997, string, INorthwind2012EntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of Category_Sales_for_1997ViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static Category_Sales_for_1997ViewModel Create(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new Category_Sales_for_1997ViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the Category_Sales_for_1997ViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the Category_Sales_for_1997ViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected Category_Sales_for_1997ViewModel(IUnitOfWorkFactory<INorthwind2012EntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Category_Sales_for_1997, x => x.CategoryName) {
        }
    }
}
