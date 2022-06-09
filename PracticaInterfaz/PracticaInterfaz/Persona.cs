using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInterfaz
{
  
    class Animal: IMovimiento
    {
        public Animal()
        {
            x = 0;
            y = 0;
        }
        int x { get; set; }
        int y { get; set; }
        public void caminar()
        {
            if (x == 100)
            {
                parar();
            }
            else
            {
                x += 1;
                y += 1;
                Console.WriteLine("Animal Caminando" + x);
            }
        }

        public void correr()
        {
            if (y == 100)
            {
                parar();
            }
            else
            {
                x += 5;
                y += 5;
                Console.WriteLine("Animal Corriendo" + y);
            }
        }

        public void parar()
        {
            Console.WriteLine("Se detuvo");
        }
    }
    class Persona : IMovimiento
    {
        private int _x;
        private int _y;

        public int x
        {
            get => _x;
            set => _x = value;
        }

        public int y
        {
            get => _y;
            set => _y = value;

        }

        public Persona(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Persona()
        {
        }

        public void caminar()
        {
            
            if (x==100)
            {
                parar();
            }
            else
            {
                x += 1;
                y += 1;
                Console.WriteLine("Persona Caminando" + x );
            }
            
        }

        public void correr()
        {
            if (y == 100)
            {
                parar();
            }
            else
            {
                x += 2;
                y += 2;
                Console.WriteLine("Persona Corriendo" + y);
            }
            
        }

        public void parar()
        {
            Console.WriteLine("Se detuvo");
        }
    }
}
