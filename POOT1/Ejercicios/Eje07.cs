namespace POOT1.Ejercicios
{
    public class Eje07
    {

        string ingresoUnidad(string msg = "Ingrese unidades de datos Original\n(bytes, KB, MB, GB, TB)", string u1 = "")
        {
            string unid = "";

            while (unid != "bytes" && unid != "KB" && unid != "MB" && unid != "GB" && unid != "TB")
            {
                Console.WriteLine(msg);
                unid = Console.ReadLine();

                if(unid != "bytes" && unid != "KB" && unid != "MB" && unid != "GB" && unid != "TB") Console.WriteLine("Ingrese un Formato de unidades Valido\n");

                if(u1 !="" && unid == u1) //esta linea solo se usara con unid2 para que no repita unid1
                {
                    Console.WriteLine("Las unidades de originales y de conversion no pueden ser la misma\nInténtelo otra vez\n");
                    unid = "";
                }

            }
            return unid;
        }

        public Eje07()
        {
            string unids1 = "", unids2 = "";
            //unids1: unidades originales
            //unids2: unidades a convertir

            Console.WriteLine("Conversión de temperatura\n----------------------------------------\n");

            unids1 = ingresoUnidad("Ingrese unidades de datos Original\n(bytes, KB, MB, GB, TB)");
            unids2 = ingresoUnidad("Ingrese unidades de datos a Convertir\n(bytes, KB, MB, GB, TB)", unids1);

            Console.WriteLine($"\nQue medida de {unids1} quiere convertir a {unids2}?: ");
            double.TryParse(Console.ReadLine(), out double dts1);

            double dts2;

            switch (unids1) // convertimos las unidades ingresadas en bytes para facilitar las formulas de conversion
            {
                case "KB": dts2 = dts1 * Math.Pow(1000,1); break;
                case "MB": dts2 = dts1 * Math.Pow(1000,2); break;
                case "GB": dts2 = dts1 * Math.Pow(1000,3); break;
                case "TB": dts2 = dts1 * Math.Pow(1000,4); break;
                default: dts2 = dts1; break;
            }

             switch (unids2) // se convierten los bytes a la unidad de conversion
            {
                case "KB": dts2 /= Math.Pow(1000,1); break;
                case "MB": dts2 /= Math.Pow(1000,2); break;
                case "GB": dts2 /= Math.Pow(1000,3); break;
                case "TB": dts2 /= Math.Pow(1000,4); break;
                default: dts2 /= 1; break;
            }

            Console.WriteLine($"{dts1} {unids1} es lo mismo que {dts2} {unids2}");

        }
    }
}