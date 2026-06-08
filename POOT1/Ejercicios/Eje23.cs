using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje23
    {
        public Eje23()
        {
            int n = 0;

            do
            {
                Console.WriteLine("Estadísticas de calificaciones\n----------------------------------------\n");
                Console.Write("Cuantas Notas va a Ingresar?: ");
                if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UNA CANTIDAD VALIDA");
                    n = 0;
                    continue;
                }

                int[] notas = new int[n];

                int sumaNotas=0, max=0, min=100, apr =0, rep=0;
                double prom, desv;

                for(int i = 0; i < notas.Length; i++)
                {
                    Console.Write($"Ingrese Nota #{i+1}: ");
                    if (!int.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0|| notas[i] > 100)
                    {
                        Console.WriteLine("\nINGRESE UNA NOTA VALIDA\n");
                        notas[i]=0;
                        i--;
                        continue;
                    }
                    sumaNotas += notas[i];
                    max = Math.Max(notas[i], max);
                    min = Math.Min(notas[i], min);

                    if(notas[i]>=70) apr++; else rep++;
                };

                prom = (double)sumaNotas/n;

                //Calculo de desviación Estándar
                double sumaDif = 0;
                foreach(int nota in notas)
                {
                    sumaDif += ((nota - prom)*(nota - prom));
                }

                desv = Math.Sqrt(sumaDif/n);


                Console.WriteLine("");
                Console.WriteLine($"Promedio: {prom:F2}");
                Console.WriteLine($"Mayor Nota: {max}");
                Console.WriteLine($"Menor Nota: {min}");
                Console.WriteLine($"Aprobados: {apr}");
                Console.WriteLine($"Reprobados: {rep}");
                Console.WriteLine($"Desviación: {desv:F2}");
            } while (n <= 0);
        }
    }
}