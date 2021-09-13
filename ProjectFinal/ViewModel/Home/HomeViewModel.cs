using LiveCharts;
using LiveCharts.Wpf;
using ProjectFinal.Model;
using ProjectFinal.Service;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ProjectFinal.ViewModel.Home
{
    public class HomeViewModel : BindableBase
    {
        #region Variable Binding

        private int _CountOrder;
        public int CountOrder { get => _CountOrder; set { _CountOrder = value; OnPropertyChanged(); } }

        private int _CountDelivered;
        public int CountDelivered { get => _CountDelivered; set { _CountDelivered = value; OnPropertyChanged(); } }

        private int _CountDelivering;
        public int CountDelivering { get => _CountDelivering; set { _CountDelivering = value; OnPropertyChanged(); } }

        private int? _CountProduct;
        public int? CountProduct { get => _CountProduct; set { _CountProduct = value; OnPropertyChanged(); } }

        private string[] _AxistListNameTK;
        public string[] AxistListNameTK
        {
            get { return _AxistListNameTK; }
            set { _AxistListNameTK = value; OnPropertyChanged(); }
        }

        private SeriesCollection _senderChart;
        public SeriesCollection senderChart
        {
            get
            {
                return _senderChart;
            }
            set
            {
                _senderChart = value;
                OnPropertyChanged(nameof(senderChart));
            }
        }

        private string[] _AxistListNameTK1;
        public string[] AxistListNameTK1
        {
            get { return _AxistListNameTK1; }
            set { _AxistListNameTK1 = value; OnPropertyChanged(); }
        }

        private SeriesCollection _senderChart1;
        public SeriesCollection senderChart1
        {
            get
            {
                return _senderChart1;
            }
            set
            {
                _senderChart1 = value;
                OnPropertyChanged(nameof(senderChart1));
            }
        }
        #endregion




        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection SeriesCollection1 { get; set; }


        public string[] Labels { get; set; }
        public string[] Labels1 { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public Func<double, string> Formatter { get; set; }
        public HomeViewModel()
        {
            /*
             Màu chart
             
             */
            var doubleMapperWithMonthColors = new LiveCharts.Configurations.CartesianMapper<int>()
            .X((value, index) => index)
            .Y((value) => value)
            .Fill((v, i) =>
            {
                switch (i % 12)
                {
                    case 0: return Brushes.LightBlue;
                    case 1: return Brushes.LightCoral;
                    case 2: return Brushes.PaleGoldenrod;
                    case 3: return Brushes.OrangeRed;
                    case 4: return Brushes.BlueViolet;
                    case 5: return Brushes.Chocolate;
                    case 6: return Brushes.PaleVioletRed;
                    case 7: return Brushes.CornflowerBlue;
                    case 8: return Brushes.Orchid;
                    case 9: return Brushes.Thistle;
                    case 10: return Brushes.BlanchedAlmond;
                    case 11: return Brushes.YellowGreen;
                    default: return Brushes.Red;
                }
            });
            ObservableCollection<SP_ThongKe_SL_Result> ListTK = new ObservableCollection<SP_ThongKe_SL_Result>(DataProvider.Ins.DB.SP_ThongKe_SL());
            LiveCharts.Charting.For<int>(doubleMapperWithMonthColors, SeriesOrientation.Horizontal);
            var columnSeries = new ColumnSeries() { Values = new ChartValues<int>(), DataLabels = true, Title = "Thống kê sản phẩm đã giao" };

            senderChart = new SeriesCollection();
            foreach (var item in ListTK)
            {
                columnSeries.Values.Add(int.Parse(item.TOTAL_QUANTITY_OF_PRODUCT.ToString()));
            }
            AxistListNameTK = ListTK.Select(c => c.name).ToArray();
            senderChart.Add(columnSeries);

            //Bieu do tròn
            ObservableCollection<TK_SPTHEO_CATEGORY1_Result> ListTK2 = new ObservableCollection<TK_SPTHEO_CATEGORY1_Result>(DataProvider.Ins.DB.TK_SPTHEO_CATEGORY1());
            LiveCharts.Charting.For<int>(doubleMapperWithMonthColors, SeriesOrientation.Horizontal);
            var columnSeries1 = new ColumnSeries() { Values = new ChartValues<int>(), DataLabels = true, Title = "Thống kê sản phẩm đã giao theo danh mục" };

            senderChart1 = new SeriesCollection();
            foreach (var item in ListTK2)
            {
                columnSeries1.Values.Add(int.Parse(item.soluong.ToString()));
            }
            AxistListNameTK1 = ListTK2.Select(c => c.type_product).ToArray();
            senderChart1.Add(columnSeries1);

            Labels = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            YFormatter = value => value.ToString("C");

            //set view countproduct
            var countproduct = (from ORDERS in
                            (from ORDER_DETAIL in DataProvider.Ins.DB.ORDER_DETAIL
                             where
                              ORDER_DETAIL.ORDER.is_active == true
                             select new
                             {
                                 ORDER_DETAIL.quantity,
                                 Dummy = "x"
                             })
                                group ORDERS by new { ORDERS.Dummy } into g
                                select new
                                {
                                    Column1 = (int?)g.Sum(p => p.quantity)
                                }).SingleOrDefault();
            CountProduct = countproduct.Column1;

            CountDelivered = DataProvider.Ins.DB.ORDERS.Where(x => x.status_order == "DELIVERED").Count();

            CountDelivering = DataProvider.Ins.DB.ORDERS.Where(x => x.status_order == "DELIVERING").Count();

            CountOrder = DataProvider.Ins.DB.ORDERS.Where(x => x.is_active == true).Count();

        }
    }
}
