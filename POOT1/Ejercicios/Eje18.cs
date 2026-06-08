using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje18
    {

        public int factorial(int n)
        {
            int f = 1;

            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }

            return f;
        }

        public Eje18()
        {
            int n = 0, r = 0;

            while (n <= 0 || r <= 0)
            {
                Console.WriteLine("Factorial y combinaciones\n----------------------------------------\n");
                Console.WriteLine("Ingresar el Numero total de elementos:");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN NUMERO VALIDO\n");
                    n = 0;
                    continue;
                }

                Console.WriteLine("Ingresar el Numero de elementos a Seleccionar:");
                if (!int.TryParse(Console.ReadLine(), out r) || r <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN NUMERO VALIDO\n");
                    r = 0;
                    continue;
                }

                if (r > n)
                {
                    Console.Clear();
                    Console.WriteLine("EL NUMERO DE ELEMENTOS SELECCIONADOS NO PUEDE EXCEDER EL NUMERO DE ELEMENTOS TOTALES\n");
                    r = 0;
                    continue;
                }
            }

            int combi = factorial(n)/(factorial(r)*factorial(n-r));

            Console.WriteLine($"Al Seleccionar {r} elementos de {n} elementos totales\nTenemos un total de {combi} Combinaciones posibles");
        }
    }
}