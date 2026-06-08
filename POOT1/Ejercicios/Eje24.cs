using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje24
    {
        public Eje24()
        {
            int[] nums = new int[10];

            Console.WriteLine("Búsqueda y ordenamiento\n----------------------------------------\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el {i + 1}º numero: ");
                if (!int.TryParse(Console.ReadLine(), out nums[i]))
                {
                    Console.WriteLine("\nINGRESE UN NUMERO VALIDO");
                    i--;
                    continue;
                }
            }

            int op = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("Búsqueda y ordenamiento\n----------------------------------------\n");
                Console.WriteLine($"\nNúmeros: {string.Join(", ", nums)}");

                Console.WriteLine("\nSeleccione una Operación\n----------------------------------------\n");
                Console.WriteLine("0. Salir\n");
                Console.WriteLine("1. Búsqueda Lineal");
                Console.WriteLine("2. Segundo Mayor");
                Console.WriteLine("3. Ordenar de Forma Ascendente");
                Console.WriteLine("4. Mostrar Posiciones Pares");

                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("\nSELECCIONE UNA OPERACIÓN VALIDA");
                    op = -1;
                    continue;
                }

                switch (op)
                {
                    case 0: Console.WriteLine("Saliendo..."); break;

                    case 1:
                        int busca;
                        Console.Write($"Ingrese el numero que quiere buscar: ");
                        if (!int.TryParse(Console.ReadLine(), out busca))
                        {
                            Console.WriteLine("\nOPERACIÓN INTERRUMPIDA POR INGRESO INVALIDO");
                            break;
                        }

                        bool existe = false;
                        int extPosicion = 0;

                        for (int i = 0; i < nums.Length; i++)
                        {
                            if (nums[i] == busca)
                            {
                                existe = true;
                                extPosicion = i;
                                break;
                            }
                        }

                        if (existe)
                        {
                            Console.WriteLine($"\nEl numero {busca} esta en la posicion {extPosicion + 1}");
                        }
                        else
                        {
                            Console.WriteLine($"\nNo Se encontó {busca} en el arreglo");
                        }
                        break;

                    case 2:
                        int mayor = 0, segMayor = 0;
                        for (int i = 0; i < nums.Length; i++)
                            mayor = Math.Max(mayor, nums[i]);

                        for (int i = 0; i < nums.Length - 1; i++)
                            segMayor = Math.Max(segMayor, (nums[i] == mayor ? 0 : nums[i]));

                        Console.WriteLine($"El Segundo Numero Mayor del Números es: {segMayor}");
                        break;

                    case 3: //Ordenar de menor a mayor
                        for (int i = 0; i < nums.Length - 1; i++)
                        {
                            for (int j = 0; j < nums.Length-1; j++)
                            {
                                int temp; // variable temporal
                                if (nums[j] > nums[j + 1])
                                {
                                    temp = nums[j];
                                    nums[j] = nums[j + 1];
                                    nums[j + 1] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Valores Ordenados Correctamente");
                        break;

                    case 4:
                        for (int i = 0; i < nums.Length; i++)
                        {
                            Console.Write($"/{(i % 2 == 0 ? " " : nums[i])}");
                        }
                        Console.Write("/");
                        break;
                    
                    default: break;
                }
                if(op != 0) Console.ReadKey();

            } while (op != 0);

        }
    }
}