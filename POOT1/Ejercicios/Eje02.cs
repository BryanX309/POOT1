namespace POOT1.Ejercicios
{
    public class Eje02
    {
        public Eje02()
        {
            string units1="", units2="";
            //units1: unidades originales
            //units2: unidades a convertir

            Console.WriteLine("Conversión de temperatura\n----------------------------------------");

            while (units1 != "Celsius" && units1 != "Fahrenheit" && units1 != "Kelvin")
            {
                Console.WriteLine("\nIngrese unidades de temperatura original (Celsius / Fahrenheit / Kelvin)");
                units1 = Console.ReadLine();

                if(units1 != "Celsius" && units1 != "Fahrenheit" && units1 != "Kelvin") Console.WriteLine("Ingrese un formato de unidades Valido");
            }

            while (units2 != "Celsius" && units2 != "Fahrenheit" && units2 != "Kelvin")
            {
                Console.WriteLine("\nIngrese unidades de temperatura a las que quiera convertir (Celsius / Fahrenheit / Kelvin)");
                units2 = Console.ReadLine();

                if(units2 != "Celsius" && units2 != "Fahrenheit" && units2 != "Kelvin") Console.WriteLine("Ingrese un formato de unidades Valido");

                if(units2 == units1)
                {
                    Console.WriteLine("\nLas unidades de originales y de conversion no pueden ser la misma\nIntentelo otra vez");
                    units2 = "";
                }
            }

            Console.WriteLine($"\nQue medida de grados {units1} quiere convertir a grados {units2}?: ");
            decimal.TryParse(Console.ReadLine(), out decimal heat1);

            decimal heat2;


            switch(units1) // se convierten cualquier unidad de temperatura a Celsius para faclitar operaciones
            {
                case "Fahrenheit": heat2 = (heat1 -32)*5m/9m; break;

                case "Kelvin": heat2 = heat1 - 273.15m;  break;

                default: heat2 = heat1 ;  break;
            }


            switch (units2) //se convierte los grados Celsius a la unidad solicitada
            {
                case "Fahrenheit": 
                heat2 *=(9m/5m);
                heat2 +=32; 
                break;

                case "Kelvin": heat2 += 273.15m;  break;

                default: heat2 *= 1;  break;
            }


            Console.WriteLine($"\n{heat1} grados {units1} son equivalentes a {heat2} grados {units2}");
        }
    }
}