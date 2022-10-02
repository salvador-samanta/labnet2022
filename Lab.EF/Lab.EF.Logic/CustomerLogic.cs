using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomerLogic : BaseLogic
    {

        public List<Customers> CustomerList()
        {
            var queryAllCustomers = from customers in context.Customers
                                    select customers;

            return queryAllCustomers.ToList();

        }


        public List<Customers> CustomersFromWA()
        {
            var queryCustomersFromWA = from customers in context.Customers
                                       where customers.Region == "WA"
                                       select customers;


            return queryCustomersFromWA.ToList();

        }

        public List<Customers> Primeros3()
        {
            var query3customers = context.Customers.Where(r => r.Region == "WA").Take(3);
            return query3customers.ToList();

        }



    }
}
