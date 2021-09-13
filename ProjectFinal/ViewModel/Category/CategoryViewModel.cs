using ProjectFinal.Model;
using ProjectFinal.Service;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ProjectFinal.ViewModel.Category
{
    public class CategoryViewModel : BindableBase
    {
        #region Variable Binding
        private ObservableCollection<MENU_PRODUCT> _CategoryList;
        public ObservableCollection<MENU_PRODUCT> CategoryList { get => _CategoryList; set { _CategoryList = value; OnPropertyChanged(); } }

        private MENU_PRODUCT _SelectedItem;
        public MENU_PRODUCT SelectedItem { get => _SelectedItem; set { _SelectedItem = value; OnPropertyChanged(); } }
        #endregion

        #region Command
        public ICommand AddNewCategoryCMD { get { return new CommandHelper(AddNewCustomer); } }

        public ICommand EditCategoryCMD { get { return new CommandHelper<MENU_PRODUCT>((p) => p != null, ((p) => EditCategory(p))); } }
        public ICommand DeleteCategoryCMD { get { return new CommandHelper<MENU_PRODUCT>((p) => p != null, ((p) => ConfirmCategory(p))); } }

        //public ICommand AddNewCMD { get; set; }
        #endregion
        public CategoryViewModel()
        {
            LoadDataCategory();

        }

        public void LoadDataCategory()
        {
            CategoryList = new ObservableCollection<MENU_PRODUCT>(DataProvider.Ins.DB.MENU_PRODUCT);
        }
        public void AddNewCustomer() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new CategoryAddorUpdateViewModel());
        public void EditCategory(MENU_PRODUCT category) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new CategoryAddorUpdateViewModel(category));
        public void ConfirmCategory(MENU_PRODUCT category) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteProduct(category); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, category.type_product));

        public void DeleteProduct(MENU_PRODUCT category)
        {
            try
            {
                DataProvider.Ins.DB.MENU_PRODUCT.Remove(category);
                DataProvider.Ins.DB.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Đang có đơn hàng chứa sản phẩm này!", "Thông báo");
            }

            LoadDataCategory();
        }
    }
}
