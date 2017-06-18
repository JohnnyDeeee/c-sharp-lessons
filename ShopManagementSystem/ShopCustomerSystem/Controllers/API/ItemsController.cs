using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ShopCustomerSystem.Models;
using System.Reflection;
using System.Web.Http.Results;
using System.Web;

namespace ShopCustomerSystem.Controllers.API
{
    [RoutePrefix("api/Items")]
    public class ItemsController : ApiController
    {
        private shopmsEntities db = new shopmsEntities();

        // GET: api/Items/GetItemsOrdered/MODEL_PROPERTY/ASC_OR_DESC
        [Route("GetItemsOrdered/{property}/{order}")]
        [HttpGet]
        public IHttpActionResult GetItemsOrdered(string property, string order)
        {
            IEnumerable<Item> items = db.Item;
            property = property.First().ToString().ToUpper() + String.Join("", property.Skip(1)); // Make first letter uppercase
            PropertyInfo propertyInfo = new Item().GetType().GetProperty(property);

            // Sadly this has to be hardcoded for now...
            string categoryOrSupplier = property.ToLower() == "category" || property.ToLower() == "supplier" ? property.ToLower() : null;
            propertyInfo = categoryOrSupplier != null ? null : propertyInfo;

            try
            {
                if (order.ToLower() == "asc")
                    items = db.Item.AsEnumerable().OrderBy(i => propertyInfo != null ? propertyInfo.GetValue(i, null) : categoryOrSupplier == "category" ? i.Category.Name : categoryOrSupplier == "supplier" ? i.Supplier.Name : "").ToList(); // Yes the nested ternaries are very ugly, but i just wanted to see if they worked..
                else if (order.ToLower() == "desc")
                    items = db.Item.AsEnumerable().OrderByDescending(i => propertyInfo != null ? propertyInfo.GetValue(i, null) : categoryOrSupplier == "category" ? i.Category.Name : categoryOrSupplier == "supplier" ? i.Supplier.Name : "").ToList(); // Yes the nested ternaries are very ugly, but i just wanted to see if they worked..
                else
                    return BadRequest(string.Format("Order type '{0}' is not allowed! Allowed types are '{1}' and '{2}'"));
            }
            catch (Exception e)
            {
                return BadRequest("Something went very wrong! Here is the stacktrace\n\n" + e.ToString());
            }

            return Ok(items);
        }

        // GET: api/Items/GetItemsFromSearch/SEARCHTEXT
        [Route("GetItemsFromSearch/{searchText}")]
        [HttpGet]
        public IHttpActionResult GetItemsFromSearch(string searchText)
        {
            // Just gonna make this all hardcoded (unlike GetItemsOrdered() ), because it consumes to much time (its fun though)
            List<Item> items = new List<Item>();

            try
            {
                if (searchText != null)
                {
                    int searchTextToInt = -1;
                    bool numeric = Int32.TryParse(searchText, out searchTextToInt);
                    if (!numeric)
                    {
                        db.Item.Where(i => i.Name.Contains(searchText)).ToList().ForEach(delegate (Item item) { items.Add(item); });
                        db.Item.Where(i => i.Description.Contains(searchText)).ToList().ForEach(delegate (Item item) { items.Add(item); });
                        db.Item.Where(i => i.Category.Name.Contains(searchText)).ToList().ForEach(delegate (Item item) { items.Add(item); });
                        db.Item.Where(i => i.Supplier.Name.Contains(searchText)).ToList().ForEach(delegate (Item item) { items.Add(item); });
                    }
                    else
                    {
                        db.Item.Where(i => i.Price == searchTextToInt).ToList().ForEach(delegate (Item item) { items.Add(item); });
                        db.Item.Where(i => i.Stock == searchTextToInt).ToList().ForEach(delegate (Item item) { items.Add(item); });
                    }
                }
                else
                    items = db.Item.ToList();
            }
            catch (Exception e)
            {
                return BadRequest("Something went very wrong! Here is the stacktrace\n\n" + e.ToString());
            }

            return Ok(items);
        }

        // POST: api/Items/AddItemToCart
        [Route("AddItemToCart/{id:int}")]
        [HttpPost]
        public IHttpActionResult AddItemToCart(int id)
        {
            // Using sessions here because i didnt want to rebuild my order model to have a 'status' or make a link with an 'user'
            try
            {
                Item item = db.Item.Single(i => i.Id == id);
                HttpContext.Current.Session.Add("OrderedItem:"+Guid.NewGuid(), item);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Something went very wrong! Here is the stacktrace\n\n" + e.ToString());
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}