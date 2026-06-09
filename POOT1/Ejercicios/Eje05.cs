namespace POOT1.Ejercicios
{
    public class Eje05
    {

        int ValidarHora(string msg="Ingrese la Primera Hora: ")
        {
            int h=-1;
            do
            {
                string ingreso; string[] partes; //variables temporales usadas solo para validar formato de hora y separar sus partes

                Console.WriteLine(msg);
                ingreso = Console.ReadLine();
                partes = ingreso.Split(':');

                if 
                ( //Condiciones para validar el formato de hora, si ninguna se cumple vuelve a intentarlo
                    ingreso.Length == 8 && // valida que el formato tenga el largo de una hora valida 00:00:00
                    partes.Length == 3 && 
                    int.Parse(partes[0]) >=0 && 
                    int.Parse(partes[0]) <=23 &&
                    int.Parse(partes[1]) >=0 && 
                    int.Parse(partes[1]) <=59 &&
                    int.Parse(partes[2]) >=0 && 
                    int.Parse(partes[2]) <=59 
                )
                {
                    h = int.Parse(partes[0])*3600+int.Parse(partes[1])*60+int.Parse(partes[2]);
                    //al convertir la hora en segundos totales facilita mucho la diferencia de horas
                }
                else
                {
                    Console.WriteLine("Ingrese una hora Valida\n");
                }
            }while (h<0);

            return h;
        }
        public Eje05(){

            int h1=0,h2=0,dif;
            Console.WriteLine("Tiempo transcurrido\n----------------------------------------");
            Console.WriteLine("Formato de Hora(24h):Minutos:Segundos");
            Console.WriteLine("Incluir ceros y sin espacios (00:00:00) \n");

            h1 = ValidarHora("Ingrese la Primera Hora: ");
            h2 = ValidarHora("Ingrese la Segunda Hora: ");

            dif = h1<h2 ? h2-h1 : h2-h1+3600*24;
            //suponiendo que si la segunda es menor que la primera esta sera tomada como si fuera del dia siguiente
            //ejm h1: 20:00, h2: 7:00; las horas entre lunes 20:00 y martes 7:00 

            //formato de diferencia
            int hrs = dif/3600;
            int mins = (dif - hrs * 3600)/60;
            int segs = dif - hrs * 3600 - mins * 60;

            Console.WriteLine($"Entre ambas horas hay una diferencia de {hrs} horas {mins} minutos {segs} segundos");
        }
    }
}