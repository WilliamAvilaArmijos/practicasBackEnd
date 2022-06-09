using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class ejecutarLlenaObjetos
    {
        public static void Main(string[] args)
        {
            ArrayList<string> arrayList = new ArrayList<string>(2);
            arrayList.agregarElemento("Juan");
            arrayList.agregarElemento("Maria");
            arrayList.agregarElemento("Manuel");
            arrayList.agregarElemento("Luis");
            Console.WriteLine(arrayList.obtenerElemento(1));
        }
    }
}
