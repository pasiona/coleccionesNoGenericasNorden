using System;
using System.Collections;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            // El stack funciona de manera last-in-first-out (último en entrar, primero en salir)
            Stack stack = new Stack();
            stack.Push("Mansana");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Recorrer el stack
            Console.WriteLine("Stack recorrido:\n");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // Devuelve el último pero no lo quita
            Console.WriteLine("\nÚltimo elemento pero sin quitarlo:\n");
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());

            // Devuelve el último y lo quita
            Console.WriteLine("\nÚltimo elemento pero quitándolo:\n");
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            // Ver si existe un elemento
            Console.WriteLine("\nImpresión de true o false si existe o no el elemento:\n");
            Console.WriteLine(stack.Contains("Platano"));
            Console.WriteLine(stack.Contains("Mansana"));

            // Cuenta cuantos elementos hay
            Console.WriteLine("\nElementos totales del stack:\n");
            Console.WriteLine(stack.Count);
        }
    }
}
