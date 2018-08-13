using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila2
{

    class Program
    {

        static void Main(string[] args)
        {

            PilaGenerica<int> pila = new PilaGenerica<int>(10);

            pila.Pone(1);
            pila.Pone(2);
            pila.Quita();

            int[] elementosDePila = pila.Instance;

            Console.ReadKey();

        }

    }

}
