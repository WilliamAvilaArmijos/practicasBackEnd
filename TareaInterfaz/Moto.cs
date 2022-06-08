using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaInterfaz
{
    class Moto : ITransporte
    {
        public Moto()
        {
            km = 60;
            grados = 30;
        }

        double km { get; set; }
        double grados { get; set; }
        public void acelerar()
        {
            Console.WriteLine("La moto tiene un aceleracion de: " + km + "km/h");
        }

        public void frenar()
        {
            Console.WriteLine("La moto puede frenar");
        }

        public void girar()
        {
            Console.WriteLine("La moto tiene un angulo de giro de: " + grados + " grados ");
        }
    }
}
