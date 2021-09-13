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

namespace ProjectFinal.ViewModel.Product
{
    public class ProductViewModel : BindableBase
    {
        #region VariableBinding
        private String _contentSearch;

        public String ContentSearch
        {
            get { return _contentSearch; }
            set { _contentSearch = value; OnPropertyChanged(); }
        }
        private ObservableCollection<PRODUCT> _ProductList;
        public ObservableCollection<PRODUCT> ProductList { get => _ProductList; set { _ProductList = value; OnPropertyChanged(); } }

        private PRODUCT _SelectedItem;
        public PRODUCT SelectedItem { get => _SelectedItem; set { _SelectedItem = value; OnPropertyChanged(); } }
        #endregion

        #region Command
        public ICommand AddNewProductCMD { get { return new CommandHelper(AddNewProduct); } }

        public ICommand EditProductCMD { get { return new CommandHelper<PRODUCT>((p) => p != null, ((p) => EditProduct(p))); } }
        public ICommand DeleteProductCMD { get { return new CommandHelper<PRODUCT>((p) => p != null, ((p) => ConfirmProduct(p))); } }

        public ICommand SearchProductCMD { get { return new CommandHelper(SearchProduct); } }

        //public ICommand AddNewCMD { get; set; }
        #endregion
        public ProductViewModel()
        {
            LoadDataProduct();
            //AddNewCMD = new RelayCommand<object>((p) => { return true; }, (p) =>
            //{
            //    ProductAddorUpdate pdAdd = new ProductAddorUpdate();
            //    pdAdd.ShowDialog(new ProductAddOrUpdateViewModel());
            //});

        }

        public void LoadDataProduct()
        {
            ProductList = new ObservableCollection<PRODUCT>(DataProvider.Ins.DB.PRODUCTs);
        }
        public void AddNewProduct() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ProductAddOrUpdateViewModel());
        public void EditProduct(PRODUCT product) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ProductAddOrUpdateViewModel(product));
        public void ConfirmProduct(PRODUCT product) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteProduct(product); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, product.name));

        public void SearchProduct()
        {
            var list = (from PRODUCTs in DataProvider.Ins.DB.PRODUCTs
                        where
                          PRODUCTs.name.Contains(ContentSearch)
                        select new
                        {
                            id_product = PRODUCTs.id_product,
                            created_date = PRODUCTs.created_date,
                            is_active = PRODUCTs.is_active,
                            modified_date = PRODUCTs.modified_date,
                            image_product = PRODUCTs.image_product,
                            name = PRODUCTs.name,
                            price = PRODUCTs.price,
                            size = PRODUCTs.size,
                            color = PRODUCTs.color,
                            id_promotion = PRODUCTs.id_promotion,
                            id_menu_product = PRODUCTs.id_menu_product
                        }).ToList();
            ProductList = new ObservableCollection<PRODUCT>();
            foreach (var item in list)
            {
                PRODUCT listDetail = new PRODUCT();
                listDetail.id_product = item.id_product;
                listDetail.created_date = item.created_date;
                listDetail.is_active = item.is_active;
                listDetail.modified_date = item.modified_date;
                listDetail.image_product = item.image_product;
                listDetail.name = item.name;
                listDetail.price = item.price;
                listDetail.size = item.size;
                listDetail.color = item.color;
                listDetail.id_promotion = item.id_promotion;
                listDetail.id_menu_product = item.id_menu_product;
                ProductList.Add(listDetail);
            }

        }


        public void DeleteProduct(PRODUCT product)
        {
            try
            {
                DataProvider.Ins.DB.PRODUCTs.Remove(product);
                DataProvider.Ins.DB.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Đang có đơn hàng chứa sản phẩm này!", "Thông báo");
            }

            LoadDataProduct();
        }
    }
}
