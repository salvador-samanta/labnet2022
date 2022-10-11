using PracticaBF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasBF.Logic
{
    public class EmployeesIntermedia : EmployeesLogic
    {
        EmployeesLogic employeesLogic = new EmployeesLogic();
 
        public void emplooyesList()
        {
            Console.WriteLine("-------empleados--------");
            foreach (Employees employees in employeesLogic.GetAll())
            {
                Console.WriteLine($"{employees.EmployeeID} - {employees.FirstName}, {employees.LastName} - {employees.Title} - {employees.HireDate}");
            }
            Console.WriteLine();
        }
        public void addEmployees(int num1, string string1, string string2, string string3)
        {
            try
            {
             
                employeesLogic.add(new Employees
                {
                    EmployeeID = num1,
                    FirstName = string1,
                    LastName = string2,
                    Title = string3,
                    HireDate = DateTime.Now,
                });
            }

            catch (Exception)
            {
                Console.WriteLine("\nUPS!! Ingresaste mal un dato, ingrese enter para continuar");
                Console.ReadKey();
            }
        }

        public void deleteEmployee(int id)
        {
            try
            {
            employeesLogic.Delete(id);

            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("El ID ingresado no corresponde a ningun empleado, ingrese enter para continuar");
                Console.ReadKey();
            }
        }

        
        public void updateEmployees(string puesto, int num3)
        {
            try
            {
                employeesLogic.Update(new Employees
                {
                    EmployeeID = num3,
                    Title = puesto,
                });
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No hay ningun empleado con ese ID, ingrese enter para continuar");
                Console.ReadKey();
            }
        }
    }
}
