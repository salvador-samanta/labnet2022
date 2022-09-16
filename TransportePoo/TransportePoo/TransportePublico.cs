using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePoo
{
    public abstract class TransportePublico
    {
        private int cantidadPasajeros;
        public int getCantidadPasajeros()
        {
            return cantidadPasajeros;
        }

        public TransportePublico (int cantidadPasajeros)
        {
            this.cantidadPasajeros = cantidadPasajeros; 
        }

        public abstract string Avanzar();
        public abstract string Detenerse();

        public abstract string pasajeros();
    }

}
