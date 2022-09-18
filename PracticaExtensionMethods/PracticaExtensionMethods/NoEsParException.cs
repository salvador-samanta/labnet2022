using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExtensionMethods
{
    public class NoEsParException : Exception
    {
        public NoEsParException() : base("No es par.") { }

    }
}
