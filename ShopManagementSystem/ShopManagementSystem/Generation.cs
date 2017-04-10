
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ShopManagementSystem
{
    static class Generation
    {
        private static Random rand = new Random();
        private static List<Bitmap> images = new List<Bitmap>();
        private static ImageConverter imgConverter = new ImageConverter();

        // Start generation
        public static void Generate()
        {
            // Hardcoded images for testing
            images.Add(Properties.Resources.icon_1);
            images.Add(Properties.Resources.icon_2);
            images.Add(Properties.Resources.icon_3);
            images.Add(Properties.Resources.icon_4);
            images.Add(Properties.Resources.icon_5);

            GenerateCategories();
            GenerateSuppliers();
            GenerateItems();
            GenerateCustomers();

            GenerateOrders();
            GenerateOrderrules();
        }

        // Generate random items and put those in the dbase
        private static void GenerateItems(int amount = 100)
        {
            List<string> usedNames = new List<string>();
            const int minNameLength = 5;
            const int maxNameLength = 15;
            for (int i = 0; i < amount; i++)
            {
                using (var context = new ShopmsEntities())
                {
                    Item item = new Item();
                    item.Name = GenerateRandomText(rand.Next(minNameLength, maxNameLength));
                    while(usedNames.Contains(item.Name)) // TODO: Add timeout
                        item.Name = GenerateRandomText(rand.Next(minNameLength, maxNameLength));
                    usedNames.Add(item.Name);
                    item.Price = Math.Round(Util.RandomDecimal(0, 10000));
                    item.Category_Id = context.Category.OrderBy(x => Guid.NewGuid()).First().Id;
                    item.Description = GenerateRandomText(rand.Next(10, 20));
                    item.Supplier_Id = context.Supplier.OrderBy(x => Guid.NewGuid()).First().Id;
                    item.Stock = rand.Next(0, 1000);
                    item.Image = (byte[])imgConverter.ConvertTo(images[rand.Next(0, images.Count - 1)], typeof(byte[]));
                    context.Item.Add(item);
                    context.SaveChanges();
                }
            }
        }

        // Generate random categories
        private static void GenerateCategories(int amount = 4)
        {
            List<string> usedNames = new List<string>();
            for (int i = 0; i < amount; i++)
            {
                using (var context = new ShopmsEntities())
                {
                    Category category = new Category();
                    category.Name = GenerateRandomText(rand.Next(4, 8));
                    while(usedNames.Contains(category.Name)) // TODO: Add timeout
                        category.Name = GenerateRandomText(rand.Next(4, 8));
                    usedNames.Add(category.Name);
                    category.Description = GenerateRandomText(rand.Next(10, 30));
                    context.Category.Add(category);
                    context.SaveChanges();
                }
            }
        }

        // Generate random suppliers
        private static void GenerateSuppliers(int amount = 12)
        {
            for (int i = 0; i < amount; i++)
            {
                using (var context = new ShopmsEntities())
                {
                    Supplier supplier = new Supplier();
                    supplier.Name = GenerateRandomText(rand.Next(6, 10));
                    supplier.Address = rand.Next(0,101) > 50 ? GenerateRandomText(rand.Next(8, 15)) + " " + rand.Next(1, 50) : "";
                    supplier.Zipcode = rand.Next(0, 101) > 50 ? GenerateRandomText(4).ToUpper() : "";
                    context.Supplier.Add(supplier);
                    context.SaveChanges();
                }
            }
        }

        // Generate random customers
        private static void GenerateCustomers(int amount = 120)
        {
            for (int i = 0; i < amount; i++)
            {
                using (var context = new ShopmsEntities())
                {
                    Customer customer = new Customer();
                    customer.Name = GenerateRandomText(rand.Next(4,8)) + " " + GenerateRandomText(rand.Next(4, 8));
                    customer.Address = GenerateRandomText(rand.Next(8, 15)) + " " + rand.Next(1, 50);
                    customer.Zipcode = GenerateRandomText(4).ToUpper();
                    customer.Phone = rand.Next(0, 101) > 50 ? GenerateRandomText(10, true) : "";
                    context.Customer.Add(customer);
                    context.SaveChanges();
                }
            }
        }

        // Generate random orders
        private static void GenerateOrders(int amount = 50)
        {
            for (int i = 0; i < amount; i++)
            {
                using (var context = new ShopmsEntities())
                {
                    Order order = new Order();
                    order.Customer_Id = context.Customer.OrderBy(x => Guid.NewGuid()).First().Id;
                    order.Date = new DateTime(rand.Next(2001, 2080), rand.Next(1,12), rand.Next(1, 28));
                    context.Order.Add(order);
                    context.SaveChanges();
                }
            }
        }

        // Generate random order rules
        private static void GenerateOrderrules(int amount = 50)
        {
            for (int i = 0; i < amount; i++)
            {
                using (var context = new ShopmsEntities())
                {
                    Orderrule rule = new Orderrule();
                    rule.Item_Id = context.Item.AsEnumerable().OrderBy(x => Guid.NewGuid()).First().Id;
                    rule.Order_Id = context.Order.AsEnumerable().OrderBy(x => Guid.NewGuid()).First().Id;
                    context.Orderrule.Add(rule);
                    context.SaveChanges();
                }
            }
        }

        // Generate random item names
        private static string GenerateRandomText(int textLength = 8, bool numbers = false)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            const string nums = "1234567890";

            string name = "";
            for (int i = 0; i < textLength; i++)
            {
                if(!numbers)
                    name += chars[rand.Next(0, chars.Length)];
                else
                    name += nums[rand.Next(0, nums.Length)];
            }

            return name;
        }
    }
}
