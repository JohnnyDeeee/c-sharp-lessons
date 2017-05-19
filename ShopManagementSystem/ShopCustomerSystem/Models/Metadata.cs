using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopCustomerSystem.Models
{
	public class Metadata
	{
        // Example metadata for: Items
        [MetadataType(typeof(Item.MetaData))]
        public partial class Item
        {
            internal class MetaData
            {
                [Display(Name = "Is good price my friend!")]
                public decimal Price;
            }
        }
    }
}