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

namespace ProjectFinal.ViewModel.Order
{
    public class AddProductOrderDetailViewModel : BindableBase
    {
        #region VariableBinding
        private ObservableCollection<PRODUCT> _ProductList;
        public ObservableCollection<PRODUCT> ProductList { get => _ProductList; set { _ProductList = value; OnPropertyChanged(); } }


        private PRODUCT _ProductSelected;
        public PRODUCT ProductSelected { get => _ProductSelected; set { _ProductSelected = value; OnPropertyChanged(); } }

        private ORDER _OrderCurrent;
        public ORDER OrderCurrent { get => _OrderCurrent; set { _OrderCurrent = value; OnPropertyChanged(); } }
        private ORDER_DETAIL _OrderDetail;
        public ORDER_DETAIL OrderDetail { get => _OrderDetail; set { _OrderDetail = value; OnPropertyChanged(); } }

        private int _Quantity;
        public int Quantity { get => _Quantity; set { _Quantity = value; OnPropertyChanged(); } }

        #endregion

        #region Icommand
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } }

        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        #endregion
        public AddProductOrderDetailViewModel(ORDER order)
        {
            OrderCurrent = order;
            LoadProductList();
            OrderDetail = new ORDER_DETAIL();
        }
        public void LoadProductList()
        {
            ProductList = new ObservableCollection<PRODUCT>(DataProvider.Ins.DB.PRODUCTs.Include("MENU_PRODUCT"));
        }
        public void Save()
        {
            try
            {
                OrderDetail.id_order = OrderCurrent.id_order;
                OrderDetail.id_product = ProductSelected.id_product;
                OrderDetail.modified_date = DateTime.Now;
                OrderDetail.is_active = true;
                OrderDetail.quantity = Quantity;
                OrderDetail.unit_price = ProductSelected.price;

                OrderCurrent.total_product = OrderCurrent.total_product + Quantity;
                OrderCurrent.total_price = OrderCurrent.total_price + (ProductSelected.price * Quantity);
                DataProvider.Ins.DB.ORDER_DETAIL.Add(OrderDetail);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Lưu thành công!", "Thông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu không thành công!", "Thông báo");
            }
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
            (App.Current.MainWindow.DataContext as MainViewModel).OrderViewModel.LoadList();
        }
    }
}
