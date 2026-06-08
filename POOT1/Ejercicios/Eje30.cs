using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje30
    {
        private double[,] inventario = new double[,]
        {
            { 101, 50, 1.20 },
            { 102, 20, 1.50 },
            { 103, 15, 2.10 },
            { 104, 30, 3.50 },
            { 105, 12, 4.80 }
        };

        string[,] nombres = {
            {"101","Manzanas"},
            {"102","Leche"},
            {"103","Pan Integral"},
            {"104","Huevos x 12"},
            {"105","Cafe"}
        };

        private void mostrarInvt(string buscar = "") //con la Opción de buscar podemos hacer que muestre solo 1 elemento si existe
        {
            Console.WriteLine("\n{0,-8} {1,-15} {2,-10} {3,-8}", "Código", "Nombre", "Cantidad", "Precio");
            Console.WriteLine("--------------------------------------------\n");

            for (int i = 0; i < inventario.GetLength(0); i++)
            {
                if (buscar == "")
                {
                    Console.WriteLine("{0,-8} {1,-15} {2,-10} L{3,-8}", inventario[i, 0], nombres[i, 1], inventario[i, 1], $"{(decimal)inventario[i,2]:F2}");
                }
                else
                {
                    if (buscar == inventario[i, 0].ToString())
                        Console.WriteLine("{0,-8} {1,-15} {2,-10} L{3,-8}", inventario[i, 0], nombres[i, 1], inventario[i, 1], $"{(decimal)inventario[i,2]:F2}");
                }

            }
        }

        private double existeInvt(string buscar) //confirma que el item existe
        {
            double existe = -1;

            for (int i = 0; i < inventario.GetLength(0); i++)
            {
                if (inventario[i, 0].ToString() == buscar)
                    existe = i;
            }

            return existe;
        }

        private void buscarInvt()
        {
            Console.WriteLine("\nIngrese el Código del producto que quiere Buscar");
            string buscar = Console.ReadLine();

            if (existeInvt(buscar) >= 0) mostrarInvt(buscar); else Console.WriteLine("\nEl Elemento Buscado no existe en el inventario\n");
        }

        private void actualizarInvt()
        {
            Console.WriteLine("\nIngrese el Código del producto que quiere Actualizar: ");
            string buscar = Console.ReadLine();
            double id = existeInvt(buscar);

            if (id>=0)
            {
                int nuevo = -1;
                do
                {
                    Console.WriteLine($"\nEl Inventario Actual de {nombres[(int)id,1]} es de {inventario[(int)id,1]}");
                    Console.Write($"\nIngrese el Nuevo Inventario: ");

                    if (!int.TryParse(Console.ReadLine(), out nuevo) || nuevo < 0)
                    {
                        Console.WriteLine("\nIngrese una cantidad valida\n");
                        nuevo = -1;
                        continue;
                    }

                    inventario[(int)id,1] = nuevo;

                    Console.WriteLine("\nInventario Actualizado Correctamente");

                } while (nuevo == -1);
            }
            else Console.WriteLine("\nEl Elemento Buscado no existe en el inventario\n");
        }

        private void valorInvt()
        {
            double suma = 0;
            for (int i = 0; i < inventario.GetLength(0); i++)
            {
                suma += inventario[i,1] * inventario[i,2];
            }

            Console.WriteLine($"\nEl Inventario Actual esta valorado en L.{suma:F2} en total");
        }

        public Eje30()
        {
            int op = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("          SISTEMA DE INVENTARIO         ");
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Mostrar Inventario Completo");
                Console.WriteLine("2. Buscar Producto por Código");
                Console.WriteLine("3. Actualizar Cantidad (Stock)");
                Console.WriteLine("4. Calcular Valor Total del Inventario");
                Console.Write("\nSelecciona una opción: ");

                if (!int.TryParse(Console.ReadLine(), out op) || op < 0 || op > 4)
                {
                    Console.WriteLine("\nOpción no válida. Intenta de nuevo\n");
                    continue;
                }

                switch (op)
                {
                    case 0: Console.WriteLine("Saliendo..."); break;
                    case 1: mostrarInvt(); break;
                    case 2: buscarInvt(); break;
                    case 3: actualizarInvt(); break;
                    case 4: valorInvt(); break;
                    default: break;
                }

                if (op != 0) Console.ReadKey();

            } while (op != 0);
        }
    }
}