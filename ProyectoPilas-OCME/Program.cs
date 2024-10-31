using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoPilas_OCME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamaño = 10;
            pila Lista = new pila(tamaño);// la pila empieza con 10
            int opcion;
            do
            {
                
                // Menú de selección
                Console.WriteLine("Menu Pilas");
                Console.WriteLine("|---------------------------------|");
                Console.WriteLine("|1.- establecer tamaño            |");
                Console.WriteLine("|2.- Push                         |");
                Console.WriteLine("|3.- Pop                          |");
                Console.WriteLine("|4.- Imprimir                     |");
                Console.WriteLine("|5.- Salir                        |");
                Console.WriteLine("|Seleccionar opcion =>            |");
                Console.WriteLine("|---------------------------------|");

                // Validación de la opción ingresada
                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 5.");
                    Console.Write("Seleccione una opción: ");
                }

                switch (opcion)//switch de casos
                {

                    case 1: // establecer tamaño
                        Console.Write("Ingrese el nuevo tamaño máximo: ");
                        tamaño = Convert.ToInt32(Console.ReadLine());
                       
                            Console.WriteLine("Nuevo tamaño establecido");
                        
                        break;
                    case 2: // push
                        Console.Write("Ingrese el número a insertar en la pila: ");
                        int num;
                        if (int.TryParse(Console.ReadLine(), out num))
                        {
                            if (Lista.Push(num))
                            {
                                Console.WriteLine("Número insertado correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("La pila está llena, no se pudo insertar el número.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Por favor, ingrese un número válido.");
                        }
                        break;
                    case 3: // pop
                        int valorPop = Lista.Pop();
                        if (valorPop != -1)
                        {
                            Console.WriteLine($"Número sacado de la pila: {valorPop}");
                        }
                        else
                        {
                            Console.WriteLine("La pila está vacía, no se puede sacar un número.");
                        }
                        break;
                    case 4: // imprimir
                        Lista.PrintStack();
                        break;

                    case 5: // Salir
                        Console.WriteLine("Saliendo del programa...");
                        break;
                }
                Console.WriteLine();
            } while (opcion != 5); // Salir si se termina el programa
        }
    }
}