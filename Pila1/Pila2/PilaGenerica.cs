using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila2
{

    class PilaGenerica<TEntity>
    {

        /*
         * EN ESTÁ SECCIÓN SE MUESTRA EL ALGORITMO CON LAS OPERACIONES BÁSICAS DE PILAS
         */

        /*
         * La variable 'BAND' representa si la pila está llena
         * o vacía, por eso su valor será true (VERDADERO) o false (FALSO)
         */
        Boolean BAND;


        /*
         * La variable 'MAX' es el tamaño máximo que puede
         * tener la PILA. El valor se definirá en el constructor de esta clase.
         */
        int MAX;


        /*
         * La variable 'TOPE' representa la cantidad de
         * elementos almacenados en la PILA. Si este es
         * 0 significa que la PILA está vacía y si es
         * igual que MAX significa que la PILA está llena
         */
        int TOPE = 0;


        /*
         * El arreglo unidimensional 'PILA' es el que
         * almacenará los valores de la PILA. Y se le
         * asigna un tamaño MAX (que por defecto se estableció en 10)
         */
        TEntity[] PILA;


        /*
         * El papel que juega está propiedad, llamada 'Instance',
         * es para que se pueda acceder desde el exterior a la PILA.
         */
        public TEntity[] Instance { get { return PILA; } }


        /*
         * El constructor de la clase permitirá iniciar el MAX y la PILA.
         */
        public PilaGenerica(int maximoElementos)
        {
            MAX = maximoElementos;
            PILA = new TEntity[MAX];
        }


        /*
         * El método 'PilaVacia' es una de las operaciones
         * auxiliares con PILAS. El objetivo de este es
         * establecer BAND en true (VERDADERO) si la pila
         * se encuentra vacía.
         */
        Boolean PilaVacia()
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
        Boolean PilaLlena()
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
        public void Pone(TEntity elemento)
        {

            PilaLlena();

            if (BAND == true)
            {
                throw new Exception("Desbordamiento - Pila Llena");
            }
            else
            {
                PILA[TOPE] = elemento;
                TOPE = TOPE + 1;
            }

        }


        /*
         * El método 'Quita' es una de las operaciones
         * básicas con PILAS. El objetivo de este es remover
         * un elemento de la parte superior de la PILA (siempre
         * que la PILA no este vacía).
         */
        public void Quita()
        {

            PilaVacia();

            if (BAND == true)
            {
                throw new Exception("Subdesbordamiento - Pila Vacía");
            }
            else
            {
                TOPE = TOPE - 1;
                TEntity DATO = PILA[TOPE];
                PILA[TOPE] = default(TEntity);
            }

        }

    }

}
