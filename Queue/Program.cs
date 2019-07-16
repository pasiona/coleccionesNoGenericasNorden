using System;
using System.Collections;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            // La Queue funciona de manera first-in, first-out (primero en entrar, primero en salir)
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Cuatro");

            //Recorrer la pila
            Console.WriteLine("Queue recorrida:\n");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Devuelve el primero pero no lo quita
            Console.WriteLine("\nPrimer elemento pero sin quitarlo:\n");
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());

            Console.WriteLine("\nPrimer elemento pero quitándolo:\n");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine("\nImpresión de true o false si existe o no el elemento:\n");
            Console.WriteLine(queue.Contains("Cuatro"));

            Console.WriteLine("\nElementos totales de la queue:\n");
            Console.WriteLine(queue.Count);
        }
    }
}
