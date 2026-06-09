using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje12
    {
        public Eje12()
        {
            int anio = 0, mes = 0;
            Console.WriteLine("Año bisiesto y días del mes\n----------------------------------------\n");

        while (anio <= 0)
            {
                Console.WriteLine("Ingrese el Año a Evaluar (D.C.):");
                if (!int.TryParse(Console.ReadLine(), out anio) || anio <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN AÑO VALIDO\n");
                    anio = 0;
                }
            }

            while (mes <= 0)
            {
                Console.WriteLine($"Ingrese el Mes del Año {anio} (1-12):");
                if (!int.TryParse(Console.ReadLine(), out mes) || mes <= 0 || mes >12)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN MES VALIDO\n");
                    mes = 0;
                }
            }

            bool esBisiesto = ((anio % 4 == 0 && anio%100 !=0) || anio %400 ==0);
            //Un año es bisiesto solo si es Divisible entre 4 pero no es Divisible entre 100 (osea un nuevo Siglo) amenos que sea Divisible entre 400
            int dsMes;

            string nombMes;

            switch (mes)
            {
                case 1: nombMes = "Enero"; dsMes = 31; break;
                case 2: nombMes = "Febrero"; dsMes = esBisiesto?29:28 ; break;
                case 3: nombMes = "Marzo"; dsMes = 31; break;
                case 4: nombMes = "Abril"; dsMes = 30; break;
                case 5: nombMes = "Mayo"; dsMes = 31; break;
                case 6: nombMes = "Junio"; dsMes = 30; break;
                case 7: nombMes = "Julio"; dsMes = 31; break;
                case 8: nombMes = "Agosto"; dsMes = 31; break;
                case 9: nombMes = "Septiembre"; dsMes = 30; break;
                case 10: nombMes = "Octubre"; dsMes = 31; break;
                case 11: nombMes = "Noviembre"; dsMes = 30; break;
                case 12: nombMes = "Diciembre"; dsMes = 31; break;
                default: nombMes = "";dsMes = 0; break;
            }

            Console.WriteLine("\nRESULTADO\n");
            Console.WriteLine($"El Año {anio} {(esBisiesto ? "SI": "NO")} es Bisiesto");
            Console.WriteLine($"El Mes {nombMes} del año {anio} tiene {dsMes} Dias");
        }        
    }
}