using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionMethods
{
    public class Logic
    {
        public static void EsPar(int numero)
        {

            if (numero % 2 == 0)
            {
                Console.WriteLine("Es par.");
            }

            else
            {
                throw new NoEsParException();

            }
        }
    }
}
