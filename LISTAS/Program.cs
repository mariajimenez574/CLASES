using System;
using System.Collections.Generic;

namespace LISTAS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            var diasemana = new List<string>();
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(10);
            numeros.Add(3);
            numeros.Add(8);
            numeros.Add(7);
            diasemana.Add("LUNES");
            diasemana.Add("MIERCOLES");
            diasemana.Add("VIERNES");
            Console.WriteLine("LISTA DE NUMEROS");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            foreach (var item2 in diasemana)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("Eliminando a 10 non la lista de numeros");
            numeros.Remove(10);
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
