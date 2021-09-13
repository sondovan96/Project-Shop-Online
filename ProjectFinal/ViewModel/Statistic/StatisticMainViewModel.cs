using ProjectFinal.Model;
using ProjectFinal.Utility;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectFinal.ViewModel.Statistic
{
    public class StatisticMainViewModel:BindableBase
    {

        private ObjectDate _SelectedDate;
        public ObjectDate SelectedDate { get => _SelectedDate; set { _SelectedDate = value; OnPropertyChanged(); } }

        private DateTime _DateCur;
        public DateTime DateCur { get => _DateCur; set { _DateCur = value; OnPropertyChanged(); } }

        public ICommand ReportDayCMD { get { return new CommandHelper<ObjectDate>((p) => { return true; }, ((p) => ReportDay(p))); } }

        //public ICommand ReportMonthCMD { get { return new CommandHelper<DateTime>((p) => p != null, ((p) => ReportMonth(p))); } }
        //public ICommand ReportYearCMD { get { return new CommandHelper<DateTime>((p) => p != null, ((p) => ReportYear(p))); } }
        public StatisticMainViewModel()
        {
            DateCur = DateTime.Now;
            
            //AddNewCMD = new RelayCommand<object>((p) => { return true; }, (p) =>
            //{
            //    ProductAddorUpdate pdAdd = new ProductAddorUpdate();
            //    pdAdd.ShowDialog(new ProductAddOrUpdateViewModel());
            //});
        }
        public void ReportDay(ObjectDate type)
        {
            SelectedDate = new ObjectDate();
            SelectedDate.dateTrans = DateCur;
            (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ReportDayViewModel(SelectedDate));
        }
        //public void ReportMonth(DateTime type)
        //{
        //    (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new StatisticViewModel(null, type));
        //}
        //public void ReportYear(DateTime type)
        //{
        //    (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new StatisticViewModel(null, type));
        //}
    }
}
