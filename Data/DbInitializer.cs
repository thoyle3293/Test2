using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DiagonAlleyContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            
            // add customers
            var customers = new List<Customer>
            {
                new Customer { FirstName = "Harry", LastName = "Potter", Email = "harry.potter@gmail.com" },
                new Customer { FirstName = "Ron", LastName = "Weasley", Email = "ron.weasley@gmail.com" },
                new Customer { FirstName = "Hermione", LastName = "Granger", Email = "hermione.granger@yahoo.com" },
                new Customer { FirstName = "Draco", LastName = "Malfoy", Email = "draco.malfoy@hotmail.com" }
            };
            foreach (var customer in customers)
            {
                context.Customer.Add(customer);
            }
            context.SaveChanges();

            // add products
            var products = new List<Product>
            {
                new Product { Name = "wand", Description = "a magical device to cast spells", Price = 19.99M },
                new Product { Name = "caldron", Description = "a pot to brew potions", Price = 10.99M },
                new Product { Name = "chocolate frog", Description = "a tasty snack that might jump away", Price = 5.99M },
                new Product { Name = "robe", Description = "a part of the school uniform", Price = 49.99M }
            };
            foreach (var product in products)
            {
                context.Product.Add(product);
            }
            context.SaveChanges();

            // add orders
            var orders = new List<Order>
            {
                new Order { CustomerId = 1, ProductId = 1, Quantity = 1, OrderDate = new DateTime(2017, 1, 1) },
                new Order { CustomerId = 2, ProductId = 3, Quantity = 2, OrderDate = new DateTime(2017, 1, 1) },
                new Order { CustomerId = 3, ProductId = 2, Quantity = 1, OrderDate = new DateTime(2017, 1, 1) },
                new Order { CustomerId = 1, ProductId = 2, Quantity = 1, OrderDate = new DateTime(2017, 1, 1) }
            };
            foreach (var order in orders)
            {
                context.Order.Add(order);
            }
            context.SaveChanges();
        }
    }
}
