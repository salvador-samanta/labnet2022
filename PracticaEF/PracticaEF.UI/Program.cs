using PracticaBF.Entities;
using PracticasBF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomersIntermedia customersIntermedia = new CustomersIntermedia();
            EmployeesIntermedia employeesIntermedia = new EmployeesIntermedia();

            int continuar;
            do
            {

                try
                {
                    Console.WriteLine("Ingrese 1 para dar de alta un nuevo empleado\nIngrese 2 para dar de baja un empleado\nIngrese 3 para promover un empleado\nIngrese 4 para consultar lista de empleados\nIngrese 5 para consultar la lista de clientes");
                    Console.WriteLine();
                    int seleccion = int.Parse(Console.ReadLine());

                    switch (seleccion)
                    {
                        case 1:

                            Console.Clear();

                            employeesIntermedia.emplooyesList();

                            Console.Write("Ingrese ID del nuevo empleado: ");
                            int num1 = int.Parse(Console.ReadLine());

                            Console.Write("Ingre nombre del nuevo empeado: ");
                            string string1 = Console.ReadLine();

                            Console.Write("Ingrese apellido del nuevo empleado: ");
                            string string2 = Console.ReadLine();

                            Console.Write("Ingrese puesto del nuevo empleado: ");
                            string string3 = Console.ReadLine();

                            employeesIntermedia.addEmployees(num1, string1, string2, string3);
                            
                            Console.Clear();

                            Console.WriteLine("El empleado a sido dado de alta");

                            employeesIntermedia.emplooyesList();

                        break;

                        case 2:
                            
                            Console.Clear();

                            employeesIntermedia.emplooyesList();

                            Console.Write("Ingrese el ID del empleado que desea dar de baja: ");
                            int num2 = int.Parse(Console.ReadLine());

                           
                            employeesIntermedia.Delete(num2);

                            Console.Clear();

                            Console.WriteLine($"El empleado con el id: {num2} ha sido dado de baja con exito\n");

                            employeesIntermedia.emplooyesList();
                        
                        break;

                        case 3:
                            Console.Clear();

                            employeesIntermedia.emplooyesList();

                            Console.Write("Ingrese el ID del empleado al que desea promover: ");
                            int num3 = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese el puesto al que desea promoverlo: ");
                            string string4 = Console.ReadLine();

                            employeesIntermedia.updateEmployees(string4, num3);

                            Console.Clear();

                            Console.WriteLine($"El empleado con el id: {num3} ha sido promovido con exito\n");

                            employeesIntermedia.emplooyesList();


                        break;

                        case 4:
                            
                            Console.Clear();
                            employeesIntermedia.emplooyesList();
                            
                        break;
                           
                        case 5:

                            Console.Clear();
                            customersIntermedia.customersList();

                        break;

                        default:

                            Console.WriteLine("Ingreso un valor incorrecto");
                        
                        break;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Solo numeros por favor...");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine();

                    Console.WriteLine("El empleado seleccionado no existe");
                }

                catch (Exception)
                {
                    Console.WriteLine("\nUPS!! Debe haber ocurrido un problema con uso de llaves foreaneas");
                }

                Console.WriteLine();

                Console.WriteLine("Ingrese 1 para cotinuar - Ingrese 0 para salir");
                continuar = int.Parse(Console.ReadLine());

                Console.Clear();
            }
            while (continuar != 0);
        }
    }
}
