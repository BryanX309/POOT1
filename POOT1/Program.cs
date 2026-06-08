using POOT1.Ejercicios;

namespace POOT1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                int selec;
                Console.Clear();
                Console.WriteLine("MENU DE SELECCION\n----------------------------------\n");
                Console.WriteLine("0. SALIR");
                Console.WriteLine("1. Calculadora de IMC");
                Console.WriteLine("2. Conversión de temperatura");
                Console.WriteLine("3. Desglose de billetes");
                Console.WriteLine("4. Calculadora de préstamo simple");
                Console.WriteLine("5. Tiempo transcurrido");
                Console.WriteLine("6. Área y perímetro");
                Console.WriteLine("7. Conversión de unidades de almacenamiento");
                Console.WriteLine("8. Cálculo de salario semanal");
                Console.WriteLine("9. Clasificación de triángulos");
                Console.WriteLine("10. Sistema de calificaciones UNAH");
                Console.WriteLine("11. Calculadora de descuentos");
                Console.WriteLine("12. Año bisiesto y días del mes");
                Console.WriteLine("13. Validador de fecha");
                Console.WriteLine("14. Cajero automático");
                Console.WriteLine("15. Tabla de multiplicar extendida");
                Console.WriteLine("16. Números primos en rango");
                Console.WriteLine("17. Serie Fibonacci");
                Console.WriteLine("18. Factorial y combinaciones");
                Console.WriteLine("19. Juego de adivinanza");
                Console.WriteLine("20. Validación de contraseña");
                Console.WriteLine("21. Patrón de asteriscos");
                Console.WriteLine("22. Calculadora con menú");
                Console.WriteLine("23. Estadísticas de calificaciones");
                Console.WriteLine("24. Búsqueda y ordenamiento");
                Console.WriteLine("25. Rotación de arreglo");
                Console.WriteLine("26. Frecuencia de elementos");
                Console.WriteLine("27. Arreglo de temperaturas");
                Console.WriteLine("28. Matriz de notas por parcial");
                Console.WriteLine("29. Juego de Gato (Tic-Tac-Toe)");
                Console.WriteLine("30. Inventario simple");

                Console.WriteLine("\nSeleccione la función a probar:");
                selec = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (selec)
                {
                    case 0:
                        salir = true;
                        // Console.WriteLine("Esta seguro que quiere Salir? (Y/N)");
                        // ConsoleKeyInfo tecla = Console.ReadKey();

                        //aquí exit sera verdadero solo si la tecla pulsada es Y cancelando la condición del While
                        //exit = (tecla.Key == ConsoleKey.Y);
                        break;
                    case 1: Eje01 ej1 = new Eje01(); break;
                    case 2: Eje02 ej2 = new Eje02(); break;
                    case 3: Eje03 ej3 = new Eje03(); break;
                    case 4: Eje04 ej4 = new Eje04(); break;
                    case 5: Eje05 ej5 = new Eje05(); break;
                    case 6: Eje06 ej6 = new Eje06(); break;
                    case 7: Eje07 ej7 = new Eje07(); break;
                    case 8: Eje08 ej8 = new Eje08(); break;
                    case 9: Eje09 ej9 = new Eje09(); break;
                    case 10: Eje10 ej10 = new Eje10(); break;
                    case 11: Eje11 ej11 = new Eje11(); break;
                    case 12: Eje12 ej12 = new Eje12(); break;
                    case 13: Eje13 ej13 = new Eje13(); break;
                    case 14: Eje14 ej14 = new Eje14(); break;
                    case 15: Eje15 ej15 = new Eje15(); break;
                    case 16: Eje16 ej16 = new Eje16(); break;
                    case 17: Eje17 ej17 = new Eje17(); break;
                    case 18: Eje18 ej18 = new Eje18(); break;
                    case 19: Eje19 ej19 = new Eje19(); break;
                    case 20: Eje20 ej20 = new Eje20(); break;
                    case 21: Eje21 ej21 = new Eje21(); break;
                    // case 22: Eje22 ej22 = new Eje22(); break;
                    // case 23: Eje23 ej23 = new Eje23(); break;
                    // case 24: Eje24 ej24 = new Eje24(); break;
                    // case 25: Eje25 ej25 = new Eje25(); break;
                    // case 26: Eje26 ej26 = new Eje26(); break;
                    // case 27: Eje27 ej27 = new Eje27(); break;
                    // case 28: Eje28 ej28 = new Eje28(); break;
                    // case 29: Eje29 ej29 = new Eje29(); break;
                    // case 30: Eje30 ej30 = new Eje30(); break;

                    default: Console.WriteLine("Ingrese un numero valido de Selecion"); Console.ReadKey(); break;
                }

                if (selec != 0) Console.ReadKey();
            }
            Console.WriteLine("Saliendo...");
        }
    }
}