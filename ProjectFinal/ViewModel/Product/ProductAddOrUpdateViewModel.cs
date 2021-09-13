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

namespace ProjectFinal.ViewModel.Product
{
    public class ProductAddOrUpdateViewModel : BindableBase
    {
        #region Variable Binding
        private PRODUCT _ProductCurrent;
        public PRODUCT ProductCurrent { get => _ProductCurrent; set { _ProductCurrent = value; OnPropertyChanged(); } }

        private ObservableCollection<MENU_PRODUCT> _Categories;
        public ObservableCollection<MENU_PRODUCT> Categories { get => _Categories; set { _Categories = value; OnPropertyChanged(); } }

        private MENU_PRODUCT _CategorySelected;
        public MENU_PRODUCT CategorySelected { get => _CategorySelected; set { _CategorySelected = value; OnPropertyChanged(); } }

        private ObservableCollection<PROMOTION> _Promotion;
        public ObservableCollection<PROMOTION> Promotion { get => _Promotion; set { _Promotion = value; OnPropertyChanged(); } }

        private PROMOTION _PromotionSelected;
        public PROMOTION PromotionSelected { get => _PromotionSelected; set { _PromotionSelected = value; OnPropertyChanged(); } }

        private ObservableCollection<Size> _Size;
        public ObservableCollection<Size> Size { get => _Size; set { _Size = value; OnPropertyChanged(); } }
        private Size _SizeSelected;
        public Size SizeSelected { get => _SizeSelected; set { _SizeSelected = value; OnPropertyChanged(); } }

        private ObservableCollection<Color> _Color;
        public ObservableCollection<Color> Color { get => _Color; set { _Color = value; OnPropertyChanged(); } }
        private Color _ColorSelected;
        public Color ColorSelected { get => _ColorSelected; set { _ColorSelected = value; OnPropertyChanged(); } }
        private PRODUCT ProductBackup { get; set; }

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
        public ProductAddOrUpdateViewModel(PRODUCT product = null)
        {
            Categories = new ObservableCollection<MENU_PRODUCT>(DataProvider.Ins.DB.MENU_PRODUCT);
            Promotion = new ObservableCollection<PROMOTION>(DataProvider.Ins.DB.PROMOTIONs);
            Size = new ObservableCollection<Size>(DataProvider.Ins.DB.Sizes);
            Color = new ObservableCollection<Color>(DataProvider.Ins.DB.Colors);

            if (product != null)
            {
                Header = "Chỉnh Sửa";
                ProductBackup = product;
                ProductCurrent = ProductBackup;


                CategorySelected = Categories.FirstOrDefault((u) => u.id_menu_product == ProductCurrent.id_menu_product);
                PromotionSelected = Promotion.FirstOrDefault((u) => u.id_promotion == ProductCurrent.id_promotion);
                SizeSelected = Size.FirstOrDefault((u) => u.name_size == ProductCurrent.size);
                ColorSelected = Color.FirstOrDefault((u) => u.name_color == ProductCurrent.color);
            }
            else
            {
                Header = "Thêm Mới";
                ProductCurrent = new PRODUCT();
            }
        }

        public void Save()
        {
            ProductCurrent.id_menu_product = CategorySelected.id_menu_product;
            ProductCurrent.id_promotion = PromotionSelected.id_promotion;
            ProductCurrent.size = SizeSelected.name_size;
            ProductCurrent.color = ColorSelected.name_color;

            if (ProductBackup == null)
            {
                try
                {
                    ProductCurrent.is_active = true;

                    ProductCurrent.created_date = DateTime.Now;
                    ProductCurrent.price = (PromotionSelected.percent_down / 100) * ProductCurrent.price;
                    DataProvider.Ins.DB.PRODUCTs.Add(ProductCurrent);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Thêm mới Sản Phẩm thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm mới Sản Phẩm thất bại!");
                }

            }
            else
            {
                try
                {
                    ProductCurrent.modified_date = DateTime.Now;
                    double? a = ProductCurrent.price - (((double)PromotionSelected.percent_down / 100) * ProductCurrent.price);
                    ProductCurrent.price = (long)a;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Chỉnh sửa Sản Phẩm thành công!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Đang có sản phẩm này trong đơn đặt hàng! Không thể chỉnh sửa ", "Thông báo!");


                }

            }

            (App.Current.MainWindow.DataContext as MainViewModel).ProductViewModel.LoadDataProduct();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }

        public void OpenDialogChooseImage()
        {
            OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "Image files (*.jpg, *.png) | *.jpg; *.png" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                ProductCurrent.image_product = fileDialog.FileName;
        }
    }
}
