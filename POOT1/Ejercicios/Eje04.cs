namespace POOT1.Ejercicios
{
    public class Eje04
    {
        public Eje04()
        {
            decimal interes, cuota;

            Console.WriteLine("Calculadora de préstamo simple\n----------------------------------------\n");
            
            Console.WriteLine("Ingrese el Monto a Evaluar (L): ");
            decimal.TryParse(Console.ReadLine(), out decimal monto);

            Console.WriteLine("Ingrese la tasa de Interés Anual (%): ");
            decimal.TryParse(Console.ReadLine(), out decimal tasa);

            Console.WriteLine("Ingrese los meses de plazo: ");
            int.TryParse(Console.ReadLine(), out int meses);

            interes = monto * tasa/100 * meses/12; //meses/12 para obtener el tiempo de plazo en años
            cuota = (interes+monto)/meses;

            Console.WriteLine($"Monto: L.{monto}\nIntereses: L.{interes}\nSaldo total: L.{monto + interes}");
            Console.WriteLine($"Cuota Mensual: L.{cuota}");
        }
    }
}