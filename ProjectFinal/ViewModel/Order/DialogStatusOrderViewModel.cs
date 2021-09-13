using ProjectFinal.Model;
using ProjectFinal.Service;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProjectFinal.ViewModel.Order
{
    public class DialogStatusOrderViewModel : BindableBase
    {

        #region Variable binding
        private ORDER _OrderCurrent;
        public ORDER OrderCurrent { get => _OrderCurrent; set { _OrderCurrent = value; OnPropertyChanged(); } }

        private ObservableCollection<STATUS_ORDER> _Status_Order;
        public ObservableCollection<STATUS_ORDER> Status_Order { get => _Status_Order; set { _Status_Order = value; OnPropertyChanged(); } }


        private STATUS_ORDER _Status_OrderSelected;
        public STATUS_ORDER Status_OrderSelected { get => _Status_OrderSelected; set { _Status_OrderSelected = value; OnPropertyChanged(); } }


        #endregion
        #region Command
        public ICommand CancelStatusCommand { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } }
        public ICommand ChangeStatusCMD { get { return new CommandHelper(ChangeStatus); } }

        #endregion
        public DialogStatusOrderViewModel(ORDER order)
        {
            Status_Order = new ObservableCollection<STATUS_ORDER>(DataProvider.Ins.DB.STATUS_ORDER);
            OrderCurrent = order;
            Status_OrderSelected = Status_Order.FirstOrDefault((u) => u.name_status == OrderCurrent.status_order);
        }

        public void ChangeStatus()
        {
            OrderCurrent.status_order = Status_OrderSelected.name_status;
            if (Status_OrderSelected.name_status == "CANCELED")
            {
                try
                {
                    if (MessageBox.Show("Bạn muốn huỷ đơn hàng?", "Thông báo!", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
                    {
                        OrderCurrent.is_active = false;
                        OrderCurrent.modified_date = DateTime.Now;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Chuyển trạng thái đơn hàng không thành công!", "Thông báo!");
                }
            }
            else
            {
                try
                {
                    OrderCurrent.modified_date = DateTime.Now;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Chuyển trạng thái đơn hàng thành công!", "Thông báo!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Chuyển trạng thái đơn hàng không thành công!", "Thông báo!");
                }
            }

            (App.Current.MainWindow.DataContext as MainViewModel).OrderViewModel.LoadList();
            App.Current.MainWindow.DataContext = new MainViewModel();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
    }
}
