using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public interface ICalc<T>
    {
        T Suma (T valor1, T valor2);
        T Resta(T valor1, T valor2);
        T Multiplicacion(T valor1, T valor2);
        T Division(T valor1, T valor2);


    }
}
