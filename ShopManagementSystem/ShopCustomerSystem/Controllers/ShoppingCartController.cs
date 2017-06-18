using ShopCustomerSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ShopCustomerSystem.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
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