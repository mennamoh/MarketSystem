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
    
    public partial class Export_permession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Export_permession()
        {
            this.Export_Quantity = new HashSet<Export_Quantity>();
        }
    
        public int eper_num { get; set; }
        public int item_id { get; set; }
        public string store_name { get; set; }
        public string c_email { get; set; }
        public Nullable<System.DateTime> eper_date { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Export_Quantity> Export_Quantity { get; set; }
        public virtual item item { get; set; }
        public virtual store store { get; set; }
    }
}