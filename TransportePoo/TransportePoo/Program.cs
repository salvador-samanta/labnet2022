 using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuTransporte = 0;
            Console.WriteLine("Hola! elegí una opción para ingresar la cantidad de pasajeros:\n1 Taxi\n2 Omnibuis");
            menuTransporte = Convert.ToInt32(Console.ReadLine());
            int respuesta = 0;
            switch (menuTransporte)
            {
                case (1):
                    Console.WriteLine("Elegiste Taxi, por favor ingresá 5 numeros de pasajeros:\n");
                    respuesta = 1;
                    break;
                case (2):
                    Console.WriteLine("Elegiste Omnibus, por favor ingresá 5 numeros de pasajeros:\n");
                    respuesta = 2;
                    break;
                default:
                    Console.WriteLine("Ingresaste un carácter incorrecto");
                    break;


            }
            if (respuesta == 1)
                {
                List<Taxi> taxi = new List<Taxi>
                {
                new Taxi(Convert.ToInt32(Console.ReadLine())),
                new Taxi(Convert.ToInt32(Console.ReadLine())),
                new Taxi(Convert.ToInt32(Console.ReadLine())),
                new Taxi(Convert.ToInt32(Console.ReadLine())),
                new Taxi(Convert.ToInt32(Console.ReadLine())),
                };

                foreach (var i in taxi)
                {
                    Console.WriteLine(i.pasajeros());
                }

            }

            else if (respuesta == 2)
            {
                List<Omnibus> omnibus = new List<Omnibus>
                {
                new Omnibus(Convert.ToInt32(Console.ReadLine())),
                new Omnibus(Convert.ToInt32(Console.ReadLine())),
                new Omnibus(Convert.ToInt32(Console.ReadLine())),
                new Omnibus(Convert.ToInt32(Console.ReadLine())),
                new Omnibus(Convert.ToInt32(Console.ReadLine())),
                };


                foreach (var i in omnibus)
                {
                    Console.WriteLine(i.pasajeros());
                }
            }



            Console.ReadKey();
        }

    }
}
