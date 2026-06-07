using System.ComponentModel.Design.Serialization;

namespace POOT1.Ejercicios
{
    public class Eje09
    {

        private double valilado(string msg = "Ingrese la medida del primer lado:") //Validación de Lado
        {
            double l = 0;
            while (l <= 0)
            {
                Console.WriteLine(msg);
                if (!double.TryParse(Console.ReadLine(), out l) || l <= 0)
                {
                    Console.WriteLine("La Medida Ingresada no es valida\nIntentelo Otra vez\n");
                }
            }

            return l;
        }

        private double calculoAngulo(double opsto, double ad1, double ad2)
        //Lado Opuesto al angulo a encontrar, lados 1 y 2 adyacentes al angulo
        {
            double angulo = Math.Acos((ad1 * ad1 + ad2 * ad2 - opsto * opsto)/(2*ad1*ad2)); //esta formula devuelve el angulo en radianes
            angulo *= (180.0 / Math.PI); //Convertimos los radianes a grados

            return angulo;
        }
        public Eje09()
        {
            bool trian = false; //esta variable determinara si las medidas ingresadas son de un triangulo posible, si no es posible repetirá el proceso desde el inicio
            double l1=0, l2=0, l3=0;

            while (!trian)
            {
                Console.WriteLine("Clasificación de triángulos\n----------------------------------------\n");

                l1 = valilado("Ingrese la medida del Primer lado:");
                l2 = valilado("Ingrese la medida del Segundo lado:");
                l3 = valilado("Ingrese la medida del Tercer lado:");

                double lmax = 0; //variable que guardará el lado mas grande para evaluar el triangulo

                lmax = Math.Max(lmax, l1);
                lmax = Math.Max(lmax, l2);
                lmax = Math.Max(lmax, l3);

                trian = (lmax < l1 + l2 + l3 - lmax);  //para que un triangulo sea valido su lado mas grande debe ser menor que la suma de los otros dos

                Console.Clear();
                if (!trian) Console.WriteLine("Las medidas ingresadas no pueden formar un Triangulo\nInténtelo otra vez\n");
            }

            double ang1 = calculoAngulo(l1,l2,l3);
            double ang2 = calculoAngulo(l2,l3,l1);
            double ang3 = calculoAngulo(l3,l1,l2);

            Console.WriteLine("Ángulos del Triangulo:\n");
            Console.WriteLine($"Angulo A: {ang1:F2} {(ang1 == 90 ? "Rectángulo" : (ang1>90 ? "Obtusángulo" : "Acutángulo"))}");
            Console.WriteLine($"Angulo B: {ang2:F2} {(ang2 == 90 ? "Rectángulo" : (ang2>90 ? "Obtusángulo" : "Acutángulo"))}");
            Console.WriteLine($"Angulo C: {ang3:F2} {(ang3 == 90 ? "Rectángulo" : (ang3>90 ? "Obtusángulo" : "Acutángulo"))}");
            
            if(l1 ==  l2 && l1 == l3) Console.WriteLine("\nEl Triangulo Ingresado es un Triangulo Equilátero");
            else if(l1 == l2 || l1 == l3 || l2 == l3)  Console.WriteLine("\nEl Triangulo Ingresado es un Triangulo Isosceles");
            else if(ang1 == 90 || ang2 == 90 || ang3 == 90)  Console.WriteLine("\nEl Triangulo Ingresado es un Triangulo Rectángulo");
            else Console.WriteLine("\nEl Triangulo Ingresado es un Triangulo Escaleno");
        }
    }
}