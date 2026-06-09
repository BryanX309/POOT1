namespace POOT1.Ejercicios
{
    public class Eje06
    {
        private void msgReinicio(string msg) //Clase para devolver un mensaje en caso de error y reiniciar la pantalla siguiendo la coherencia estética
        {
            Console.Clear();
            Console.WriteLine("Área y perímetro\n----------------------------------------");
            if (msg.Length > 0) Console.WriteLine($"{msg}\n");
        }

        public Eje06()
        {
            bool fin = false;
            double area = 0, perimtr = 0;
            Console.WriteLine("Área y perímetro\n----------------------------------------");

            do{
                int selec=0;
                Console.WriteLine("Que Figura desea conocer su area y perímetro?");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Rectángulo");
                Console.WriteLine("4. Trapecio");
                
                if (!int.TryParse(Console.ReadLine(), out selec) || selec < 1 || selec > 4)
                    selec = 0;

                fin = true; // este valor se mantendrá a menos que se ingresen valores inválidos y vuelva a ser false
                Console.WriteLine();
                switch (selec)
                {
                    case 1: //Circulo
                        Console.WriteLine("Ingrese el Radio del circulo:");
                        double.TryParse(Console.ReadLine(), out double r);
                        if (r > 0)
                        {
                            area = r * r * 3.14;
                            perimtr = 2 * r * 3.14;
                        }
                        else
                        {
                            msgReinicio("NO SE INGRESARON VALORES VALIDOS");
                            fin = false;
                        }
                        break;



                    case 2: //Triangulo
                        //se usó el triangulo equilátero ya que no es posible calcular el perímetro de un triangulo solo conociendo la base y la altura
                        //y para calcular el area en base a sus lados requiere comprobar que sea un triangulo valido y una formula demasiado compleja para este ejercicio
                        Console.WriteLine("Ingrese el Alto del Triangulo:");
                        double.TryParse(Console.ReadLine(), out double alto);

                        Console.WriteLine("Ingrese el Base del Triangulo:");
                        double.TryParse(Console.ReadLine(), out double bas);


                        if (alto > 0 && bas > 0)
                        {
                            area = alto * bas / 2;
                            perimtr = bas + 2 * Math.Sqrt(alto * alto + (bas/2) * (bas/2)); // el perímetro es asumiendo que el triangulo sea simétrico visto desde su base
                        }
                        else
                        {
                            msgReinicio("NO SE INGRESARON VALORES VALIDOS");
                            fin = false;
                        }
                        break;



                    case 3: //Rectángulo
                        Console.WriteLine($"Ingrese el Alto del Rectángulo:");
                        double.TryParse(Console.ReadLine(), out double altoR);

                        Console.WriteLine($"Ingrese el Ancho del Rectángulo:");
                        double.TryParse(Console.ReadLine(), out double anchoR);

                        if (altoR > 0 && anchoR > 0)
                        {
                            area = altoR * anchoR;
                            perimtr = (altoR + anchoR) * 2;
                        }
                        else
                        {
                            msgReinicio("NO SE INGRESARON VALORES VALIDOS");
                            fin = false;
                        }
                        break;



                    case 4: //Trapecio
                        Console.WriteLine($"Ingrese el Alto del Trapecio:");
                        double.TryParse(Console.ReadLine(), out double altoT);

                        Console.WriteLine($"Ingrese el Ancho de la Base 1:");
                        double.TryParse(Console.ReadLine(), out double bas1);

                        Console.WriteLine($"Ingrese el Ancho de la Base 2:");
                        double.TryParse(Console.ReadLine(), out double bas2);

                        if (altoT > 0 && bas1 > 0 && bas2 > 0 && bas1 != bas2)
                        {
                            area = altoT * (bas1 + bas2) / 2;
                            perimtr = bas1+bas2+Math.Sqrt(Math.Pow(altoT,2)+Math.Pow((Math.Max(bas1,bas2)-Math.Min(bas1,bas2))/2,2))*2; //igual que con el triangulo esto es asumiendo que el trapecio sea simétrico verticalmente
                        }
                        else
                        {
                            msgReinicio("NO SE INGRESARON VALORES VALIDOS");
                            fin = false;
                        }
                        break;

                    default:
                        msgReinicio("SELECCIONE UNA OPCIÓN VALIDA");
                        fin = false;
                        break;
                }
            }while (!fin);

            Console.WriteLine($"\nArea: {area:F2}\nPerímetro: {perimtr:F2}");
        }
    }
}