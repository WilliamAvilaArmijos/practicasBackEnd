using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class ArrayList<T>
    {
        private T[] conjunto;
        private int i;


        public ArrayList(int tamanio)
        {
            conjunto = new T[tamanio];
            this.i= 0;
        }
        public void agregarElemento(T objecto)
        {
            conjunto[i] = objecto;
            i++;
        }
        public T obtenerElemento(int posicion)
        {
            return conjunto[posicion];
        }
    }
}
