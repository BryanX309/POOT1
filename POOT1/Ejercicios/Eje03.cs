namespace POOT1.Ejercicios
{
    public class Eje03
    {
        public Eje03()
        {
            int[] billetes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 }; //se usa valores enteros ya que se manejas billetes completos, sin centavos

            int monto = 0;
            do
            {
                Console.WriteLine("Desglose de Billetes\n----------------------------------------\n");
                Console.WriteLine("Ingrese el monto que desea desglosar: L. ");
                if (!int.TryParse(Console.ReadLine(), out monto) || monto <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN MONTO VALIDO\n");
                    monto = 0;
                    continue;
                }
            } while (monto <= 0);

            Console.WriteLine($"\nDesglose de Billetes para L. {monto}");
            foreach (int billete in billetes)
            {
                int n = monto / billete; //esta variable contiene la cantidad de billetes X que se descontaran del monto, se usa entero para ignorar decimales

                if (n >= 1)
                {
                    monto -= billete * n;
                    Console.WriteLine($"{billete} x {n}");
                }
            }
        }
    }
}