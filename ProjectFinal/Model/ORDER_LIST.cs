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
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER_LIST
    {
        public int id_order { get; set; }
        public string Ten_KH { get; set; }
        public string email { get; set; }
        public long total_price { get; set; }
        public Nullable<System.DateTime> delivery_time { get; set; }
    }
}
