using ProjectFinal.Model;
using ProjectFinal.Service;
using ProjectFinal.Service.MD5Provider.Source;
using ProjectFinal.Utility;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace ProjectFinal.ViewModel.Account
{
    public class ChangePasswordViewModel : BindableBase
    {

        private Passwordtemp _Passtemp;
        public Passwordtemp Passtemp { get => _Passtemp; set { _Passtemp = value; OnPropertyChanged(); } }


        private USER _UserCurrent;
        public USER UserCurrent { get => _UserCurrent; set { _UserCurrent = value; OnPropertyChanged(); } }

        #region Icommand
        public ICommand OpenDialogChooseImageCMD { get { return new CommandHelper(OpenDialogChooseImage); } }
        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } set { OnPropertyChanged(); } }
        public ICommand PasswordOldCommand { get { return new CommandHelper<PasswordBox>((p) => { return true; }, (p) => { Passtemp.old_pass = p.Password; }); } }
        public ICommand PasswordNewCommand { get { return new CommandHelper<PasswordBox>((p) => { return true; }, (p) => { Passtemp.new_pass = p.Password; }); } }
        public ICommand PasswordReCommand { get { return new CommandHelper<PasswordBox>((p) => { return true; }, (p) => { Passtemp.re_pass = p.Password; }); } }
        #endregion

        public ChangePasswordViewModel()
        {
            UserCurrent = GlobalVariable.userSave;
            Passtemp = new Passwordtemp();
        }

        public void Save()
        {
            bool flag = false;
            if (Passtemp.old_pass != null && Passtemp.new_pass != null && Passtemp.re_pass != null)
            {
                string oldpass = MD5Provider.MD5Encrypt(Passtemp.old_pass);
                string newpass = Passtemp.new_pass;
                string repass = Passtemp.re_pass;
                if (oldpass != UserCurrent.password)
                {
                    MessageBox.Show("Mật khẩu cũ k đúng!");
                }
                else if (newpass != repass)
                {
                    MessageBox.Show("Nhập lại mật khẩu không đúng!");
                }
                else
                {
                    UserCurrent.modified_date = DateTime.Now;
                    UserCurrent.password = MD5Provider.MD5Encrypt(repass);
                    DataProvider.Ins.DB.SaveChanges();
                    flag = true;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!");
            }
            if(flag)
            {
                (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
                App.Current.MainWindow.DataContext = new MainViewModel();
            }
           
        }
        public void OpenDialogChooseImage()
        {
            OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "Image files (*.jpg, *.png) | *.jpg; *.png" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                UserCurrent.image_user = fileDialog.FileName;
        }

    }
}
