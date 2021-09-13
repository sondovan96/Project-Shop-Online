using MaterialDesignThemes.Wpf;
using ProjectFinal.Internationalization;
using ProjectFinal.Model;
using ProjectFinal.Service;
using ProjectFinal.Utility;
using ProjectFinal.ViewModel.Account;
using ProjectFinal.ViewModel.Base;
using ProjectFinal.ViewModel.Category;
using ProjectFinal.ViewModel.Customer;
using ProjectFinal.ViewModel.Home;
using ProjectFinal.ViewModel.Order;
using ProjectFinal.ViewModel.Parameter;
using ProjectFinal.ViewModel.Product;
using ProjectFinal.ViewModel.Promotion;
using ProjectFinal.ViewModel.Setting;
using ProjectFinal.ViewModel.Statistic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectFinal.ViewModel
{
    public class MainViewModel : BindableBase
    {

        #region [ViewModel]
        public OrderViewModel OrderViewModel { get; set; }
        public ProductViewModel ProductViewModel { get; set; }
        public HomeViewModel HomeViewModel { get; set; }
        public PromotionViewModel PromotionViewModel { get; set; }
        public CustomerViewModel CustomerViewModel { get; set; }
        public CategoryViewModel CategoryViewModel { get; set; }
        public AccountViewModel AccountViewModel { get; set; }
        public StatisticMainViewModel StatisticMainViewModel { get; set; }

        public ParameterViewModel ParameterViewModel { get; set; }
        public SettingViewModel SettingViewModel { get; set; }
        #endregion
        #region [Bindable Prop]
        private object _viewCurrent;
        private object _dialogContent;
        private ItemNavigate _selectedView;




        public ItemNavigate SelectedView
        {
            get { return _selectedView; }
            set { _selectedView = value; OnPropertyChanged(); ChangeView(value); }
        }
        public object ViewCurrent
        {
            get { return _viewCurrent; }
            set { _viewCurrent = value; OnPropertyChanged(); }
        }
        public object DialogContent
        {
            get { return _dialogContent; }
            set { _dialogContent = value; OnPropertyChanged(); }
        }
        #endregion
        #region [Collections]
        private ObservableCollection<ItemNavigate> _listItemNavigate;
        public ObservableCollection<ItemNavigate> ListItemNavigate
        {
            get { return _listItemNavigate; }
            set { _listItemNavigate = value; OnPropertyChanged(); }
        }

        private USER _UserCurrent;
        public USER UserCurrent
        {
            get { return _UserCurrent; }
            set { _UserCurrent = value; OnPropertyChanged(); }
        }

        private int _NewOrder;
        public int NewOrder { get => _NewOrder; set { _NewOrder = value; OnPropertyChanged(); } }
        #endregion
        #region [Commands]
        public ICommand ChangeViewCMD { get { return new CommandHelper<ItemNavigate>((i) => i != null, ((i) => ChangeView(i))); } }
        public ICommand ChangePassCMD { get { return new CommandHelper(ChangePass); } }
        public ICommand SettingCMD { get { return new CommandHelper(Setting); } }

        #endregion

        public MainViewModel()
        {
            UserCurrent = GlobalVariable.userSave;
            LoadListItemNavigate();
            ChangeView(ListItemNavigate[0]); // Defualt Home View
            NewOrder = DataProvider.Ins.DB.ORDERS.Where(x => x.status_order == "PENDING").Count();

        }
        public void ChangePass() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ChangePasswordViewModel());
        public void Setting() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new SettingViewModel());
        public void LoadListItemNavigate()
        {
            if(GlobalVariable.StringResource==false)
            {
                StringResources.ApplyLanguage(Enum.ALL_ENUM.Language.VN);
            }
            else
            {
                StringResources.ApplyLanguage(Enum.ALL_ENUM.Language.EN);
            }
            
            if (UserCurrent.id_role == 1)
            {
                ListItemNavigate = new ObservableCollection<ItemNavigate>()
            {
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("HOME"),
                     Type = Enum.ALL_ENUM.ViewType.HOME,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Home ,
                     IsSelected = true
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("PRODUCT"),
                     Type = Enum.ALL_ENUM.ViewType.PRODUCT,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.PackageVariantClosed,

                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("ORDER"),
                     Type = Enum.ALL_ENUM.ViewType.ORDER,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.TruckDelivery ,

                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("PROMOTION"),
                     Type = Enum.ALL_ENUM.ViewType.PROMOTION,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Sale
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("CUSTOMER"),
                     Type = Enum.ALL_ENUM.ViewType.CUSTOMER,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.FaceAgent
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("CATEGORY"),
                     Type = Enum.ALL_ENUM.ViewType.CATEGORY,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Buffer
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("ACCOUNT"),
                     Type = Enum.ALL_ENUM.ViewType.ACCOUNT,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.AccountBoxOutline
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("STATISTIC"),
                     Type = Enum.ALL_ENUM.ViewType.STATISTIC,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Finance
                },
                 new ItemNavigate()
                {
                     DisplayName = StringResources.Find("PARAMETER"),
                     Type = Enum.ALL_ENUM.ViewType.PARAMETER,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.PlaylistEdit
                },
            };
            }
            else if (UserCurrent.id_role == 2)
            {
                ListItemNavigate = new ObservableCollection<ItemNavigate>()
            {
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("HOME"),
                     Type = Enum.ALL_ENUM.ViewType.HOME,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Home ,
                     IsSelected = true
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("PRODUCT"),
                     Type = Enum.ALL_ENUM.ViewType.PRODUCT,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.PackageVariantClosed,

                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("ORDER"),
                     Type = Enum.ALL_ENUM.ViewType.ORDER,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.TruckDelivery ,

                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("CUSTOMER"),
                     Type = Enum.ALL_ENUM.ViewType.CUSTOMER,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.FaceAgent
                },
            };
            }
            else
            {
                ListItemNavigate = new ObservableCollection<ItemNavigate>()
            {
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("HOME"),
                     Type = Enum.ALL_ENUM.ViewType.HOME,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Home ,
                     IsSelected = true
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("PRODUCT"),
                     Type = Enum.ALL_ENUM.ViewType.PRODUCT,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.PackageVariantClosed,

                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("ORDER"),
                     Type = Enum.ALL_ENUM.ViewType.ORDER,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.TruckDelivery ,

                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("PROMOTION"),
                     Type = Enum.ALL_ENUM.ViewType.PROMOTION,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Sale
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("CUSTOMER"),
                     Type = Enum.ALL_ENUM.ViewType.CUSTOMER,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.FaceAgent
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("CATEGORY"),
                     Type = Enum.ALL_ENUM.ViewType.CATEGORY,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Buffer
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("STATISTIC"),
                     Type = Enum.ALL_ENUM.ViewType.STATISTIC,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Finance
                },
            };
            }

        }

        public void ChangeView(ItemNavigate itemNavigate)
        {
            foreach (var item in ListItemNavigate)
                item.IsSelected = false;


            itemNavigate.IsSelected = true;


            switch (itemNavigate.Type)
            {
                case Enum.ALL_ENUM.ViewType.HOME:
                    ViewCurrent = HomeViewModel == null ? new HomeViewModel() : HomeViewModel;
                    break;
                case Enum.ALL_ENUM.ViewType.ORDER:
                    ViewCurrent = OrderViewModel == null ? OrderViewModel = new OrderViewModel() : OrderViewModel;
                    break;
                case Enum.ALL_ENUM.ViewType.PRODUCT:
                    ViewCurrent = ProductViewModel == null ? ProductViewModel = new ProductViewModel() : ProductViewModel;
                    break;
                case Enum.ALL_ENUM.ViewType.PROMOTION:
                    ViewCurrent = PromotionViewModel == null ? PromotionViewModel = new PromotionViewModel() : PromotionViewModel;
                    break;
                case Enum.ALL_ENUM.ViewType.CUSTOMER:
                    ViewCurrent = CustomerViewModel == null ? CustomerViewModel = new CustomerViewModel() : CustomerViewModel;
                    break;
                case Enum.ALL_ENUM.ViewType.CATEGORY:
                    ViewCurrent = CategoryViewModel == null ? CategoryViewModel = new CategoryViewModel() : CategoryViewModel;
                    break;
                case Enum.ALL_ENUM.ViewType.ACCOUNT:
                    ViewCurrent = AccountViewModel == null ? AccountViewModel = new AccountViewModel() : AccountViewModel;
                    break;
                case Enum.ALL_ENUM.ViewType.STATISTIC:
                    ViewCurrent = StatisticMainViewModel == null ? StatisticMainViewModel = new StatisticMainViewModel() : StatisticMainViewModel;
                    break;
                case Enum.ALL_ENUM.ViewType.PARAMETER:
                    ViewCurrent = ParameterViewModel == null ? ParameterViewModel = new ParameterViewModel() : ParameterViewModel;
                    break;
                default:
                    break;
            }
        }

        public void OpenDiaLog(object content) => DialogHost.Show(content, "MainDialog");

        public void CloseDialog() => DialogHost.Close("MainDialog");
    }
}
