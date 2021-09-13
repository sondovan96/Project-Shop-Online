using ProjectFinal.Model;
using ProjectFinal.Service;
using ProjectFinal.View;
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
    public class OrderAddOrUpdateViewModel : BindableBase
    {
        #region Variable Binding
        private ORDER _OrderCurrent;
        public ORDER OrderCurrent { get => _OrderCurrent; set { _OrderCurrent = value; OnPropertyChanged(); } }

        private CUSTOMER _CustomerSelected;
        public CUSTOMER CustomerSelected { get => _CustomerSelected; set { _CustomerSelected = value; OnPropertyChanged(); } }

        private ObservableCollection<CUSTOMER> _CustomerList;
        public ObservableCollection<CUSTOMER> CustomerList { get => _CustomerList; set { _CustomerList = value; OnPropertyChanged(); } }

        private ORDER OrderBackup { get; set; }



        private String _header;
        public String Header
        {
            get { return _header; }
            set { _header = value; OnPropertyChanged(); }
        }
        #endregion


        #region Icommand
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } }
        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        #endregion

        public OrderAddOrUpdateViewModel(ORDER order = null)
        {
            CustomerList = new ObservableCollection<CUSTOMER>(DataProvider.Ins.DB.CUSTOMERS);
            if (order != null)
            {
                Header = "Chỉnh Sửa";
                OrderBackup = order;
                OrderCurrent = OrderBackup;

                CustomerSelected = CustomerList.FirstOrDefault((u) => u.id_customer == OrderCurrent.id_customer);

            }
            else
            {
                Header = "Thêm Mới";
                OrderCurrent = new ORDER();
            }
        }

        public void Save()
        {

            OrderCurrent.id_customer = CustomerSelected.id_customer;
            if (OrderBackup == null)
            {
                try
                {
                    OrderCurrent.is_active = true;

                    OrderCurrent.total_price = 0;
                    OrderCurrent.total_product = 0;
                    OrderCurrent.status_order = "PENDING";
                    OrderCurrent.created_date = DateTime.Now;
                    DataProvider.Ins.DB.ORDERS.Add(OrderCurrent);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Thêm mới đơn hàng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm mới đơn hàng thất bại!");
                }

            }
            else
            {
                try
                {
                    OrderCurrent.modified_date = DateTime.Now;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Chỉnh sửa đơn hàng thành công!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Chỉnh sửa đơn hàng không thành công! ", "Thông báo!");
                }

            }

            (App.Current.MainWindow.DataContext as MainViewModel).OrderViewModel.LoadList();
            App.Current.MainWindow.DataContext = new MainViewModel();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
    }
}
