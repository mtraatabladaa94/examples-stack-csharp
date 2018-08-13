using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila1
{

    class Program
    {

        /*
         * El método 'Main' es la entrada principal de la aplicación
         * y la parte del código que se ejecuta al iniciar el programa.
         * Aquí se ejecutarán las pruebas de operaciones con PILAS.
         */
        static void Main(string[] args)
        {
            Pone();
            Pone();
            Quita();
            Quita();

            /*
             * Se añaden 10 elementos con 'Pone'.
             * Esto dejará llena la PILA.
             */
            Pone();
            Pone();
            Pone();
            Pone();
            Pone();
            Pone();
            Pone();
            Pone();
            Pone();
            Pone();

            Console.WriteLine("Se añadieron 10 elementos\nPresione una tecla para continuar");
            Console.WriteLine("Elementos: " + TOPE);
            Imprimir();
            Console.ReadKey();
            Console.Clear();

            /*
             * Se remueven 3 elementos con 'Quita'.
             * Esto dejará la PILA con 7 elementos.
             */
            Quita();
            Quita();
            Quita();

            Console.WriteLine("Se removieron 3 elementos\nPresione una tecla para continuar");
            Console.WriteLine("Elementos: " + TOPE);
            Imprimir();
            Console.ReadKey();
            Console.Clear();

            /*
             * Se añaden 4 elementos con 'Pone'.
             * Como ya hay 7 elementos y el máximo es de 10
             * la PILA al intentar añadir el último
             * elemento se desbordará.
             */
            Pone();
            Pone();
            Pone();
            Pone();

            Console.WriteLine("Se añadieron 4 elementos\nPero como ya había 7\ny el máximo es de 10 la PILA\nse desbordará en el último\nPresione una tecla para continuar");
            Console.WriteLine("Elementos: " + TOPE);
            Imprimir();
            Console.ReadKey();
            Console.Clear();

            /*
             * Se remueven 11 elementos con 'Quita'.
             * Como la PILA solo tiene 10 elementos
             * se subdesbordará
             */
            Quita();
            Quita();
            Quita();
            Quita();
            Quita();
            Quita();
            Quita();
            Quita();
            Quita();
            Quita();
            Quita();
            
            Console.WriteLine("Se removieron 11 elementos\npero como solo habían 10, de subdesbordó\nPresione una tecla para continuar");
            Console.WriteLine("Elementos: " + TOPE);
            Imprimir();
            Console.ReadKey();
            Console.Clear();

            Console.ReadKey();

        }

        /*
         * EN ESTÁ SECCIÓN SE MUESTRA EL ALGORITMO CON LAS OPERACIONES BÁSICAS DE PILAS
         */

        /*
         * La variable 'BAND' representa si la pila está llena
         * o vacía, por eso su valor será true (VERDADERO) o false (FALSO)
         */
        static Boolean BAND;


        /*
         * La variable 'MAX' es el tamaño máximo que puede
         * tener la PILA. En este caso la variable tiene un
         * valor predefinido de 10, que será el número
         * de valores que podrá almacenar la PILA
         */
        static int MAX = 10;


        /*
         * La variable 'TOPE' representa la cantidad de
         * elementos almacenados en la PILA. Si este es
         * 0 significa que la PILA está vacía y si es
         * igual que MAX significa que la PILA está llena
         */
        static int TOPE = 0;


        /*
         * El arreglo unidimensional 'PILA' es el que
         * almacenará los valores de la PILA. Y se le
         * asigna un tamaño MAX (que por defecto se estableció en 10)
         */
        static string[] PILA = new string[MAX];


        /*
         * El método 'PilaVacia' es una de las operaciones
         * auxiliares con PILAS. El objetivo de este es
         * establecer BAND en true (VERDADERO) si la pila
         * se encuentra vacía.
         */
        static Boolean PilaVacia()
        {

            if (TOPE == 0)
                BAND = true;
            else
                BAND = false;

            return BAND;

        }


        /*
         * El método 'PilaLena' es una de las operaciones
         * auxiliares con PILAS. El objetivo de este es
         * establecer BAND en false (FALSO) si la pila
         * se encuentra llena.
         */
        static Boolean PilaLlena()
        {

            if (TOPE == MAX)
                BAND = true;
            else
                BAND = false;

            return BAND;

        }



        /*
         * El método 'Pone' es una de las operaciones
         * básica con PILAS. El objetivo de este es insertar
         * un elemento en la parte superior de la PILA (siempre
         * que la PILA no este llena).
         */
        static void Pone()
        {

            PilaLlena();

            if (BAND == true)
            {
                Console.WriteLine("Desbordamiento - Pila Llena");
            }
            else
            {
                PILA[TOPE] = "■";
                TOPE = TOPE + 1;
            }

        }


        /*
         * El método 'Quita' es una de las operaciones
         * básicas con PILAS. El objetivo de este es remover
         * un elemento de la parte superior de la PILA (siempre
         * que la PILA no este vacía).
         */
        static void Quita()
        {

            PilaVacia();

            if (BAND == true)
            {
                Console.WriteLine("Subdesbordamiento - Pila Vacía");
            }
            else
            {
                TOPE = TOPE - 1;
                string DATO = PILA[TOPE];
                PILA[TOPE] = null;
            }

        }

        /*
         * El método 'Imprimir' mostrará los valores de la PILA en
         * pantalla.
         */
        static void Imprimir()
        {

            for (int i = 0; i < TOPE; i++)
            {

                Console.WriteLine( PILA[i] );

            }

        }

    }

}