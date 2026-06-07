using System;

namespace POOT1.Ejercicios
{
    public class Eje14
    {
        public Eje14()
        {
            int[,] billetes = new int[,] //Genera un Array Bidimensional o una matriz
            {
                //{monto de bilete, cantidad de billete}
                {500, 4},
                {200, 4},
                {100, 4},
                {50, 4},
                {20, 10}
            };

            int TotalCajero = 0;

            for (int i = 0; i < billetes.Length / 2; i++) //se divide el Length porque cuenta cada elemento de la matriz como si fueran elementos individuales, por lo que aunque solo tenga 5 Indices "Separados" los cuenta como 10 indices
            {
                // Console.WriteLine($"Largo Array {billetes.Length}: #{i}");
                // Console.WriteLine($"l. {billetes[i, 0]} con {billetes[i, 1]}");
                TotalCajero += (billetes[i, 0] * billetes[i, 1]);
            }

            int monto = 0;

            while (monto == 0)
            {
                Console.WriteLine("Cajero Automático\n----------------------------------------\n");

                Console.WriteLine("Ingrese el Monto que desea Retirar\n(solo múltiplos de L. 20):");
                if (int.TryParse(Console.ReadLine(), out monto))
                {
                    if (monto < 20)
                    {
                        Console.Clear();
                        Console.WriteLine("El Monto ingresado es menor al MÍNIMO POSIBLE\nINTENTE OTRA VEZ\n");
                        monto = 0;
                        continue;
                    }

                    if (monto % 20 != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("El Monto ingresado no es Múltiplo de 20\nINTENTE OTRA VEZ\n");
                        monto = 0;
                        continue;
                    }

                    if (monto > TotalCajero)
                    {
                        Console.Clear();
                        Console.WriteLine("El Monto ingresado es MAYOR AL SALDO DEL CAJERO\nINTENTE OTRA VEZ\n");
                        monto = 0;
                        continue;
                    }
                }
                else
                {
                    Console.Clear(); Console.WriteLine("MONTO INGRESADO NO VALIDO\nINTENTE OTRA VEZ\n");
                }
            }

            int[,] retiros = new int[,] //Arreglo que cuenta los billetes a retirar
            {
                {500, 0},
                {200, 0},
                {100, 0},
                {50, 0},
                {20, 0}
            };

            int nuevoMonto=monto;

            for (int i = 0; i < retiros.Length / 2; i++)
            {
                int n = Math.Min(nuevoMonto / retiros[i, 0], billetes[i,1]);
                int deduc = nuevoMonto - retiros[i, 0] * n; //Deduccion de Monto

                if (n <= 0 || (deduc % 20 !=0 ? deduc !=0 : false)) continue;
                retiros[i, 1] = n;
                nuevoMonto -= retiros[i, 0] * n;
                
            }

            if(nuevoMonto == 0)
            {
                Console.WriteLine($"Desglose de Retiro de L.{monto}:");

                for (int i = 0; i < retiros.Length / 2; i++)
                    if(retiros[i, 1]>0) Console.WriteLine($"L.{retiros[i, 0]} x {retiros[i, 1]}");
            }
            else
            {
                Console.WriteLine("LO SENTIMOS, NO TEMEMOS SUFICIENTES BILLETES PARA DARLE EL RETIRO EXACTO\nINTENTE MAS TARDE\n");
            }
        }
    }
}