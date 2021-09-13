using ProjectFinal.Model;
using ProjectFinal.Service;
using ProjectFinal.ViewModel.Base;
using ProjectFinal.ViewModel.Statistic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectFinal.ViewModel.Order
{
    public class OrderViewModel : BindableBase
    {
        #region VariableBinding
        private ObservableCollection<ORDER> _OrderList;
        public ObservableCollection<ORDER> OrderList { get => _OrderList; set { _OrderList = value; OnPropertyChanged(); } }

        private ORDER _OrderSelected;
        public ORDER OrderSelected { get => _OrderSelected; set { _OrderSelected = value; OnPropertyChanged(); } }

        public ICommand AddNewOrderCMD { get { return new CommandHelper(AddNewOrder); } }
        public ICommand EditStatusOrderCMD { get { return new CommandHelper<ORDER>((p) => p != null, ((p) => EditStatusOrder(p))); } }
        public ICommand EditOrderCMD { get { return new CommandHelper<ORDER>((p) => p != null, ((p) => EditOrder(p))); } }

        public ICommand CheckOrderDetailCMD { get { return new CommandHelper<ORDER>((p) => p != null, ((p) => CheckOrderDetail(p))); } }

        public ICommand AddProductOrderDetailCMD { get { return new CommandHelper<ORDER>((p) => p != null, ((p) => AddProductOrderDetail(p))); } }
        public ICommand PrintBillCMD { get { return new CommandHelper<ORDER>((p) => p != null, ((p) => PrintBill(p))); } }

       
        #endregion
        public OrderViewModel()
        {
            LoadList();
        }
        public void LoadList()
        {
            OrderList = new ObservableCollection<ORDER>(DataProvider.Ins.DB.ORDERS.Include("CUSTOMER").Where(x => x.is_active == true));
        }

        public void AddNewOrder() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new OrderAddOrUpdateViewModel());
        public void EditStatusOrder(ORDER p) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new DialogStatusOrderViewModel(p));
        public void EditOrder(ORDER p) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new OrderAddOrUpdateViewModel(p));
        public void CheckOrderDetail(ORDER p) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new OrderDetailViewModel(p));

        public void AddProductOrderDetail(ORDER p) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new AddProductOrderDetailViewModel(p));

        public void PrintBill(ORDER p)
        {
            (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new StatisticViewModel(p));
        }
    }
}
