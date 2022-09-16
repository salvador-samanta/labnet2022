using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePoo
{
    public class Omnibus : TransportePublico
    {
        /*public Omnibus()
        {
        }*/

        public Omnibus (int cantidadPasajeros) : base(cantidadPasajeros)
        {
            
        }

        public override string pasajeros()
        {
            return string.Format($"Omnibus: {getCantidadPasajeros()}");
        }

        public override string Avanzar()
        {
            throw new NotImplementedException();
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
