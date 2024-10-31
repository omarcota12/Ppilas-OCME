using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProyectoPilas_OCME.Nodo;

namespace ProyectoPilas_OCME
{
    internal class pila
    {
        private int MAX;
        private int tope = 0;
        private nodo inicio;

        public pila(int max)
        {
            MAX = max;
            inicio = null;
        }
        public bool empty()
        {
            if (inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Full()
        {
            if (tope == MAX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintStack()
        {
            //Imprime la pila
            if (empty())
            {
                Console.WriteLine("La pila esta vacia.");
                return;
            }

            nodo actual = inicio;
            Console.WriteLine("Contenido de la pila:");
            while (actual != null)
            {
                Console.WriteLine(actual.Valor);
                actual = actual.Sig;
            }

        }

        public bool Push(int num)
        {
            //regresa true si la insercion es exitosa
            //regresa false si la pila esta llena y no se inserto
            if (Full())
            {
                return false; // La pila esta llena
            }

            nodo nuevoNodo = new(num);
            nuevoNodo.Sig = inicio;
            inicio = nuevoNodo;
            tope++;
            return true; // Insercion exitosa
        }

        public int Pop()
        {
            //regresa el numero sacado de la pila
            //si la pila esta vacia regresa -1
            if (empty())
            {
                return -1; // La pila esta vacia
            }

            int valor = inicio.Valor;
            inicio = inicio.Sig;
            tope--;
            return valor; // Regresa el elemento sacado
        }
    
    }
}
