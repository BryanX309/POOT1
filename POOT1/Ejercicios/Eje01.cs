namespace POOT1.Ejercicios
{
    public class Eje01
    {
        public Eje01()
        {
            Console.WriteLine("Calculadora de Indice de Masa Corporal\n----------------------------------------\n");
            Console.WriteLine("Ingrese su Peso (kg): ");
            double.TryParse(Console.ReadLine(), out double weigth);
            Console.WriteLine("Ingrese su Altura (mts): ");
            double.TryParse(Console.ReadLine(), out double heigth);

            double imc = weigth / heigth;
            string state;
            
            if(imc >= 30) state = "Obesidad";
            else if(imc >= 25) state = "Sobrepeso";
            else if(imc >= 18.5) state = "Peso Normal";
            else  state = "Peso Bajo";

            Console.WriteLine($"Tu IMC es {imc}\nTienes {state}");
        }
    }
}