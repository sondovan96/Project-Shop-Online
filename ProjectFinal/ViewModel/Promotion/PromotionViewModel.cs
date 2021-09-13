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

namespace ProjectFinal.ViewModel.Promotion
{
    public class PromotionViewModel : BindableBase
    {
        #region VariableBinding
        private ObservableCollection<PROMOTION> _PromotionList;
        public ObservableCollection<PROMOTION> PromotionList { get => _PromotionList; set { _PromotionList = value; OnPropertyChanged(); } }

        private PROMOTION _SelectedItem;
        public PROMOTION SelectedItem { get => _SelectedItem; set { _SelectedItem = value; OnPropertyChanged(); } }
        #endregion

        #region Command
        public ICommand AddNewPromotionCMD { get { return new CommandHelper(AddNewPromotion); } }

        public ICommand EditPromotionCMD { get { return new CommandHelper<PROMOTION>((p) => p != null, ((p) => EditPromotion(p))); } }
        public ICommand DeletePromotionCMD { get { return new CommandHelper<PROMOTION>((p) => p != null, ((p) => ConfirmPromotion(p))); } }

        //public ICommand AddNewCMD { get; set; }
        #endregion
        public PromotionViewModel()
        {
            LoadDataPromotion();
            //AddNewCMD = new RelayCommand<object>((p) => { return true; }, (p) =>
            //{
            //    ProductAddorUpdate pdAdd = new ProductAddorUpdate();
            //    pdAdd.ShowDialog(new ProductAddOrUpdateViewModel());
            //});

        }

        public void LoadDataPromotion()
        {
            PromotionList = new ObservableCollection<PROMOTION>(DataProvider.Ins.DB.PROMOTIONs);
        }
        public void AddNewPromotion() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new PromotionAddorUpdateViewModel());
        public void EditPromotion(PROMOTION promotion) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new PromotionAddorUpdateViewModel(promotion));
        public void ConfirmPromotion(PROMOTION promotion) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteProduct(promotion); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, promotion.name));

        public void DeleteProduct(PROMOTION promotion)
        {
            try
            {
                DataProvider.Ins.DB.PROMOTIONs.Remove(promotion);
                DataProvider.Ins.DB.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Đang có đơn hàng chứa sản phẩm này!", "Thông báo");
            }

            LoadDataPromotion();
        }
    }
}
