using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje22
    {
        public Eje22()
        {
            int op;
            double ultResult = 0;
            bool primerCal = true; // Nos ayuda a saber si el historial está vacío

            do
            {
                Console.Clear();
                Console.WriteLine("\n========================================");
                Console.WriteLine("          CALCULADORA INTERACTIVA       ");
                Console.WriteLine("========================================");

                Console.WriteLine("");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia (x^y)");
                Console.WriteLine("6. Raíz Cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Limpiar calculadora (Borrar memoria)");
                Console.WriteLine("9. Salir");

                if (!primerCal)
                {
                    Console.WriteLine($"\n[Resultado acumulado actual: {ultResult}]");
                    Console.WriteLine("----------------------------------------");
                }

                Console.Write("Elige una opción: ");

                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    continue;
                }

                if (op >= 1 && op <= 7)
                {
                    double num1,num2 = 0;
                    bool validos = true;
                    do
                    {
                        // Si es el primer cálculo, pedimos el número base. 
                        // Si no, usamos automáticamente el 'ultimoResultado'.
                        if (primerCal)
                        {
                            Console.Write("Introduce el primer número: ");
                            if(!double.TryParse(Console.ReadLine(), out num1))
                            {
                                Console.WriteLine("\nINGRESE UN NUMERO VALIDO\n");
                                validos = false;
                                continue;
                            }
                            primerCal = false;
                        }
                        else
                        {
                            num1 = ultResult;
                            Console.WriteLine($"Primer número (Memoria): {num1}");
                        }

                        // La raíz cuadrada solo necesita un número, las demás necesitan un segundo dato
                        if (op != 6)
                        {
                            Console.Write("Introduce el segundo número / valor: ");
                            if(!double.TryParse(Console.ReadLine(), out num2))
                            {
                                Console.WriteLine("\nINGRESE UN NUMERO VALIDO\n");
                                validos = false;
                                continue;
                            }
                        }
                    } while (!validos);


                    // Procesar la operación seleccionada
                    switch (op)
                    {
                        case 1: // Suma
                            ultResult = num1 + num2;
                            break;
                        case 2: // Resta
                            ultResult = num1 - num2;
                            break;
                        case 3: // Multiplicación
                            ultResult = num1 * num2;
                            break;
                        case 4: // División
                            if (num2 != 0)
                                ultResult = num1 / num2;
                            else
                                Console.WriteLine("Error: No se puede dividir entre cero.");
                            break;
                        case 5: // Potencia
                            ultResult = Math.Pow(num1, num2);
                            break;
                        case 6: // Raíz Cuadrada
                            if (num1 >= 0)
                                ultResult = Math.Sqrt(num1);
                            else
                                Console.WriteLine("Error: No se puede calcular la raíz de un número negativo.");
                            break;
                        case 7: // Porcentaje (Calcula el num2% de num1)
                            ultResult = (num1 * num2) / 100;
                            break;
                    }

                    Console.WriteLine($"=> Resultado de la operación: {ultResult}");
                }
                else if (op == 8)
                {
                    // Reiniciar la calculadora
                    ultResult = 0;
                    primerCal = true;
                    Console.WriteLine("\n¡Memoria de la calculadora borrada!");
                }

            } while (op != 9);
            
            Console.WriteLine("\nRegresando al Menu...");
        }
    }
}