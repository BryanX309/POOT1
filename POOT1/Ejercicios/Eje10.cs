namespace POOT1.Ejercicios
{
    public class Eje10
    {
        public Eje10()
        {
            float nota = -1;

            while (nota < 0 || nota > 100)
            {
                Console.WriteLine("Sistema de calificaciones UNAH\n----------------------------------------\n");

                Console.WriteLine("Ingrese la nota a Calificar (0-100):");
                if (!float.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UNA NOTA VALIDA\n");
                    nota = -1;
                }
            }

            Console.WriteLine("\nSistema de Clasificación:\n");
            Console.WriteLine("A: 100-90 (Excelente)");
            Console.WriteLine("B: 89-80 (Bueno)");
            Console.WriteLine("C: 79-70 (Decente)");
            Console.WriteLine("D: 69-60 (Hay que mejorar)");
            Console.WriteLine("F: 60-0 (Reprobado)\n");

            if (nota >= 90) Console.WriteLine("El Alumno tiene una nota: A (EXCELENTE)");
            else if (nota >= 80) Console.WriteLine("El Alumno tiene una nota: B (BUENO)");
            else if (nota >= 70) Console.WriteLine("El Alumno tiene una nota: C (DECENTE)");
            else if (nota >= 60) Console.WriteLine("El Alumno tiene una nota: D (HAY QUE MEJORAR)");
            else Console.WriteLine("El Alumno tiene una nota: F (REPROBADO)");
        }
    }
}