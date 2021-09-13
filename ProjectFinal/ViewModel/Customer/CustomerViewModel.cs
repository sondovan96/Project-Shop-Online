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

namespace ProjectFinal.ViewModel.Customer
{
    public class CustomerViewModel : BindableBase
    {
        #region VariableBinding
        private ObservableCollection<CUSTOMER> _CustomerList;
        public ObservableCollection<CUSTOMER> CustomerList { get => _CustomerList; set { _CustomerList = value; OnPropertyChanged(); } }

        private CUSTOMER _SelectedItem;
        public CUSTOMER SelectedItem { get => _SelectedItem; set { _SelectedItem = value; OnPropertyChanged(); } }
        #endregion

        #region Command
        public ICommand AddNewCustomerCMD { get { return new CommandHelper(AddNewCustomer); } }

        public ICommand EditCustomerCMD { get { return new CommandHelper<CUSTOMER>((p) => p != null, ((p) => EditCustomer(p))); } }
        public ICommand DeleteCustomerCMD { get { return new CommandHelper<CUSTOMER>((p) => p != null, ((p) => ConfirmCustomer(p))); } }

        //public ICommand AddNewCMD { get; set; }
        #endregion
        public CustomerViewModel()
        {
            LoadDataCustomer();

        }

        public void LoadDataCustomer()
        {
            CustomerList = new ObservableCollection<CUSTOMER>(DataProvider.Ins.DB.CUSTOMERS);
        }
        public void AddNewCustomer() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new CustomerAddorUpdateViewModel());
        public void EditCustomer(CUSTOMER customer) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new CustomerAddorUpdateViewModel(customer));
        public void ConfirmCustomer(CUSTOMER customer) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteProduct(customer); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, customer.name));

        public void DeleteProduct(CUSTOMER customer)
        {
            try
            {
                DataProvider.Ins.DB.CUSTOMERS.Remove(customer);
                DataProvider.Ins.DB.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Đang có đơn hàng chứa sản phẩm này!", "Thông báo");
            }

            LoadDataCustomer();
        }
    }
}
