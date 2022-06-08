using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaInterfaz
{
    class Avion : ITransporteAereo
    {
        public Avion()
        {
            km = 200;
            grados = 120;
        }

        double km { get; set; }
        double grados { get; set; }

        public void acelerar()
        {
            Console.WriteLine("El avion tiene un aceleracion de: " + km + "km/h");
        }

        public void aterrizar()
        {
            Console.WriteLine("El avion puede aterrizar");
        }

        public void despegar()
        {
            Console.WriteLine("El avion puede despegar");
        }

        public void frenar()
        {
            Console.WriteLine("El avion puede frenar");
        }

        public void girar()
        {
            Console.WriteLine("El avion tiene un angulo de giro de: " + grados + " grados ");
        }
    }
}
