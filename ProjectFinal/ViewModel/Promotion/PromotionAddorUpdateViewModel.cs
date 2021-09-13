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

namespace ProjectFinal.ViewModel.Promotion
{
    public class PromotionAddorUpdateViewModel : BindableBase
    {
        #region Variable Binding
        private PROMOTION _PromotionCurrent;
        public PROMOTION PromotionCurrent { get => _PromotionCurrent; set { _PromotionCurrent = value; OnPropertyChanged(); } }


        private PROMOTION _PromotionSelected;
        public PROMOTION PromotionSelected { get => _PromotionSelected; set { _PromotionSelected = value; OnPropertyChanged(); } }

        private PROMOTION PromotionBackup { get; set; }

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
        public PromotionAddorUpdateViewModel(PROMOTION promotion = null)
        {
            if (promotion != null)
            {
                Header = "Chỉnh Sửa";
                PromotionBackup = promotion;
                PromotionCurrent = PromotionBackup;

            }
            else
            {
                Header = "Thêm Mới";
                PromotionCurrent = new PROMOTION();
            }
        }

        public void Save()
        {

            if (PromotionBackup == null)
            {
                try
                {
                    PromotionCurrent.is_active = true;

                    PromotionCurrent.created_date = DateTime.Now;
                    DataProvider.Ins.DB.PROMOTIONs.Add(PromotionCurrent);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Thêm mới chương trình thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm mới chương trình thất bại!");
                }

            }
            else
            {
                try
                {
                    PromotionCurrent.modified_date = DateTime.Now;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Chỉnh sửa chương trình thành công!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Chương trình này đang được áp dụng! Không thể chỉnh sửa ", "Thông báo!");


                }

            }

            (App.Current.MainWindow.DataContext as MainViewModel).PromotionViewModel.LoadDataPromotion();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }

        public void OpenDialogChooseImage()
        {
            OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "Image files (*.jpg, *.png) | *.jpg; *.png" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                PromotionCurrent.image_promotion = fileDialog.FileName;
        }
    }
}
