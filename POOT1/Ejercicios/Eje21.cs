namespace POOT1.Ejercicios
{
    public class Eje21
    {
        char c = '*';

        private void DibTriangulo(int alto = 1, int ancho = 1)
        {
            for (int fila = 1; fila <= alto; fila++)
            {
                // se Calculan cuántos asteriscos corresponden a esta fila de forma proporcional
                int asteEnFila = (int)Math.Round((double)(fila) / alto * ancho);
                //mas arriba pocos asteriscos
                //mas abajo pocos asteriscos

                //Elimina Asteriscos que pueden deformar la figura
                if (ancho % 2 != asteEnFila % 2 && fila < alto)
                {
                    asteEnFila--;
                }

                // calculamos los espacios necesarios a la izquierda para centrar los asteriscos, a la derecha solo se aplica un salto de linea
                int espacios = (ancho - asteEnFila) / 2;

                // Imprimir espacios
                for (int i = 0; i < espacios; i++) Console.Write(" ");

                // Imprimir asteriscos
                for (int i = 0; i < asteEnFila; i++) Console.Write(c);

                Console.WriteLine();
            }
        }


        private void DibTriInvertido(int alto = 1, int ancho = 1)
        {
            for (int fila = alto; fila >= 1; fila--)
            {
                // se Calculan cuántos asteriscos corresponden a esta fila de forma proporcional
                int asteEnFila = (int)Math.Round((double)(fila) / alto * ancho);
                //mas abajo pocos asteriscos
                //mas arriba pocos asteriscos

                //Elimina Asteriscos que pueden deformar la figura
                if (ancho % 2 != asteEnFila % 2 && fila < alto)
                {
                    asteEnFila--;
                }

                // calculamos los espacios necesarios a la izquierda para centrar los asteriscos, a la derecha solo se aplica un salto de linea
                int espacios = (ancho - asteEnFila) / 2;

                // Imprimir espacios
                for (int i = 0; i < espacios; i++) Console.Write(" ");

                // Imprimir asteriscos
                for (int i = 0; i < asteEnFila; i++) Console.Write(c);

                Console.WriteLine();
            }
        }

        private void DibCuadHueco(int alto = 1, int ancho = 1)
        {
            for (int fila = 1; fila <= alto; fila++)
            {
                for (int col = 1; col <= ancho; col++)
                {
                    // Se dibuja asterisco solo si es la primera o ultima fila o columna
                    if (fila == 1 || fila == alto || col== 1 || col == ancho)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" "); // Espacio en blanco en el interior
                    }
                }

                Console.WriteLine();
            }
        }

        public Eje21()
        {
            int sele = 0, alto = 0, ancho = 0;

            while (sele <= 0 || alto <= 0 || ancho <= 0)
            {
                Console.WriteLine("Patrón de asteriscos\n----------------------------------------\n");
                Console.WriteLine("Seleccione que figura quiere generar:\n");
                Console.WriteLine("1. Triangulo");
                Console.WriteLine("2. Triangulo Invertido");
                Console.WriteLine("3. Rombo");
                Console.WriteLine("4. Cuadrado");

                if (!int.TryParse(Console.ReadLine(), out sele) || sele > 4 || sele < 1)
                {
                    Console.Clear();
                    Console.WriteLine("SELECCIONE UNA OPCIÓN VALIDA\n");
                    sele = 0;
                    continue;
                }

                Console.WriteLine("Ingrese el Alto de la Figura (5 min):");

                if (!int.TryParse(Console.ReadLine(), out alto) || alto < 5)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN ALTO VALIDO\n");
                    alto = 0;
                    continue;
                }

                Console.WriteLine("Ingrese el Ancho de la Figura (5 min):");

                if (!int.TryParse(Console.ReadLine(), out ancho) || ancho < 5)
                {
                    Console.Clear();
                    Console.WriteLine("INGRESE UN ANCHO VALIDO\n");
                    ancho = 0;
                    continue;
                }
            }


            Console.WriteLine("");

            switch (sele)
            {
                case 1: DibTriangulo(alto, ancho); break;
                case 2: DibTriInvertido(alto, ancho); break;
                case 3: DibTriangulo((int)alto / 2, ancho); DibTriInvertido(alto - (int)alto / 2, ancho); break;
                case 4: DibCuadHueco(alto, ancho); break;
            }


        }
    }
}