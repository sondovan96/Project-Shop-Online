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

namespace ProjectFinal.ViewModel.Customer
{
    public class CustomerAddorUpdateViewModel : BindableBase
    {
        #region Variable Binding
        private CUSTOMER _CustomerCurrent;
        public CUSTOMER CustomerCurrent { get => _CustomerCurrent; set { _CustomerCurrent = value; OnPropertyChanged(); } }

        private ObservableCollection<Gender> _genderList;
        public ObservableCollection<Gender> genderList { get => _genderList; set { _genderList = value; OnPropertyChanged(); } }

        private Gender _genderSelected;
        public Gender genderSelected { get => _genderSelected; set { _genderSelected = value; OnPropertyChanged(); } }

        private CUSTOMER CustomerBackup { get; set; }

        private String _header;
        public String Header
        {
            get { return _header; }
            set { _header = value; OnPropertyChanged(); }
        }


        #endregion

        #region Command
        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } set { OnPropertyChanged(); } }
        #endregion
        public CustomerAddorUpdateViewModel(CUSTOMER customer = null)
        {
            genderList = new ObservableCollection<Gender>(){
                new Gender() {id_gender=1,name="Male"},
                new Gender() {id_gender=2,name="Female"},
                new Gender() {id_gender=3,name="Other"}};

            if (customer != null)
            {

                Header = "Chỉnh Sửa";
                CustomerBackup = customer;
                CustomerCurrent = CustomerBackup;
                genderSelected = genderList.FirstOrDefault((u) => u.name == CustomerCurrent.gender);
            }
            else
            {
                Header = "Thêm Mới";
                CustomerCurrent = new CUSTOMER();
            }
        }

        public void Save()
        {

            if (CustomerBackup == null)
            {
                try
                {
                    CustomerCurrent.is_active = true;

                    CustomerCurrent.created_date = DateTime.Now;
                    CustomerCurrent.gender = genderSelected.name;
                    DataProvider.Ins.DB.CUSTOMERS.Add(CustomerCurrent);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Thêm mới Khách hàng thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm mới Khách hàng thất bại!");
                }

            }
            else
            {
                try
                {
                    CustomerCurrent.modified_date = DateTime.Now;
                    CustomerCurrent.gender = genderSelected.name;
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Chỉnh sửa Khách hàng thành công!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể chỉnh sửa ", "Thông báo!");


                }

            }

            (App.Current.MainWindow.DataContext as MainViewModel).CustomerViewModel.LoadDataCustomer();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }

    }
    public class Gender
    {
        public int id_gender { get; set; }
        public String name { get; set; }
    }
}
