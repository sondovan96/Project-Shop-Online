using ProjectFinal.Internationalization;
using ProjectFinal.Model;
using ProjectFinal.Service;
using ProjectFinal.Service.MD5Provider.Source;
using ProjectFinal.Service.Repository;
using ProjectFinal.Utility;
using ProjectFinal.View;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjectFinal.ViewModel
{
    public class LoginViewModel : BindableBase
    {
        #region [Props]
        private USER _currentAccount = new USER();
        private WindowState _windowState = WindowState.Normal;




        public WindowState WindowState
        {
            get { return _windowState; }
            set { _windowState = value; OnPropertyChanged(); }
        }
        public USER CurrentAccount
        {
            get { return _currentAccount; }
            set { _currentAccount = value; OnPropertyChanged(); }
        }
        private USER _usernow;
        public USER usernow
        {
            get { return _usernow; }
            set { _usernow = value; OnPropertyChanged(); }
        }

        #endregion
        #region [Commands]
        public ICommand PasswordChangedCommand { get { return new CommandHelper<PasswordBox>((p) => { return true; }, (p) => { CurrentAccount.password = p.Password; }); } }
        public ICommand LoginCMD { get { return new CommandHelper(Login); } }
        public ICommand CloseCMD { get { return new CommandHelper(CloseWindow); } }
        public ICommand MinimizedWindowCMD { get { return new CommandHelper(MinimizedWindow); } }
        public ICommand CloseWindowCMD { get { return new CommandHelper(CloseWindow); } }
        public ICommand DragMoveCMD { get { return new CommandHelper<Window>((w) => w != null, ((p) => { try { p.DragMove(); } catch { } })); } }
        #endregion

        public LoginViewModel() => StringResources.ApplyLanguage(Enum.ALL_ENUM.Language.EN);
        public void Login()
        {

            UserRepository check = new UserRepository();
            string password = MD5Provider.MD5Encrypt(CurrentAccount.password);
            if (check.checkUser(CurrentAccount.user_name, password))
            {
                usernow = DataProvider.Ins.DB.USERS.Where(x => x.user_name == CurrentAccount.user_name && x.password == password).FirstOrDefault();
                GlobalVariable.userSave = usernow;
                App.Current.MainWindow = new MainWindow();
                App.Current.MainWindow.DataContext = new MainViewModel();
                App.Current.MainWindow.Show();

                foreach (var item in App.Current.Windows)
                {
                    if (item.GetType() == typeof(LoginWindow))
                        (item as Window).Hide();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo!");
            }
        }
        public void MinimizedWindow() => WindowState = WindowState.Minimized;
        public void CloseWindow() => Environment.Exit(0);
    }
}
