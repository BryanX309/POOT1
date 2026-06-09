namespace POOT1.Ejercicios
{
    public class Eje02
    {
        public Eje02()
        {
            string unids1 = "", unids2 = "";
            decimal tem1 = 0, tem2 = 0;
            //unids1: unidades originales
            //unids2: unidades a convertir

            Console.WriteLine("Conversión de temperatura\n----------------------------------------");

            while (unids1 != "Celsius" && unids1 != "Fahrenheit" && unids1 != "Kelvin")
            {
                Console.WriteLine("\nIngrese unidades de temperatura original (Celsius / Fahrenheit / Kelvin)");
                unids1 = Console.ReadLine();

                if (unids1 != "Celsius" && unids1 != "Fahrenheit" && unids1 != "Kelvin") Console.WriteLine("Ingrese un formato de unidades Valido");
            }

            while (unids2 != "Celsius" && unids2 != "Fahrenheit" && unids2 != "Kelvin")
            {
                Console.WriteLine("\nIngrese unidades de temperatura a las que quiera convertir (Celsius / Fahrenheit / Kelvin)");
                unids2 = Console.ReadLine();

                if (unids2 != "Celsius" && unids2 != "Fahrenheit" && unids2 != "Kelvin") Console.WriteLine("Ingrese un formato de unidades Valido");

                if (unids2 == unids1)
                {
                    Console.WriteLine("\nLas unidades de originales y de conversion no pueden ser la misma\nIntentelo otra vez");
                    unids2 = "";
                }
            }

            bool temValido = true;
            do
            {
                Console.WriteLine($"\nQue medida de grados {unids1} quiere convertir a grados {unids2}?: ");
                temValido = decimal.TryParse(Console.ReadLine(), out tem1);
                if (!temValido)
                {
                    Console.WriteLine("INGRESE UN NUMERO VALIDO\n");
                    tem1 = 0;
                    continue;
                }
            } while (!temValido);

            switch (unids1) // se convierten cualquier unidad de temperatura a Celsius para facilitar operaciones
            {
                case "Fahrenheit": tem2 = (tem1 - 32) * 5m / 9m; break;

                case "Kelvin": tem2 = tem1 - 273.15m; break;

                default: tem2 = tem1; break;
            }


            switch (unids2) //se convierte los grados Celsius a la unidad solicitada
            {
                case "Fahrenheit":
                    tem2 *= (9m / 5m);
                    tem2 += 32;
                    break;

                case "Kelvin": tem2 += 273.15m; break;

                default: tem2 *= 1; break;
            }


            Console.WriteLine($"\n{tem1} grados {unids1} son equivalentes a {tem2} grados {unids2}");
        }
    }
}