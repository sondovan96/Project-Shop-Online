
using CrystalDecisions.CrystalReports.Engine;

using ProjectFinal.Model;
using ProjectFinal.Reporter;
using ProjectFinal.Service;
using ProjectFinal.Utility;
using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.ViewModel.Statistic
{
    public class StatisticViewModel:BindableBase
    {

        private ORDER _OrderCurrent;
        public ORDER OrderCurrent { get=> _OrderCurrent; set { _OrderCurrent = value;OnPropertyChanged(); } }

        private ReportDocument _Report;
        public ReportDocument Report { get=> _Report; set { _Report = value;OnPropertyChanged(); } }

        private List<ViewOrderDetail> _OrderDetailList;
        public List<ViewOrderDetail> OrderDetailList { get => _OrderDetailList; set { _OrderDetailList = value; OnPropertyChanged(); } }

        public StatisticViewModel(ORDER order = null)
        {
            OrderCurrent = order;
            if(OrderCurrent!=null)
            {
                Report = new SaleOrderDetail();
                List<sp_report_info_customer_Result> rp = DataProvider.Ins.DB.sp_report_info_customer(OrderCurrent.id_order).ToList();
                
                Report.SetDataSource(rp);
                Report.Database.Tables["product_detail"].SetDataSource(LoadDataOrderDetail());
            }
        }

        public List<ViewOrderDetail> LoadDataOrderDetail()
        {

            var list = (from odt in DataProvider.Ins.DB.ORDER_DETAIL
                        where
                          odt.id_order == OrderCurrent.id_order
                        group new { odt, odt.PRODUCT } by new
                        {
                            odt.id_product,
                            odt.PRODUCT.name,
                            odt.PRODUCT.image_product,
                            odt.PRODUCT.size
                        } into g
                        select new
                        {
                            g.Key.id_product,
                            g.Key.name,
                            g.Key.image_product,
                            g.Key.size,
                            price = (g.Sum(p => p.odt.PRODUCT.price) * g.Sum(p => p.odt.quantity)),
                            quantity = (int)g.Sum(p => p.odt.quantity)
                        }).ToList();
            OrderDetailList = new List<ViewOrderDetail>();
            foreach (var item in list)
            {
                ViewOrderDetail listDetail = new ViewOrderDetail();
                listDetail.id_product = item.id_product;
                listDetail.name = item.name;
                listDetail.image_product = item.image_product;
                listDetail.size = item.size;
                listDetail.price = item.price;
                listDetail.quantity = item.quantity;

                OrderDetailList.Add(listDetail);
            }
            return OrderDetailList;
        }
    }
}
