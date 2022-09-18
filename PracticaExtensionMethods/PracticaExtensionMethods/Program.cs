using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionMethods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int menu = 0;
            int salida = 0;



            try
            {
                do
                {
                    Console.WriteLine("\nHola! ingresá el número de lo que quieras hacer:\n" +
                        "1. Dividir número por cero(sólo para valientes)\n" +
                        "2. ¡Calculadora de divisiones!(es menos aterrador... ¡a menos que rompas algo!\n" +
                        "3. Descubrir si un número es par o impar.\n" +
                        "4. Salir");

                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Metodos.DivisionPorCero();

                            break;

                        case 2: //división
                            Metodos.Division();
                            break;

                        case 3: //ver si el número es par
                            try
                            {
                                Console.Write("Ingresá un número para saber si es par:");
                                int numero = Convert.ToInt32(Console.ReadLine());
                                Logic.EsPar(numero);
                            }
                            catch (NoEsParException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;

                        case 4: //salir

                            salida = 1;
                            break;

                        default:
                            Console.WriteLine("Ups!! parece que ingresaste una opción incorrecta!\n\n");
                            break;

                    }


                }
                while (salida == 0);
                Console.WriteLine("Gracias por corregir :D");
            }
            catch(FormatException)
            {
                Console.WriteLine("¡La respuesta tenía que ser sólo con números!");
            }

           
         
            Console.Read();


        } 



    }
}
