using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class Calc<T>: ICalc<T>
    {
        public T Division(T valor1, T valor2)
        {
            return (dynamic)valor1 / valor2;
        }

        public T Multiplicacion(T valor1, T valor2)
        {
            return (dynamic)valor1 * valor2;
        }

        public T Resta(T valor1, T valor2)
        {
            return (dynamic)valor1 - valor2;
        }

        public T Suma(T valor1, T valor2 )
        {
            return (dynamic)valor1 + valor2;
        }
    }
}
