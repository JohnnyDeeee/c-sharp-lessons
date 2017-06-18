using ShopCustomerSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Collections.Specialized.NameObjectCollectionBase;

namespace ShopCustomerSystem.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        // TODO: Sometimes category is empty (?) so index page crashes ??
        public ActionResult Index()
        {
            List<Item> items = new List<Item>();
            foreach (string key in Session.Keys)
            {
                if (key.ToLower().Contains("ordereditem"))
                    items.Add(Session[key] as Item);
            }

            ViewBag.Items = items;

            return View();
        }
    }
}