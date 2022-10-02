using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ProductLogic : BaseLogic
    {
        public bool productsId789 { get; set; }

        public List<Products> ProductsWithoutStock()
        {
            var productsWithoutStock = from products in context.Products
                                       where products.UnitsInStock == 0
                                       select products;


            return productsWithoutStock.ToList();

        }

        public List<Products> ProductsMoreThan3()
        {
            var productsValeMasDe3 = from products in context.Products
                                     where products.UnitPrice > 3
                                     && products.UnitsInStock > 0
                                     orderby products.UnitPrice ascending
                                     select products;


            return productsValeMasDe3.ToList();

        }

        public Products ProductId789()
        {

            var productsId789 = context.Products.First(p => p.ProductID == 789);

            return productsId789;
        }


        public List<Products> ProductsOrderByName()
        {
            var productsOrderByName = from products in context.Products
                                      orderby products.ProductName
                                      select products;

            return productsOrderByName.ToList();
        }

        public List<Products> ProductsOrderByStock()
        {
            var productsOrderByName = context.Products.OrderByDescending(p => p.UnitsInStock);

            return productsOrderByName.ToList();
        }

        public Products FirstProduct()
        {

            var firstProduct = context.Products.First();

            return firstProduct;
        }

    }
}
