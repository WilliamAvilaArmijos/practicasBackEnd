using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaInterfaz
{
    class Bote
    {
        
        public string Acelerar(string nudo)
        {
            return "La velocidad en nudos es" + nudo;
        }

        public string Acelerar(string nudo, string grados)
        {
            return Acelerar(nudo + "el angulo de giro es " + grados);
        }
    }
}
