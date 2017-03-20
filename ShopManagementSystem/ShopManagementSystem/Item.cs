//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.Orderrule = new HashSet<Orderrule>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Short { get; set; }
        public decimal Price { get; set; }
        public int Category_Id { get; set; }
        public string Description { get; set; }
        public int Supplier_Id { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orderrule> Orderrule { get; set; }
    }
}
