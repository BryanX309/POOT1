namespace POOT1.Ejercicios
{
    public class Eje04
    {
        public Eje04()
        {
            decimal interes, cuota;
            decimal monto = 0, tasa = 0;
            int meses = 0;

            do
            {
                Console.WriteLine("Calculadora de préstamo simple\n----------------------------------------\n");

                Console.WriteLine("Ingrese el Monto a Evaluar (L): ");
                if (!decimal.TryParse(Console.ReadLine(), out monto) || monto <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN MONTO VALIDO\n");
                    monto = 0;
                    continue;
                }

                Console.WriteLine("Ingrese la tasa de Interés Anual (%): ");
                if (!decimal.TryParse(Console.ReadLine(), out tasa) || tasa <= 0 || tasa > 100)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UNA TASA DE INTERÉS VALIDA\n");
                    monto = 0;
                    continue;
                }

                Console.WriteLine("Ingrese los meses de plazo: ");
                if (!int.TryParse(Console.ReadLine(), out meses) || monto <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN PLAZO DE TIEMPO VALIDO\n");
                    monto = 0;
                    continue;
                }
            } while (monto <= 0 || tasa <= 0 || meses <= 0);

            interes = monto * tasa / 100 * meses / 12; //meses/12 para obtener el tiempo de plazo en años
            cuota = (interes + monto) / meses;

            Console.WriteLine($"Monto: L.{monto}\nIntereses: L.{interes}\nSaldo total: L.{monto + interes}");
            Console.WriteLine($"Cuota Mensual: L.{cuota:F2}");
        }
    }
}