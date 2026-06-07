namespace POOT1.Ejercicios
{
    public class Eje11
    {
        public Eje11()
        {
            decimal monto = 0,desc;

            while (monto <= 0)
            {
                Console.WriteLine("Calculadora de descuentos\n----------------------------------------\n");

                Console.WriteLine("Ingrese el monto total (L):");
                if (!decimal.TryParse(Console.ReadLine(), out monto) || monto <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN MONTO VALIDO\n");
                    monto = 0;
                }
            }

            if(monto>=2500) desc = 0.15m;
            else if(monto>=1000) desc = 0.10m;
            else if(monto>=500) desc = 0.05m;
            else desc = 0.0m;

            Console.WriteLine($"Monto Original:\t\tL. {monto:F2}");
            Console.WriteLine($"Descuento ({desc*100}%):\tL. {monto*desc}");
            Console.WriteLine($"\nTotal a Pagar:\t\tL. {monto - monto*desc}");
        }
    }
}