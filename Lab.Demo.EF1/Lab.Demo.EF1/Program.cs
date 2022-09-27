using Lab.Demo.EF1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF1.Logic;

namespace Lab.Demo.EF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();

            foreach (Categories categories in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{categories.CategoryID} - {categories.CategoryName} - {categories.Description}");
            }
            Console.ReadKey();
        }
    }
}
