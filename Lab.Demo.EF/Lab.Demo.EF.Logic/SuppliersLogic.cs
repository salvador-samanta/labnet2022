using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class SuppliersLogic : BaseLogic
    {
        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }
    }
}
