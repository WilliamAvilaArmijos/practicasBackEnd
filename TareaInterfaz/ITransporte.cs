using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaInterfaz
{
    interface ITransporte
    {
        void acelerar();
        void frenar();
        void girar();
    }
    interface ITransporteAereo : ITransporte
    {
        void despegar();
        void aterrizar();
    }
}
