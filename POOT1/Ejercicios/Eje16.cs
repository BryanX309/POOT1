using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje16
    {
        public Eje16()
        {
            int n1 = 0, n2 = 0;

            while (n1 <= 0 || n2 <= 0)
            {
                Console.WriteLine("Números primos en rango\n----------------------------------------\n");
                Console.WriteLine("Ingresar Inicio del Rango:");
                if(!int.TryParse(Console.ReadLine(), out n1) || n1<=0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN NUMERO VALIDO\n");
                    n1=0;
                    continue;
                }

                Console.WriteLine("Ingresar Final del Rango:");
                if(!int.TryParse(Console.ReadLine(), out n2) || n2<=0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN NUMERO VALIDO\n");
                    n2=0;
                    continue;
                }

                if (n1 > n2)
                {
                    Console.Clear();
                    Console.WriteLine("EL FINAL DEL RANGO DEBE SER UN NUMERO MAYOR QUE EL INICIO DEL RANGO\n");
                    n2=0;
                    continue;
                }
            }

            string primos = ""; //Variable que contendrá los números primos
            int contPrimos= 0;
            for(int i = n1; i <= n2; i++){
                int cont = 0;

                for (int j = 1; j <= i; j++)
                {
                    if(i%j == 0) cont++;
                }

                if (cont == 2 || i == 1)
                {
                    primos = $"{primos} / {i}";
                    contPrimos++;
                }
            }

            Console.WriteLine($"\nLos números primos entre {n1} y {n2} son:\n{primos} /");
            Console.WriteLine($"\nContando un total de {contPrimos} números Primos");
            
        }
    }
}