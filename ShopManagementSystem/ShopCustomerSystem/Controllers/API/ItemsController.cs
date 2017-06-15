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

namespace ShopCustomerSystem.Controllers.API
{
    public class ItemsController : ApiController
    {
        private shopmsEntities db = new shopmsEntities();

        // GET: api/Items
        public IQueryable<Item> GetItem()
        {
            return db.Item;
        }

        // GET: api/Items/5
        [ResponseType(typeof(Item))]
        public IHttpActionResult GetItem(int id)
        {
            Item item = db.Item.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // GET: api/Items/MODEL_PROPERTY/ASC_OR_DESC
        //[ResponseType(typeof(JsonResult<List<Item>>))]
        public IQueryable<Item> GetItemsOrdered(string property, string order)
        {
            //IQueryable<Item> items = db.Item;
            //property = property.First().ToString().ToUpper() + String.Join("", property.Skip(1)); // Make first letter uppercase
            //PropertyInfo propertyInfo = new Item().GetType().GetProperty(property);

            //if (order.ToLower() == "asc")
            //    items = db.Item.OrderBy(i => propertyInfo.GetValue(i, null));
            //else if (order.ToLower() == "desc")
            //    items = db.Item.OrderByDescending(i => propertyInfo.GetValue(i, null));
            //else
                //return BadRequest(string.Format("Order type '{0}' is not allowed! Allowed types are '{1}' and '{2}'"));

            //return Ok(Json(items));
            return db.Item;
        }

        // PUT: api/Items/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutItem(int id, Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != item.Id)
            {
                return BadRequest();
            }

            db.Entry(item).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Items
        [ResponseType(typeof(Item))]
        public IHttpActionResult PostItem(Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Item.Add(item);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = item.Id }, item);
        }

        // DELETE: api/Items/5
        [ResponseType(typeof(Item))]
        public IHttpActionResult DeleteItem(int id)
        {
            Item item = db.Item.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            db.Item.Remove(item);
            db.SaveChanges();

            return Ok(item);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ItemExists(int id)
        {
            return db.Item.Count(e => e.Id == id) > 0;
        }
    }
}