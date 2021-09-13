using ProjectFinal.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Model
{
    public class ViewOrderDetail : BindableBase
    {
        private int _id_product;
        public int id_product { get => _id_product; set { _id_product = value; OnPropertyChanged(); } }

        private String _name;
        public String name { get => _name; set { _name = value; OnPropertyChanged(); } }

        private String _image_product;
        public String image_product { get => _image_product; set { _image_product = value; OnPropertyChanged(); } }

        private String _size;
        public String size { get => _size; set { _size = value; OnPropertyChanged(); } }

        private double _price;
        public double price { get => _price; set { _price = value; OnPropertyChanged(); } }

        private int _quantity;
        public int quantity { get => _quantity; set { _quantity = value; OnPropertyChanged(); } }

        //public ViewOrderDetail(int id_product, string name, string image_product, string size, double price, int quantity)
        //{
        //    this.id_product = id_product;
        //    this.name = name;
        //    this.image_product = image_product;
        //    this.size = size;
        //    this.price = price;
        //    this.quantity = quantity;
        //}
    }
}
