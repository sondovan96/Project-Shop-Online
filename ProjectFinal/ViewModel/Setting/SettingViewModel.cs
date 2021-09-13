using ProjectFinal.Utility;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectFinal.ViewModel.Setting
{
    public class SettingViewModel:BindableBase
    {
        public ICommand SettingVNCMD { get { return new CommandHelper(SettingVN); } }
        public ICommand SettingENCMD { get { return new CommandHelper(SettingEN); } }
        public SettingViewModel()
        {

        }
        public void SettingVN()
        {
            GlobalVariable.StringResource = false;
            App.Current.MainWindow.DataContext = new MainViewModel();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
        public void SettingEN()
        {
            GlobalVariable.StringResource = true;
            App.Current.MainWindow.DataContext = new MainViewModel();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
    }
}
