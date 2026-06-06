using POOT1.Ejercicios;

namespace POOT1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
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

                Console.WriteLine("\nSeleccione la funcion a probar:");
                selec = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (selec)
                {
                    case 0: 
                    exit = true;
                    // Console.WriteLine("Esta seguro que quiere Salir? (Y/N)");
                    // ConsoleKeyInfo tecla = Console.ReadKey();

                    //aqui exit sera verdadero solo si la tecla pulsada es Y cancelando la condicion del While
                    //exit = (tecla.Key == ConsoleKey.Y);
                    break;
                    case 1: Eje01 ej1 = new Eje01(); break;
                    case 2: Eje02 ej2 = new Eje02(); break;
                    default: Console.WriteLine("Ingrese un numero valido de Selecion"); Console.ReadKey(); break;
                }

                Console.ReadKey();
            }
            Console.WriteLine("Saliendo...");
        }
    }
}