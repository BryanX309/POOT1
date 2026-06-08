using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje28
    {
        public Eje28()
        {
            int nAlum = 0;
            do
            {
                Console.WriteLine("Matriz de notas por parcial\n----------------------------------------\n");
                Console.WriteLine("Cuantos Alumnos va a ingresar:");
                if (!int.TryParse(Console.ReadLine(), out nAlum) || nAlum <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("\nINGRESE UN NUMERO VALIDO\n");
                    nAlum = 0;
                    continue;
                }
            } while (nAlum <= 0);

            int[,] alumnos = new int[nAlum, 3];
            float[] promedios = new float[nAlum];
            //solo se guardaran la notas, y los alumnos se identificaran con números
            //la 4 Columna sera para los promedios

            float[] mjrAlumno = new float[2]{0,0};

            for (int i = 0; i < alumnos.GetLength(0); i++)
            {
                Console.Clear();
                Console.WriteLine("Matriz de notas por parcial\n----------------------------------------\n");
                int nNota = 0;

                Console.WriteLine($"Notas Alumno #{i+1}\n----------------------------------------\n");

                do
                {
                    Console.WriteLine($"Ingrese la {nNota + 1}° Nota:");
                    if (!int.TryParse(Console.ReadLine(), out alumnos[i, nNota]) || alumnos[i, nNota] < 0 || alumnos[i, nNota] > 100)
                    {
                        Console.WriteLine("\nINGRESE UNA NOTA VALIDA\n");
                        alumnos[i, nNota] = 0;
                        continue;
                    }

                    nNota++;
                } while (nNota < 3);

                promedios[i] = (float)(alumnos[i, 0] + alumnos[i, 1] + alumnos[i, 2]) / 3;

                if(mjrAlumno[1]<promedios[i])
                {
                    mjrAlumno[0]=i;
                    mjrAlumno[1]=promedios[i];
                }
            }

            Console.Clear();

            float promP1 = 0,promP2 = 0,promP3 = 0;
            Console.WriteLine("NOTAS GUARDADAS\n----------------------------------------\n");
            Console.WriteLine("ALUMNO  \tP1\tP2\tP3\tProm");
            for (int i = 0; i < alumnos.GetLength(0); i++)
            {
                Console.WriteLine($"Alumno {i+1}\t{alumnos[i, 0]}\t{alumnos[i, 1]}\t{alumnos[i, 2]}\t{promedios[i]:F1}%");
                promP1 += alumnos[i, 0];
                promP2 += alumnos[i, 1];
                promP3 += alumnos[i, 2];
            }

            promP1 /= nAlum;
            promP2 /= nAlum;
            promP3 /= nAlum;
            Console.WriteLine($"\nPROM PAR\t{promP1:F1}%\t{promP2:F1}%\t{promP3:F1}%");

            Console.WriteLine($"\nEl alumno con mejor promedio es: Alumno {mjrAlumno[0]+1} con {mjrAlumno[1]:F2}%");

            if(promP1 <= promP2 && promP1 <= promP3) Console.WriteLine($"El Periodo mas Difícil (bajo) fue el P1");
            if(promP2 < promP1 && promP2 <= promP3) Console.WriteLine($"El Periodo mas Difícil (bajo) fue el P2");
            if(promP3 < promP1 && promP3 < promP2) Console.WriteLine($"El Periodo mas Difícil (bajo) fue el P3");
        }
    }
}