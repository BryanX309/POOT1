namespace POOT1.Ejercicios
{
    public class Eje13
    {
        public Eje13()
        {
            bool fechaVal = false;

            while (!fechaVal)
            {
                int dia, mes, anio;
                string nombMes;

                Console.WriteLine("Validador de Fecha\n----------------------------------------\n");

                Console.WriteLine("Ingrese el Dia:");
                if (!int.TryParse(Console.ReadLine(), out dia) || dia < 1 || dia > 31)
                { Console.Clear(); Console.WriteLine("EL DIA INGRESADO NO ES VALIDO\nINTENTE OTRA VEZ\n"); continue; }

                Console.WriteLine("Ingrese el Mes:");
                if (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
                { Console.Clear(); Console.WriteLine("EL MES INGRESADO NO ES VALIDO\nINTENTE OTRA VEZ\n"); continue; }

                Console.WriteLine("Ingrese el Año:");
                if (!int.TryParse(Console.ReadLine(), out anio) || anio < 1)
                { Console.Clear(); Console.WriteLine("EL AÑO INGRESADO NO ES VALIDO\nINTENTE OTRA VEZ\n"); continue; }

                bool esBisiesto = ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0);
                bool diaVal = true;

                switch (mes)
                {
                    case 1: nombMes = "Enero"; if (dia > 31) diaVal = false; break;
                    case 2: nombMes = "Febrero"; if (dia > (esBisiesto ? 29 : 28)) diaVal = false; break;
                    case 3: nombMes = "Marzo"; if (dia > 31) diaVal = false; break;
                    case 4: nombMes = "Abril"; if (dia > 30) diaVal = false; break;
                    case 5: nombMes = "Mayo"; if (dia > 31) diaVal = false; break;
                    case 6: nombMes = "Junio"; if (dia > 30) diaVal = false; break;
                    case 7: nombMes = "Julio"; if (dia > 31) diaVal = false; break;
                    case 8: nombMes = "Agosto"; if (dia > 31) diaVal = false; break;
                    case 9: nombMes = "Septiembre"; if (dia > 30) diaVal = false; break;
                    case 10: nombMes = "Octubre"; if (dia > 31) diaVal = false; break;
                    case 11: nombMes = "Noviembre"; if (dia > 30) diaVal = false; break;
                    case 12: nombMes = "Diciembre"; if (dia > 31) diaVal = false; break;
                    default: nombMes = ""; diaVal = false; break;
                }

                if (diaVal)
                {
                    Console.WriteLine($"\nEl {dia} de {nombMes} del {anio} es una Fecha valida");
                    fechaVal = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"El Mes de {nombMes} del año {anio} NO tiene {dia} Dias\nINTENTE OTRA VEZ\n");
                }
            }
        }
    }
}