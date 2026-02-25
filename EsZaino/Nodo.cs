using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsZaino
{
    internal class Nodo<T>
    {
        public T Valore;
        public Nodo<T> Destra;
        public Nodo<T> Sinistra;

        public Nodo(T valore)
        {
            Valore = valore;
            Destra = null;
            Sinistra = null;
        }

    }
}
