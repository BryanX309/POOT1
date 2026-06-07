using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje15
    {
        public Eje15()
        {
            int n = 0;

            while (n <= 0)
            {
                Console.WriteLine("Tabla de Multiplicar Extendida\n----------------------------------------\n");
                Console.WriteLine("Ingresar Numero a Multiplicar:");
                if(!int.TryParse(Console.ReadLine(), out n) || n<=0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN NUMERO VALIDO\n");
                    n=0;
                }
            }

            Console.WriteLine($"Tabla de Multiplicar de {n}");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{n} x {i}\t= {i*n}");
            }
        }
    }
}