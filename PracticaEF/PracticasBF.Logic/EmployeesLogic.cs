using PracticaBF.Data;
using PracticaBF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PracticasBF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }
        public void add(Employees newEmployees)
        {
            try
            {
                context.Employees.Add(newEmployees);

                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Delete(int id)
        {
            try
            { 
                var employeesEliminar = context.Employees.Find(id);

                context.Employees.Remove(employeesEliminar);
              
                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Employees employees)
        {
            try
            {
                var employeesupdate = context.Employees.Find(employees.EmployeeID);

                employeesupdate.Title = employees.Title;
                
                context.SaveChanges();
            }
            catch (NullReferenceException)
            {
                throw;
            }
        }

        public Employees GetOne(int id)
        {
            return context.Employees.Find(id);
        }

    }
}
