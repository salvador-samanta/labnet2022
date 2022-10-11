using PracticaBF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasBF.Logic
{
    public class CustomersIntermedia : CustomersLogic
    {
        CustomersLogic customerslogic = new CustomersLogic();

        public void customersList()
        {
            Console.WriteLine("-------clientes--------");
            foreach (Customers customers in customerslogic.GetAll())
            {
                Console.WriteLine($"{customers.CompanyName} - {customers.City} - {customers.Phone}");
            }
        }
    }
}
