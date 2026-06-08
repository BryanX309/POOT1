using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje27
    {
        public Eje27()
        {   
            int dia = 1, sumaTemps = 0;
            int[] temps = new int[7];
                Console.WriteLine("Arreglo de temperaturas\n----------------------------------------\n");
            do
            {
                Console.WriteLine($"Ingrese la Temperatura del Dia {dia}:");
                if (!int.TryParse(Console.ReadLine(), out temps[dia-1]))
                {
                    Console.Clear();
                    Console.WriteLine("\nINGRESE UNA TEMPERATURA VALIDA\n");
                    continue;
                }

                sumaTemps +=temps[dia-1];
                dia++;
            }while(dia <=7);

            Console.WriteLine("\nRESULTADOS\n----------------------------------------\n");

            int prom = sumaTemps/7; // Promedio Semanal
            Console.WriteLine($"Promedio Semanal: {prom}°");
            Console.WriteLine($"\nDias por Encima del Promedio: \n");

            int max = temps[0], min = temps[0];
            for (int i = 0; i < temps.Length; i++)
            {
                if(temps[i] > prom) Console.WriteLine($"Dia {i+1}: {temps[i]}°");

                max = Math.Max(max, temps[i]);
                min = Math.Min(min, temps[i]);
            }

            Console.WriteLine($"\nVariación entre Dias: \n");

            for (int i = 0; i < temps.Length; i++)
            {
                Console.Write($"Dia {i+1}: {temps[i]}°");
                if(i>=1)Console.Write($" {(temps[i] - temps[i-1]>0?"+":"")}{temps[i] - temps[i-1]}°");
                if(temps[i] == max)Console.Write($" (Dia Mas Caliente)");
                if(temps[i] == min)Console.Write($" (Dia Mas Frio)");
                Console.WriteLine("");
            }
        }
    }
}