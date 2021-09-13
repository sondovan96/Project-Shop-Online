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

namespace ProjectFinal.ViewModel.Order
{
    public class OrderDetailViewModel : BindableBase
    {

        #region Variable Binding
        private ORDER _OrderCurrent;
        public ORDER OrderCurrent { get => _OrderCurrent; set { _OrderCurrent = value; OnPropertyChanged(); } }



        private ViewOrderDetail _ProductSelected;
        public ViewOrderDetail ProductSelected { get => _ProductSelected; set { _ProductSelected = value; OnPropertyChanged(); } }

        private ORDER_DETAIL _OrderDetail;
        public ORDER_DETAIL OrderDetail { get => _OrderDetail; set { _OrderDetail = value; OnPropertyChanged(); } }


        private List<ViewOrderDetail> _OrderDetailList;
        public List<ViewOrderDetail> OrderDetailList { get => _OrderDetailList; set { _OrderDetailList = value; OnPropertyChanged(); } }

        private MENU_PRODUCT _CategorySelected;
        public MENU_PRODUCT CategorySelected { get => _CategorySelected; set { _CategorySelected = value; OnPropertyChanged(); } }


        private PRODUCT ProductBackup { get; set; }




        #endregion

        #region Icommand
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); (App.Current.MainWindow.DataContext as MainViewModel).OrderViewModel.LoadList(); }); } }
        public ICommand DeleteCMD { get { return new CommandHelper<ViewOrderDetail>((p) => p != null, ((p) => Delete(p))); } }
        #endregion
        public OrderDetailViewModel(ORDER order)
        {
            OrderCurrent = order;
            LoadDataOrderDetail();

        }
        public void Delete(ViewOrderDetail vieworder)
        {
            try
            {
                int idproduct = vieworder.id_product;
                OrderDetail = DataProvider.Ins.DB.ORDER_DETAIL.Where(x => x.id_product == idproduct && x.id_order == OrderCurrent.id_order).FirstOrDefault();
                var sum = (from ODT in DataProvider.Ins.DB.ORDER_DETAIL
                           where
                                                 ODT.id_order == OrderCurrent.id_order &&
                                                 ODT.id_product == idproduct
                           select new
                           {
                               Column1 = (ODT.unit_price * ODT.quantity)
                           }).FirstOrDefault();
                OrderCurrent.total_price = OrderCurrent.total_price - sum.Column1;
                OrderCurrent.total_product = OrderCurrent.total_product - OrderDetail.quantity;
                DataProvider.Ins.DB.ORDER_DETAIL.Remove(OrderDetail);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Xoá thành công", "THông báo");
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá không thành công", "THông báo");
            }

            LoadDataOrderDetail();
            (App.Current.MainWindow.DataContext as MainViewModel).OrderViewModel.LoadList();
        }

        public void LoadDataOrderDetail()
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
        }
    }
}
