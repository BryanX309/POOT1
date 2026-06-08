using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje25
    {
        public Eje25()
        {
            int nElem = 0;
            do
            {
                Console.WriteLine("Rotación de arreglo\n----------------------------------------\n");
                Console.WriteLine("Ingrese cuantos elementos quiere en el arreglo:");
                if (!int.TryParse(Console.ReadLine(), out nElem) || nElem <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("\nINGRESE UN NUMERO VALIDO\n");
                    nElem = 0;
                    continue;
                }
            } while (nElem <= 0);

            int[] nums = new int[nElem];

            for (int i = 0; i < nums.Length; i++)
            {
                //Random r = new Random();
                //nums[i] = r.Next(1, nElem * 2);
                nums[i] = i+1;
            }

            int sele = -1;

            Console.Clear();

            do
            {
                Console.WriteLine("Rotación de arreglo\n----------------------------------------");
                Console.WriteLine($"Arreglo: {string.Join(", ", nums)}\n----------------------------------------\n");

                Console.WriteLine("Que desea Hacer con el Arreglo?\n");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Rotar K Posiciones a la Izquierda");
                Console.WriteLine("2. Rotar K Posiciones a la Derecha");
                Console.WriteLine("3. Invertir Arreglo");
                Console.WriteLine("");

                if (!int.TryParse(Console.ReadLine(), out sele) || sele < 0 || sele > 3)
                {
                    Console.Clear();
                    Console.WriteLine("\nSELECCIONE UNA OPERACIÓN VALIDA\n");
                    sele = -1;
                    continue;
                }

                switch (sele)
                {
                    case 0: Console.WriteLine("Saliendo..."); break;

                    case 1 or 2:
                        int k = 0;

                        do
                        {
                            Console.WriteLine("Cuantas posiciones desea desplazar:");
                            if (!int.TryParse(Console.ReadLine(), out k) || k < 0)
                            {
                                Console.WriteLine("\nINGRESE UNA CANTIDAD VALIDA\n");
                                k = 0;
                                continue;
                            }

                            if (k >= nums.Length)
                            {
                                Console.WriteLine($"\nSOLO PUEDE ROTAR EL ARREGLO {nums.Length - 1} ELEMENTOS O MENOS\n");
                                k = 0;
                                continue;
                            }

                            if (sele == 1) k = nums.Length - k; // en el caso que se rote a la izquierda se invierte el valor de k; Eje: en un arreglo de 10 items desplazar 1 a la izquierda es lo mismo que desplazar 9 a la derecha
                            //para simplificar el código

                            int[] rota = new int[nums.Length]; // arreglo copia para devolver el arreglo despasado

                            for (int i = 0; i < nums.Length; i++)
                            {
                                int pos = i + k >= nums.Length ? i + k - nums.Length : i + k; //variable que contendrá la nueva posición del elemento a desplazar

                                rota[pos] = nums[i];
                            }

                            nums = rota;

                            Console.WriteLine("El Arreglo se ha rotado Correctamente");

                        } while (k <= 0);
                        break;

                    case 3:
                        int[] inve = new int[nums.Length]; // arreglo copia para devolver el arreglo despasado

                        for (int i = 0; i < nums.Length; i++)
                        {
                            int pos = nums.Length - 1 - i;
                            inve[pos] = nums[i];
                        }

                        nums = inve;

                        Console.WriteLine("El Arreglo Invertido Correctamente");
                        break;
                    default: break;
                }

                if (sele != 0)
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (sele != 0);

        }
    }
}