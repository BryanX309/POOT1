namespace POOT1.Ejercicios
{
    public class Eje01
    {
        public Eje01()
        {
            double peso = 0, altura = 0;
            do
            {
                Console.WriteLine("Calculadora de Indice de Masa Corporal\n----------------------------------------\n");
                Console.WriteLine("Ingrese su Peso (kg): ");
                if (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0 || peso > 700)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN PESO VALIDO\n");
                    peso = 0;
                    continue;
                }

                
                Console.WriteLine("Ingrese su Altura (mts): ");
                if (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0 || altura > 3.00)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UNA ALTURA VALIDA\n");
                    altura = 0;
                    continue;
                }
            } while (peso <= 0 || altura <= 0);

            double imc = peso / altura;
            string estado;

            if (imc >= 30) estado = "OBESIDAD";
            else if (imc >= 25) estado = "SOBREPESO";
            else if (imc >= 18.5) estado = "PESO NORMAL";
            else estado = "PESO BAJO";

            Console.WriteLine($"\nTu IMC es {imc:F1}\nTienes {estado}");
        }
    }
}