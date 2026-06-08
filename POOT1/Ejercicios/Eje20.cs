namespace POOT1.Ejercicios
{
    public class Eje20
    {
        public Eje20()
        {
            bool contValida = false;
            do
            {
                Console.WriteLine("Validación de contraseña\n----------------------------------------\n");
                Console.WriteLine("Ingrese su contraseña");
                string cont = Console.ReadLine();

                bool nCaracteres = cont.Length>=8;

                bool mayus = false;
                bool minus = false;
                bool numer = false;
                bool espes = false;
                bool sinEspacios = true;

                foreach(char c in cont)
                {
                    if(char.IsUpper(c)) mayus = true;
                    else if(char.IsLower(c)) minus = true;
                    else if(char.IsDigit(c)) numer = true;
                    else if(char.IsWhiteSpace(c)) sinEspacios = false;
                    else if(!char.IsLetterOrDigit(c)) espes = true;
                }

                if(mayus&&minus&&numer&&espes)
                {
                    contValida=true;
                    Console.WriteLine("\nCONTRASEÑA VALIDA Y SEGURA");
                }
                else
                {
                    Console.WriteLine("\nLa Contraseña no es valida, le falta:\n");

                    if(!nCaracteres) Console.WriteLine("- Al menos 8 Caracteres");
                    if(!mayus) Console.WriteLine("- Al menos una letra Mayúscula");
                    if(!minus) Console.WriteLine("- Al menos una letra Minúscula");
                    if(!numer) Console.WriteLine("- Al menos un Numero");
                    if(!espes) Console.WriteLine("- Al menos un Caracter Especial");
                    if(!sinEspacios) Console.WriteLine("- No Contener Espacios");

                    Console.WriteLine("\nINTENTALO OTRA VEZ");
                    Console.ReadKey();
                    Console.Clear();
                }


            }while(!contValida);
        }
    }
}