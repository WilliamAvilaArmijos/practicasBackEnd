using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaInterfaz
{
    class Carro : ITransporte
    {
        public Carro()
        {
            km = 100;
            grados = 90;
        }

        double km { get; set; }
        double grados { get; set; }
        public void acelerar()
        {
            Console.WriteLine("El carro tiene un aceleracion de: " + km + "km/h");
        }

        public void frenar()
        {
            Console.WriteLine("El carro puede frenar");
        }

        public void girar()
        {
            Console.WriteLine("El carro tiene un angulo de giro de: " + grados + " grados ");
        }
    }
}
