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

namespace ProjectFinal.ViewModel.Parameter
{
    public class ParameterViewModel : BindableBase
    {
        #region Variable Binding
        private ObservableCollection<Size> _SizeList;
        public ObservableCollection<Size> SizeList { get => _SizeList; set { _SizeList = value; OnPropertyChanged(); } }

        private Size _SelectedItem;
        public Size SelectedItem { get => _SelectedItem; set { _SelectedItem = value; OnPropertyChanged(); } }

        private ObservableCollection<Color> _ColorList;
        public ObservableCollection<Color> ColorList { get => _ColorList; set { _ColorList = value; OnPropertyChanged(); } }

        private Color _ColorSelected;
        public Color ColorSelected { get => _ColorSelected; set { _ColorSelected = value; OnPropertyChanged(); } }

        #endregion

        #region Command
        public ICommand AddNewParaSizeCMD { get { return new CommandHelper(AddNewParaSize); } }

        public ICommand EditParaSizeCMD { get { return new CommandHelper<Size>((p) => p != null, ((p) => EditParaSize(p))); } }
        public ICommand DeleteParaSizeCMD { get { return new CommandHelper<Size>((p) => p != null, ((p) => ConfirmParaSize(p))); } }

        public ICommand AddNewParaColorCMD { get { return new CommandHelper(AddNewParaColor); } }

        public ICommand EditParaColorCMD { get { return new CommandHelper<Color>((p) => p != null, ((p) => EditParaColor(p))); } }
        public ICommand DeleteParaColorCMD { get { return new CommandHelper<Color>((p) => p != null, ((p) => ConfirmParaColor(p))); } }

        #endregion
        public ParameterViewModel()
        {
            LoadDataSize();
            LoadDataColor();
        }

        public void LoadDataSize()
        {
            SizeList = new ObservableCollection<Size>(DataProvider.Ins.DB.Sizes);
        }
        public void LoadDataColor()
        {
            ColorList = new ObservableCollection<Color>(DataProvider.Ins.DB.Colors);
        }
        public void AddNewParaSize() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ParameterSizeViewModel());
        public void EditParaSize(Size size) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ParameterSizeViewModel(size));
        public void ConfirmParaSize(Size size) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteSize(size); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, size.name_size));

        public void AddNewParaColor() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ParameterColorViewModel());
        public void EditParaColor(Color color) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ParameterColorViewModel(color));
        public void ConfirmParaColor(Color color) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteColor(color); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, color.name_color));
        public void DeleteSize(Size size)
        {
            try
            {
                DataProvider.Ins.DB.Sizes.Remove(size);
                DataProvider.Ins.DB.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Đang có Sản phẩm chứa size này!", "Thông báo");
            }

            LoadDataSize();
        }
        public void DeleteColor(Color color)
        {
            try
            {
                DataProvider.Ins.DB.Colors.Remove(color);
                DataProvider.Ins.DB.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Đang có sản phẩm chứa màu này!", "Thông báo");
            }

            LoadDataColor();
        }
    }
}
