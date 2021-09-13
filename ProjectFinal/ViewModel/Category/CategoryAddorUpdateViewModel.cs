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

namespace ProjectFinal.ViewModel.Category
{
    public class CategoryAddorUpdateViewModel : BindableBase
    {
        #region Variable Binding
        private MENU_PRODUCT _CategoryCurrent;
        public MENU_PRODUCT CategoryCurrent { get => _CategoryCurrent; set { _CategoryCurrent = value; OnPropertyChanged(); } }

        private MENU_PRODUCT CategoryBackup { get; set; }

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
        public CategoryAddorUpdateViewModel(MENU_PRODUCT category = null)
        {
            if (category != null)
            {

                Header = "Chỉnh Sửa";
                CategoryBackup = category;
                CategoryCurrent = CategoryBackup;
            }
            else
            {
                Header = "Thêm Mới";
                CategoryCurrent = new MENU_PRODUCT();
            }
        }

        public void Save()
        {

            if (CategoryBackup == null)
            {
                try
                {
                    CategoryCurrent.created_date = DateTime.Now;
                    DataProvider.Ins.DB.MENU_PRODUCT.Add(CategoryCurrent);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Thêm mới Danh Mục thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm mới Danh Mục thất bại!");
                }

            }
            else
            {
                try
                {

                    CategoryCurrent.modified_date = DateTime.Now;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Chỉnh sửa Danh Mục thành công!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể chỉnh sửa ", "Thông báo!");
                }

            }

            (App.Current.MainWindow.DataContext as MainViewModel).CategoryViewModel.LoadDataCategory();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }

    }
}
