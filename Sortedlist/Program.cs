using System;
using System.Collections;

namespace Sortedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList1 = new SortedList();
            sortedList1.Add(2, "two");
            sortedList1.Add(3, "three");
            sortedList1.Add(1, "one");
            sortedList1.Add(4, "four");

            Console.WriteLine("Primera sortedlist:\n");
            foreach (var key in sortedList1.Keys)
            {
                Console.WriteLine("Key: " + key + ", Valor: " + sortedList1[key]);
            }

            SortedList sortedList2 = new SortedList();
            sortedList2.Add("one", 1);
            sortedList2.Add("two", 2);
            sortedList2.Add("three", 3);
            sortedList2.Add("four", 4);

            Console.WriteLine("\nSegunda sortedlist:\n");
            foreach (var key in sortedList2.Keys)
            {
                Console.WriteLine("Key: " + key + ", Valor: " + sortedList2[key]);
            }

            SortedList sortedList3 = new SortedList();
            sortedList3.Add(1.5, 100);
            sortedList3.Add(3.5, 200);
            sortedList3.Add(2.4, 300);
            sortedList3.Add(2.3, 400);

            Console.WriteLine("\nTercera sortedlist:\n");
            foreach (var key in sortedList3.Keys)
            {
                Console.WriteLine("Key: " + key + ", Valor: " + sortedList3[key]);
            }

            SortedList sortedList4 = new SortedList()
            {
                {"Three", 3},
                {"Four", 4},
                {"One", 1},
                {"Five", 5},
                {"Two", 2}
            };

            Console.WriteLine("\nCuarta sortedlist:\n");
            foreach (var key in sortedList4.Keys)
            {
                Console.WriteLine("Key: " + key + ", Valor: " + sortedList4[key]);
            }

            // Elimina el elemento con la key "Five"
            sortedList4.Remove("Five");

            // Elimina el elemento 0 (elimina por índice)
            sortedList4.RemoveAt(0);

            Console.WriteLine("\nCuarta sortedlist con elementos eliminados:\n");
            foreach (var key in sortedList4.Keys)
            {
                Console.WriteLine("Key: " + key + ", Valor: " + sortedList4[key]);
            }

            Console.WriteLine("\nImpresión de true o false si existe o no el valor o la key:\n");
            Console.WriteLine(sortedList4.Contains("Three"));
            Console.WriteLine(sortedList4.Contains("Six"));
            Console.WriteLine(sortedList4.Contains("Two"));

            Console.WriteLine(sortedList4.ContainsKey("Three"));
            Console.WriteLine(sortedList4.ContainsKey("One"));

            Console.WriteLine(sortedList4.ContainsValue(6));
            Console.WriteLine(sortedList4.ContainsValue(1));
        }
    }
}
