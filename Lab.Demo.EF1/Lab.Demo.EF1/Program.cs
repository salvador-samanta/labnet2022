using Lab.Demo.EF1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Demo.EF1.Logic;
using System.Net;
using System.Security.Policy;

namespace Lab.Demo.EF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intermedia categoriesIntermedia = new Intermedia();
            Intermedia.SuppliersIntermedia suppliersIntermedia = new Intermedia.SuppliersIntermedia();
            
            int menu = 0;
            int salida = 0;



            try
            {
                do
                {
                    Console.WriteLine("\nHola! ingresá el número de lo que quieras hacer:\r\n\n" +
                        "                        \"Categorías:\r\n" +
                        "                        \"1. Ver las categorías disponibles\r\n" +
                        "                        \"2. Añadir una nueva categoría\r\n" +
                        "                        \"3. Eliminar alguna categoría\r\n" +
                        "                        \"4. Modificar alguna categoría\r\n\n" +
                        "                        \"Proveedores:\r\n" +
                        "                        \"5. Ver los proveedores actuales\r\n" +
                        "                        \"6. Añadir un nuevo proveedor\r\n" +
                        "                        \"7. Eliminar algun proveedor\r\n" +
                        "                        \"8. Salir");

                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.Clear();
                            categoriesIntermedia.categoriesList();
                            break;


                        case 2:
                            Console.Clear();
                            categoriesIntermedia.categoriesList();

                            Console.WriteLine("\n\nIngrese el ID de la nueva categoría: ");
                            int idIngresada = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese el nombre de la nueva categoría: ");
                            string nombreIngresado = (Console.ReadLine());

                            Console.WriteLine("Ingrese la descripción de la nueva categoría: ");
                            string descripcionIngresada= (Console.ReadLine());

                            categoriesIntermedia.addCategories(idIngresada, nombreIngresado, descripcionIngresada);
                            Console.Clear();

                            Console.WriteLine("Gracias por añadir una categoría, esta es la lista actualizada:\n");

                            categoriesIntermedia.categoriesList();

                            break;


                        case 3:
                            Console.Clear();
                            categoriesIntermedia.categoriesList();

                            Console.Write("\nIngrese el ID de la categoría que desea eliminar: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            categoriesIntermedia.Delete(id);
                            Console.Clear();
                            Console.WriteLine("Gracias por eliminar una categoría, esta es la lista actualizada:\n");
                            categoriesIntermedia.categoriesList();

                            break;


                        case 4:
                            Console.Clear();

                            categoriesIntermedia.categoriesList();

                            Console.Write("\nIngrese el ID de la categoría que desée modificar: \n");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese el nombre: \n");
                            string CategoryName = Console.ReadLine();
                            Console.Write("Ingrese la descripción: \n");
                            string descripcion = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine($"Gracias por modificar una categoría, esta es la lista actualizada:\n");
                            categoriesIntermedia.categoriesList();

                            break;



                        case 5:
                            Console.Clear();

                            suppliersIntermedia.suppliersList();

                            break;


                        case 6:
                            Console.Clear();

                            suppliersIntermedia.suppliersList();

                            Console.WriteLine("\n\nIngrese el ID del nuevo proveedor: ");
                            int idSIngresada = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese la compañía del nuevo proveedor: ");
                            string compañiaIngresada = (Console.ReadLine());

                            Console.WriteLine("Ingrese la dirección del nuevo proveedor: ");
                            string direccionIngresada = (Console.ReadLine());

                            suppliersIntermedia.addSuppliers(idSIngresada, compañiaIngresada, direccionIngresada);
                            Console.Clear();

                            Console.WriteLine("Gracias por añadir un proveedor, esta es la lista actualizada:\n");

                            suppliersIntermedia.suppliersList();

                            break;

                        case 7:
                            Console.Clear();
                            suppliersIntermedia.suppliersList();

                            Console.Write("\nIngrese el ID del proveedor que desea eliminar: ");
                            id = Convert.ToInt32(Console.ReadLine());

                            suppliersIntermedia.Delete(id);

                            Console.Clear();
                            Console.WriteLine("Gracias por eliminar un proveedor, esta es la lista actualizada:\n");
                            suppliersIntermedia.suppliersList();


                            break;

                        case 8:
                            salida = 1;
                            break;

                        default:
                            Console.WriteLine("Ups!! parece que ingresaste una opción incorrecta!\n\n");
                            break;

                    }
                }
                while (salida == 0);
                { 
                    Console.WriteLine("Gracias por corregir :D");
                        
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("¡La respuesta tenía que ser sólo con números!");
            }

            Console.Read();


        }
    }
}
