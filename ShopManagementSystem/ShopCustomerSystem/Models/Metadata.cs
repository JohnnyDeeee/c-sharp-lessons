using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopCustomerSystem.Models
{
    // Metadata for: Items
    [MetadataType(typeof(ItemMetaData))]
    public partial class Item { }
    public class ItemMetaData
    {
        [Display(Name = "Is good price my friend!")]
        public decimal Price { get; set; }

        [JsonIgnore]
        public virtual ICollection<Orderrule> Orderrule { get; set; }
    }

    // Metadata for: Category
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category { }
    public class CategoryMetaData
    {
        [Display(Name = "Category")]
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Item> Item { get; set; }
    }

    // Metadata for: Supplier
    [MetadataType(typeof(SupplierMetaData))]
    public partial class Supplier { }
    public class SupplierMetaData
    {
        [Display(Name = "Supplier")]
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Item> Item { get; set; }
    }
}