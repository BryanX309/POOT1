namespace POOT1.Ejercicios
{
    public class Eje03
    {
        public Eje03()
        {
            int[] billetes = {500,200,100,50,20,10,5,2,1}; //se usa valores enteros ya que se manejas billetes completos, sin centavos
            
            Console.WriteLine("Desglose de Billetes\n----------------------------------------\n");
            Console.WriteLine("Ingrese el monto que desea desglosar: L. ");
            int.TryParse(Console.ReadLine(), out int monto);

            Console.WriteLine($"Desglose de billetes para L. {monto}");
            foreach(int billete in billetes)
            {
                int n = monto/billete; //esta variable contiene la cantidad de billetes X que se descontaran del monto, se usa entero para ignorar decimales

                if(n >= 1)
                {
                    monto -= billete*n;
                    Console.WriteLine($"{billete} x {n}");
                }
            }
        }
    }
}