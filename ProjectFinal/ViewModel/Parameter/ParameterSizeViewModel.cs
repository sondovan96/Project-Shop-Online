using ProjectFinal.Model;
using ProjectFinal.Service;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ProjectFinal.ViewModel.Parameter
{
    public class ParameterSizeViewModel : BindableBase
    {
        #region Variable Binding
        private Size _SizeCurrent;
        public Size SizeCurrent { get => _SizeCurrent; set { _SizeCurrent = value; OnPropertyChanged(); } }

        private Size SizeBackup { get; set; }

        private String _header;
        public String Header
        {
            get { return _header; }
            set { _header = value; OnPropertyChanged(); }
        }


        #endregion

        #region Command
        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } set { OnPropertyChanged(); } }
        #endregion
        public ParameterSizeViewModel(Size size = null)
        {
            if (size != null)
            {

                Header = "Chỉnh Sửa";
                SizeBackup = size;
                SizeCurrent = SizeBackup;
            }
            else
            {
                Header = "Thêm Mới";
                SizeCurrent = new Size();
            }
        }

        public void Save()
        {

            if (SizeBackup == null)
            {
                try
                {
                    DataProvider.Ins.DB.Sizes.Add(SizeCurrent);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Thêm mới Size thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm mới Size thất bại!");
                }

            }
            else
            {
                try
                {
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Chỉnh sửa Size thành công!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể chỉnh sửa ", "Thông báo!");
                }

            }

            (App.Current.MainWindow.DataContext as MainViewModel).ParameterViewModel.LoadDataSize();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
    }
}
