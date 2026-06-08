using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje26
    {
        public Eje26()
        {
            int[,] cont = new int[,] //Variable que llevara el conteo de cada posiblidad
            {
              {1,0},
              {2,0},
              {3,0},
              {4,0},
              {5,0},
              {6,0},
              {7,0},
              {8,0},
              {9,0},
              {10,0},
            };
            Console.WriteLine("Frecuencia de elementos\n----------------------------------------\n");
            Console.WriteLine("Presione cualquier tecla para generar Numeros");
            Console.ReadKey();

            for (int i = 1; i <= 20; i++)
            {
                Random r = new Random();
                int n = r.Next(1, 11);

                cont[n - 1, 1]++;
            }

            Console.WriteLine($"RESULTADOS\n----------------------------------------\n");
            int max = 0, min = 20;//Variables solo para identificar el maximo o minimo de repeticiones mas no el numero mas repetido
            
            //Listas que continten los numeros mas y menos frecuentes
            List<int> masF = new List<int>();
            List<int> menosF = new List<int>();


            for (int i = 0; i < cont.GetLength(0); i++)
            {
                if (cont[i, 1] > 0) Console.WriteLine($"El Numero {cont[i, 0]} apareció {cont[i, 1]} ve{(cont[i, 1] == 1 ? "z" : "ces")}");
                else Console.WriteLine($"El Numero {cont[i, 0]} NO apareció");
                max = Math.Max(max, cont[i, 1]);
                min = cont[i, 1] > 0 ? Math.Min(min, cont[i, 1]) : min;
            }
            
            //Se usa un for aparte porque aquí ya tenemos los valores fijos de max y min
                for (int i = 0; i < cont.GetLength(0); i++)
            {
                if (max == cont[i, 1]) masF.Add(cont[i,0]);
                if (min == cont[i, 1]) menosF.Add(cont[i,0]);
            }

            Console.WriteLine("");
            if(masF.Count()>1) Console.WriteLine($"Los Valores Mas Frecuentes son {string.Join(", ",masF)} con {max} Repeticiones");
            else Console.WriteLine($"EL Valor que Mas Frecuente es {masF[0]} con {max} Repeticiones");

            if(menosF.Count()>1) Console.WriteLine($"Los Valores Menos Frecuentes son {string.Join(", ",menosF)} con {min} Repeticiones");
            else Console.WriteLine($"EL Valor que Menos Frecuente es {menosF[0]} con {min} Repeticiones");
        }
    }
}