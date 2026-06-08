using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje17
    {
        public Eje17()
        {
            int n = 0;

            while (n <= 0)
            {
                Console.WriteLine("Serie Fibonacci\n----------------------------------------\n");
                Console.WriteLine("Cuantos números de Fibonacci necesitas?:");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN NUMERO VALIDO\n");
                    n = 0;
                }
            }

            int[] fibo = new int[n];

            if (n >= 1) fibo[0] = 1;
            if (n >= 2) fibo[1] = 1;
            if (n >= 3)
            {
                for (int i = 2; i < fibo.Length; i++)
                {
                    fibo[i] = fibo[i-1] + fibo[i-2]; 
                }
            }

            Console.WriteLine($"Primeros {n} Números de Fibonacci");
            Console.WriteLine(string.Join(", ",fibo));
        }
    }
}