using Lab.Demo.EF.Data;
//using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            //int num1 = 1, num2 = 2;
            //List<lista> list = new List<lista>();
            //{
            //    num1 = 1;
            //    num2 = 2;
            //};
            //foreach (item in lista){
            //    Console.WriteLine(item.Lista());
            //}



            CategoriesLogic categoriesLogic = new CategoriesLogic();

            foreach (Categories categories in categoriesLogic.GetAll())
            {
                Console.WriteLine("Hola.");
                Console.WriteLine($"{categories.CategoryID} - {categories.CategoryName} - {categories.Description}");
            }

            Console.ReadLine();



            SuppliersLogic suppliersLogic = new SuppliersLogic();

            foreach (Suppliers supliers in suppliersLogic.GetAll())
            {
                Console.WriteLine("Holi");
                Console.WriteLine($"{supliers.SupplierID} - {supliers.CompanyName} - {supliers.ContactName} - {supliers.ContactTitle} - {supliers.Address} - {supliers.City} - ");
            }

            Console.ReadLine();
        }
}
}
