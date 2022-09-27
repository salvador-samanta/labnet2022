using Lab.Demo.EF1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF1.Logic
{
    public class CategoriesLogic
    {
        private readonly NorthwindContext context;

        public CategoriesLogic()
        {
            context = new NorthwindContext();

        }

        public List <Categories> GetAll()
        {
            return context.Categories.ToList();
        }
    }
}
