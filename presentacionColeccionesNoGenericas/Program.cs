using System;
using System.Collections;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAYLIST

            ArrayList arrayList = new ArrayList();

            arrayList.Add("Manolo");
            arrayList.Add("Jaime");
            arrayList.Add(17);
            arrayList.Add(5.56);

            // Recorremos la arraylist para mostrar todos los valores
            Console.WriteLine("\nContenido de la arraylist: \n");
            foreach (var valor in arrayList)
            {
                Console.WriteLine(valor);
            }

            // Recorremos la arraylist para mostrar todos los valores y su tipo
            Console.WriteLine("\nContenido de la arraylist junto a su tipo: \n");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item + " - " + item.GetType());
            }

            ArrayList arrayList2 = new ArrayList() { 12, "Mansana", 6.66, 3000 };

            // Añadir un rango de otra arraylist
            arrayList.AddRange(arrayList2);

            // Recorremos la arraylist para mostrar todos los valores y su tipo
            Console.WriteLine("\nContenido de la arraylist una vez hecho el AddRange: \n");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item + " - " + item.GetType());
            }

            // Mostramos los valores del array uno por uno con un índice
            Console.WriteLine("\nContenido de la arraylist mostrado por índice: \n");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            // Añadimos nuevos valores a la arraylist
            arrayList.Insert(1, "Valor añadido");
            arrayList.Insert(2, 90);
            Console.WriteLine("\nContenido del arraylist con valores añadidos:\n");
            MostrarArrayList(arrayList);

            // Añadimos un rango de valores a la arraylist
            arrayList.InsertRange(2, arrayList2);
            Console.WriteLine("\nContenido del arraylist con valores añadidos utilizando InsertRange:\n");
            MostrarArrayList(arrayList);

            //Elimina el elemento 12 (sólo uno)
            arrayList.Remove(12); 
            Console.WriteLine("\nElemento 12 eliminado (el primero)\n");
            MostrarArrayList(arrayList);

            //Elimina el valor 12 (todos)
            while (arrayList.Contains(12)) { arrayList.Remove(12); }
            Console.WriteLine("\nElemento 12 eliminado (todos)\n");
            MostrarArrayList(arrayList);

            // Elimina el valor 2 basandose en el índice de la arraylist
            arrayList.RemoveAt(2); 
            Console.WriteLine("\nElemento numero 2 eliminado basandose en el índice (todos)\n");
            MostrarArrayList(arrayList);

            //Elimina 4 elementos a partir de la posición 2
            arrayList.RemoveRange(2, 4);
            Console.WriteLine("\nA partir de la posición 2, elimina 4 elementos\n");
            MostrarArrayList(arrayList);

            Console.WriteLine("\nÍndice de Mansana:\n");
            Console.WriteLine(arrayList.IndexOf("Mansana"));

            Console.WriteLine("\nArraylist ordenada alfabéticamente: \n");
            ArrayList cadenas = new ArrayList() { "17", "ventilador", "tomate", "pelota", "jose" };
            cadenas.Sort();
            MostrarArrayList(cadenas);

            void MostrarArrayList(ArrayList arraylist)
            {
                foreach (var valor in arraylist)
                {
                    Console.WriteLine(valor);
                }
            }
        }
    }
}
