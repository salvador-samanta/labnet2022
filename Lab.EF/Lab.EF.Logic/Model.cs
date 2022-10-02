using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class Model : BaseLogic

    {
        CustomerLogic customerlogic = new CustomerLogic();
        ProductLogic productlogic = new ProductLogic();
        //ejercicio 1:
        public void Customers()
        {
            foreach (Customers customer in customerlogic.CustomerList())
            {
                Console.WriteLine($"{customer.CustomerID} - {customer.CompanyName} - {customer.ContactName}");


            }
        }

        //ejercicio 2:

        public void WithoutStock()
        {
            foreach (Products product in productlogic.ProductsWithoutStock())
            {
                Console.WriteLine($"{product.ProductName}");
            }
        }

        //ejercicio 3:

        public void MoreThan3()
        {
            ProductLogic productlogic = new ProductLogic();

            foreach (Products product in productlogic.ProductsMoreThan3())
            {
                Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            }
        }

        //ejercicio 4:
        public void AllWACustomers()
        {
            foreach (Customers customer in customerlogic.CustomersFromWA())
            {
                Console.WriteLine($"{customer.CustomerID} - {customer.CompanyName} - {customer.ContactName}");

                Console.ReadKey();
            }
        }

        //ejercicio 5:
        public void Id789()
        {

            ProductLogic productlogic = new ProductLogic();
            if (productlogic.ProductId789() == null)
            {
                Console.WriteLine("null");
            }

        }


        //ejercicio 6:
        public void CustomersNames()
        {
            CustomerLogic customerLogic = new CustomerLogic();
            foreach (Customers customer in customerLogic.CustomerList())
            {
                Console.WriteLine($"{customer.ContactName.ToUpper()} - {customer.ContactName.ToLower()}");

            }
        }



        //ejercicio 7:
        public void OrderAndCustomer()
        {
            var date = new DateTime(1997, 01, 01);

            var orderAndCustomer = from customers in context.Customers
                                   join order in context.Orders on
                                   customers.CustomerID equals order.CustomerID
                                   where customers.Region == "WA"
                                   && order.OrderDate > date
                                   orderby order.OrderDate
                                   select new { customers, order };

            foreach (var item in orderAndCustomer)
            {
                Console.WriteLine($"{item.customers.CompanyName} - {item.customers.Region} - {item.order.OrderDate}");
            }
        }

        //ejercicio 8:
        public void FirstThreeCustomersWA()
        {
            foreach (var item in customerlogic.Primeros3())
            {
                Console.WriteLine($"{item.CompanyName} - {item.Region}");
            }
        }

        //ejercicio 9:

        public void OrderedByNameProducts()
        {
            foreach (var item in productlogic.ProductsOrderByName())
            {
                Console.WriteLine($"{item.ProductName}");
            }
        }

        //ejercicio 10:

        public void OrderedByStockProducts()
        {
            foreach (var item in productlogic.ProductsOrderByStock())
            {
                Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            }
        }


        //ejercicio 11:
        public void ProductsCategories()
        {
            var productscategories = from categories in context.Categories
                                     join products in context.Products
                                     on categories.CategoryID equals products.CategoryID
                                     select new { categories, products };

            foreach (var item in productscategories)
            {
                Console.WriteLine($"{item.categories.CategoryName} - {item.products.ProductName}");
            }

        }

        //ejercicio 12:

        public void FirstProductOfTheList()
        {
            Console.WriteLine(productlogic.FirstProduct().ProductName);
        }



    }
}
