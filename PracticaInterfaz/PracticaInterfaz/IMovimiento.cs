using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInterfaz
{
    internal interface IMovimiento
    {
        void correr();
        void caminar();
        void parar();
    }
}
