//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectFinal.Model
{
    using ProjectFinal.ViewModel.Base;
    using System;
    using System.Collections.Generic;

    public partial class USER : BindableBase
    {
        public int id_user { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<bool> is_active { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public int id_role { get; set; }
        public string name { get; set; }

        private string _image_user;
        public string image_user { get => _image_user; set { _image_user = value; OnPropertyChanged(); } }

        public virtual APP_ROLE APP_ROLE { get; set; }
    }
}