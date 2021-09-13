using CrystalDecisions.CrystalReports.Engine;
using ProjectFinal.Model;
using ProjectFinal.Reporter;
using ProjectFinal.Service;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.ViewModel.Statistic
{
    public class ReportDayViewModel:BindableBase
    {
        private ReportDocument _Report;
        public ReportDocument Report { get => _Report; set { _Report = value; OnPropertyChanged(); } }
        public ReportDayViewModel(ObjectDate type)
        {
           
            Report = new ReportSaleDay();
            List<sp_report_day_Result> rp = DataProvider.Ins.DB.sp_report_day(type.dateTrans.Day, type.dateTrans.Month, type.dateTrans.Year).ToList();

            Report.SetDataSource(rp);
        }

    }
}
