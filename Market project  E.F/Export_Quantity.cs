//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Market_project__E.F
{
    using System;
    using System.Collections.Generic;
    
    public partial class Export_Quantity
    {
        public int eper_num { get; set; }
        public int item_id { get; set; }
        public string c_email { get; set; }
        public string store_name { get; set; }
        public int export_quantity1 { get; set; }
        public Nullable<System.DateTime> Prod_Date { get; set; }
        public Nullable<System.DateTime> Expi_Date { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual Export_permession Export_permession { get; set; }
        public virtual item item { get; set; }
        public virtual store store { get; set; }
    }
}