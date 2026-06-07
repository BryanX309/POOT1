namespace POOT1.Ejercicios
{
    public class Eje08
    {
        public Eje08()
        {

            Console.WriteLine("Cálculo de salario semanal\n----------------------------------------\n");
            int hrs = 0, hrsNormales = 44; //se declara una variable de horas normales por si se modifica la cantidad de horas normales en un futuro
            decimal tarifa = 0, salario;

            while (hrs <= 0)
            {
                Console.WriteLine("Ingrese las Horas Trabajadas en esta Semana\n(solo horas enteras): ");
                if (int.TryParse(Console.ReadLine(), out hrs))
                {
                    while (tarifa <= 0)
                    {
                        Console.WriteLine("Ingrese la tarifa por hora trabajada (L.): ");
                        if (decimal.TryParse(Console.ReadLine(), out tarifa))
                        {

                            //Calculo de Salario Total
                            salario = hrs * tarifa + (hrs > hrsNormales ? (hrs-hrsNormales) * tarifa * 0.5m : 0);

                            Console.WriteLine("DESGLOSE DE SALARIO");
                            Console.WriteLine($"{(hrs > hrsNormales ? hrsNormales : hrs)} Horas Normales: L.{Math.Min(hrs,hrsNormales) * tarifa}");
                            if(hrs>44) Console.WriteLine($"{hrs-hrsNormales} Horas Extra: L.{(hrs-hrsNormales) * tarifa * 1.5m}");
                            Console.WriteLine($"\nSALARIO TOTAL: L.{salario}");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese una Tarifa valida");
                            tarifa = 0;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un numero de Horas valido");
                    hrs = 0;
                }
            }
        }
    }
}