using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila3
{

    class Program
    {

        static void Main(string[] args)
        {

            
            Stack<int> pila = new Stack<int>(10);

            pila.Push(1);
            pila.Push(2);
            
            pila.Pop();
            
            var elementosDePila = pila;

            Console.ReadKey();

        }

    }

}
