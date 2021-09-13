
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
using System.Windows.Forms;
using System.Windows.Input;

namespace ProjectFinal.ViewModel.Account
{
    public class AccountAddorUpdateViewModel : BindableBase
    {
        #region Variable Binding
        private USER _UserCurrent;
        public USER UserCurrent { get => _UserCurrent; set { _UserCurrent = value; OnPropertyChanged(); } }

        private ObservableCollection<APP_ROLE> _RoleList;
        public ObservableCollection<APP_ROLE> RoleList { get => _RoleList; set { _RoleList = value; OnPropertyChanged(); } }

        private APP_ROLE _RoleSelected;
        public APP_ROLE RoleSelected { get => _RoleSelected; set { _RoleSelected = value; OnPropertyChanged(); } }

        private USER UserBackup { get; set; }

        private String _header;
        public String Header
        {
            get { return _header; }
            set { _header = value; OnPropertyChanged(); }
        }


        #endregion

        #region Command
        public ICommand OpenDialogChooseImageCMD { get { return new CommandHelper(OpenDialogChooseImage); } }
        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } set { OnPropertyChanged(); } }
        #endregion
        public AccountAddorUpdateViewModel(USER user = null)
        {
            RoleList = new ObservableCollection<APP_ROLE>(DataProvider.Ins.DB.APP_ROLE);

            if (user != null)
            {

                Header = "Chỉnh Sửa";
                UserBackup = user;
                UserCurrent = UserBackup;
                RoleSelected = RoleList.FirstOrDefault((u) => u.id_role == UserCurrent.id_role);
            }
            else
            {
                Header = "Thêm Mới";
                UserCurrent = new USER();
            }
        }

        public void Save()
        {
            string mk = "1";
            UserCurrent.id_role = RoleSelected.id_role;
            if (UserBackup == null)
            {
                try
                {
                    UserCurrent.is_active = true;

                    UserCurrent.password = MD5Provider.MD5Encrypt(mk);
                    UserCurrent.created_date = DateTime.Now;
                    DataProvider.Ins.DB.USERS.Add(UserCurrent);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Thêm mới Account mật khẩu mặc định là 1 thành công!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm mới Account thất bại!");
                }

            }
            else
            {
                try
                {
                    UserCurrent.modified_date = DateTime.Now;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Chỉnh sửa Account thành công!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể chỉnh sửa ", "Thông báo!");


                }

            }

            (App.Current.MainWindow.DataContext as MainViewModel).AccountViewModel.LoadDataAccount();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
        public void OpenDialogChooseImage()
        {
            OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "Image files (*.jpg, *.png) | *.jpg; *.png" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                UserCurrent.image_user = fileDialog.FileName;
        }

    }
}
