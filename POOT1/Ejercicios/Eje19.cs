namespace POOT1.Ejercicios
{
    public class Eje19
    {
        public Eje19()
        {
            Random r = new Random();
            int oculto = r.Next(1, 101);
            string[] nomIntento = { "Primer", "Segundo", "Tercer", "Cuarto", "Quinto", "Sexto", "ULTIMO" };
            int n = 0, turno = 0, maxTurnos = nomIntento.Length; //por si en un futuro quieren modificar el Maximo de intentos
            int[] intentos = new int[maxTurnos];

            Console.WriteLine("Juego de adivinanza\n----------------------------------------\n");
            Console.WriteLine($"Adivina el Numero Aleatorio (1-100)");
            while (oculto != n && turno < maxTurnos)
            {
                Console.WriteLine($"{nomIntento[turno]} Intento:");
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n>100)
                {
                    Console.WriteLine("\nINGRESE UN NUMERO VALIDO\n");
                    n = 0;
                    continue;
                }

                if (intentos.Contains(n))
                {
                    Console.WriteLine($"\nYA INTENTASTE CON {n}\nPRUEBA OTRO NUMERO\n");
                    n = 0;
                    continue;
                }

                intentos[turno] = n;
                turno++; //Suma un intento

                if (oculto == n) Console.WriteLine("\nHAZ ADIVINADO, FELICIDADES");
                else if (turno < maxTurnos) Console.WriteLine($"\nEl numero Oculto es {(oculto > n ? "MAYOR" : "MENOR")} que {n}\nTe quedan {maxTurnos - turno} intento{(maxTurnos - turno > 1 ? "s" : "")}\n");
            }


            if (!intentos.Contains(oculto))
            {
                Console.WriteLine($"\nESTADÍSTICAS\nEl Numero era {oculto}");

                for (int i = 0; i < intentos.Length; i++)
                {
                    Console.WriteLine($"{i + 1}º Intento:  {intentos[i]:D2} - {100 - (Math.Max(oculto, intentos[i]) - Math.Min(oculto, intentos[i]))}% Cerca");
                }
            }
        }
    }
}