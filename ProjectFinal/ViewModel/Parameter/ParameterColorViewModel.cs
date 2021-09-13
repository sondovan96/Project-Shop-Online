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
    public class ParameterColorViewModel : BindableBase
    {
        #region Variable Binding
        private Color _ColorCurrent;
        public Color ColorCurrent { get => _ColorCurrent; set { _ColorCurrent = value; OnPropertyChanged(); } }

        private Color ColorBackup { get; set; }

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
        public ParameterColorViewModel(Color color = null)
        {
            if (color != null)
            {

                Header = "Chỉnh Sửa";
                ColorBackup = color;
                ColorCurrent = ColorBackup;
            }
            else
            {
                Header = "Thêm Mới";
                ColorCurrent = new Color();
            }
        }

        public void Save()
        {

            if (ColorBackup == null)
            {
                try
                {
                    DataProvider.Ins.DB.Colors.Add(ColorCurrent);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Thêm mới Color thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm mới Color thất bại!");
                }

            }
            else
            {
                try
                {
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Chỉnh sửa Color thành công!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể chỉnh sửa ", "Thông báo!");
                }

            }

            (App.Current.MainWindow.DataContext as MainViewModel).ParameterViewModel.LoadDataColor();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
    }
}
