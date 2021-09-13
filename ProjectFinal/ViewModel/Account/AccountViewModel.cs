using ProjectFinal.Model;
using ProjectFinal.Service;
using ProjectFinal.Service.MD5Provider.Source;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProjectFinal.ViewModel.Account
{
    public class AccountViewModel : BindableBase
    {
        #region Variable Binding
        private ObservableCollection<USER> _UserList;
        public ObservableCollection<USER> UserList { get => _UserList; set { _UserList = value; OnPropertyChanged(); } }

        private USER _SelectedItem;
        public USER SelectedItem { get => _SelectedItem; set { _SelectedItem = value; OnPropertyChanged(); } }
        #endregion

        #region Command
        public ICommand AddNewAccountCMD { get { return new CommandHelper(AddNewAccount); } }

        public ICommand EditAccountCMD { get { return new CommandHelper<USER>((p) => p != null, ((p) => EditAccount(p))); } }
        public ICommand DeleteAccountCMD { get { return new CommandHelper<USER>((p) => p != null, ((p) => ConfirmAccount(p))); } }

        public ICommand ResetPassCMD { get { return new CommandHelper<USER>((p) => p != null, ((p) => ResetPass(p))); } }



        #endregion
        public AccountViewModel()
        {
            LoadDataAccount();

        }

        public void LoadDataAccount()
        {
            UserList = new ObservableCollection<USER>(DataProvider.Ins.DB.USERS.Include("APP_ROLE"));
        }
        public void AddNewAccount() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new AccountAddorUpdateViewModel());
        public void EditAccount(USER user) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new AccountAddorUpdateViewModel(user));
        public void ConfirmAccount(USER user) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteProduct(user); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, user.name));

        public void DeleteProduct(USER user)
        {
            try
            {
                DataProvider.Ins.DB.USERS.Remove(user);
                DataProvider.Ins.DB.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Đang có đơn hàng chứa sản phẩm này!", "Thông báo");
            }

            LoadDataAccount();
        }
        public void ResetPass(USER user)
        {

            if (MessageBox.Show("Reset Password account" + user.user_name + "về 1?", "Thông báo!", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
            {
                string mk = "1";
                user.password = MD5Provider.MD5Encrypt(mk);
                DataProvider.Ins.DB.SaveChanges();
            }
        }
    }
}
