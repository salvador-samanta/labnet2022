using Lab.Demo.EF1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF1.Logic
{
    public class SuppliersLogic : BaseLogic, IABMLogic<Suppliers>
    {
        public void add(Suppliers nerSupplier)
        {
            throw new NotImplementedException();
        }
        public List<Suppliers> GetAll()
        {
            return context.Suppliers.ToList();
        }


        public void Delete(int id)
        {
            try {          
            var supplierAEliminar = context.Suppliers.Find(id);

            context.Suppliers.Remove(supplierAEliminar);
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

        public void Update (Suppliers suppliers)
        {
            throw new NotImplementedException();
        }

        
    }
}
