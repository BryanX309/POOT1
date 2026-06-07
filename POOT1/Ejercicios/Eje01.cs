namespace POOT1.Ejercicios
{
    public class Eje01
    {
        public Eje01()
        {
            Console.WriteLine("Calculadora de Indice de Masa Corporal\n----------------------------------------\n");
            Console.WriteLine("Ingrese su Peso (kg): ");
            double.TryParse(Console.ReadLine(), out double peso);
            Console.WriteLine("Ingrese su Altura (mts): ");
            double.TryParse(Console.ReadLine(), out double altura);

            double imc = peso / altura;
            string estado;
            
            if(imc >= 30) estado = "Obesidad";
            else if(imc >= 25) estado = "Sobrepeso";
            else if(imc >= 18.5) estado = "Peso Normal";
            else  estado = "Peso Bajo";

            Console.WriteLine($"Tu IMC es {imc}\nTienes {estado}");
        }
    }
}