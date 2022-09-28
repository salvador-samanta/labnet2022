using Lab.Demo.EF1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF1.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public List <Categories> GetAll()
        {
            return context.Categories.ToList();
        }
        public void add(Categories newCategory)
        {
            context.Categories.Add(newCategory);
            context.SaveChanges();
        }
        

        public void Delete(int id)
        {
            try
            {
                var categoriesAEliminar = context.Categories.Find(id);

                context.Categories.Remove(categoriesAEliminar);

                context.SaveChanges();
            }

            catch (InvalidOperationException)
            {
                Console.WriteLine("Intentalo otra vez! pero con un id válido.");
                Console.ReadLine();
            }

            catch (Exception)
            {
                Console.WriteLine("Ups! parece que ha habido un error.");
                Console.ReadLine();
            }
        }

        public void Update(Categories categories)
        {
            var categoriesUpdate = context.Categories.Find(categories.CategoryID);

            categoriesUpdate.CategoryName = categories.CategoryName;

            context.SaveChanges();
        }

        
    }
}
