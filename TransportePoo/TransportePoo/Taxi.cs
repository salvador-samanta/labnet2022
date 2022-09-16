using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePoo
{
    public class Taxi : TransportePublico
    {
        public Taxi(int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }

        public override string pasajeros()
        {
            return string.Format($"Taxi: {getCantidadPasajeros()}");
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
