//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeHome.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DrinkAndDessert
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DrinkAndDessert()
        {
            this.Bill_details = new HashSet<Bill_details>();
            this.Bill_Online_Detail = new HashSet<Bill_Online_Detail>();
        }
    
        public string name { get; set; }
        public string description { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public int id_drink { get; set; }
        public Nullable<int> id_type { get; set; }
        public string image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_details> Bill_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_Online_Detail> Bill_Online_Detail { get; set; }
        public virtual Drink_type Drink_type { get; set; }
    }
}