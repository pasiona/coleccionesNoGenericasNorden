using System;
using System.Collections;

namespace CollectionHashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "ichi");
            ht.Add(2, "ni");
            ht.Add(3, "san");
            ht.Add(4, "yon");
            ht.Add(5, "go");
            ht.Add("roku", 6);

            // Recorremos utilizando las claves
            Console.WriteLine("Primer hashtable:\n");
            foreach (var key in ht.Keys)
            {
                Console.WriteLine("Key: " + key + ", Valor: " + ht[key]);
            }

            Hashtable ht2 = new Hashtable()
            {
                { 1, "ichi" },
                { 2, "ni" },
                { 3, "san" },
                { 4, "yon" },
                { 5, "go" },
                { "roku", 6 }
            };

            // Recorremos utlizando las claves
            Console.WriteLine("\nSegundo hashtable:\n");
            foreach (var key in ht2.Keys)
            {
                Console.WriteLine("Key: " + key + ", Valor: " + ht[key]);
            }

            // Elimina el valor con la key "roku"
            ht.Remove("roku");

            // Recorremos utlizando las claves
            Console.WriteLine("\nSegundo hashtable con un elemento eliminado:\n");
            foreach (var key in ht2.Keys)
            {
                Console.WriteLine("Key: " + key + ", Valor: " + ht[key]);
            }

            // Impresión de true o false si existe o no el valor o la key
            Console.WriteLine("\nImpresión de true o false si existe o no el valor o la key:\n");
            Console.WriteLine(ht.Contains(5));
            Console.WriteLine(ht.ContainsKey(5));
            Console.WriteLine(ht.ContainsValue("ichi"));
        }
    }
}
