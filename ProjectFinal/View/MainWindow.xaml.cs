using ProjectFinal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectFinal.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GridBarTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                //App.Current.Shutdown();
                App.Current.MainWindow.Hide();
                //App.Current.MainWindow.DataContext = new LoginViewModel();
                foreach (var item in App.Current.Windows)
                {
                    if (item.GetType() == typeof(LoginWindow))
                    {
                        (item as Window).Show();
                    }

                }
            }
        }

        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            btnOpenMenu.Visibility = Visibility.Collapsed;
            btnCloseMenu.Visibility = Visibility.Visible;
            //GridContent.Margin = new Thickness(225, 100 ,0 ,0);
            //logo.Width = 220;
        }
        private void btnCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            btnOpenMenu.Visibility = Visibility.Visible;
            btnCloseMenu.Visibility = Visibility.Collapsed;
            //GridContent.Margin = new Thickness(65, 100, 0, 0);
            //logo.Width = 60;
        }
    }
}
