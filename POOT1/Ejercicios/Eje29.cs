using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace POOT1.Ejercicios
{
    public class Eje29
    {
        public Eje29()
        {
            bool fin = false;

            Console.Clear();
            Console.WriteLine("Juego de Gato (Tic-Tac-Toe) \n----------------------------------------\n");

            Console.Write("El Tablero se va a generar Vació y para seleccionar la casilla se usa el numero de casilla correspondiente a un tablero numérico\n\n");

            Console.WriteLine("	   |   |   ");
            Console.WriteLine("	 1 | 2 | 3 ");
            Console.WriteLine("	___|___|___");
            Console.WriteLine("	   |   |   ");
            Console.WriteLine("	 4 | 5 | 6 ");
            Console.WriteLine("	___|___|___");
            Console.WriteLine("	   |   |   ");
            Console.WriteLine("	 7 | 8 | 9 ");
            Console.WriteLine("	   |   |   ");

            Console.Write("\nPara Empezar Nuevo el juego Presione (Enter)\n");
            Console.Write("Para Salir Presione (Esc)\n");
            ConsoleKeyInfo tecla = Console.ReadKey();


            do
            {
                if (tecla.Key == ConsoleKey.Escape)
                {
                    fin = true;
                    Console.WriteLine("SSaliendo...");
                    continue;
                }

                if (tecla.Key == ConsoleKey.Enter)
                {
                    string ganador = "", turno = "X";
                    string[] celdas = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

                    Console.Clear();
                    Console.WriteLine($"Juego de Gato (Tic-Tac-Toe) \n----------------------------------------\nTURNO DE {turno}\n\n");

                    Console.WriteLine($"	   |   |   ");
                    Console.WriteLine($"	 {celdas[0]} | {celdas[1]} | {celdas[2]} ");
                    Console.WriteLine($"	___|___|___");
                    Console.WriteLine($"	   |   |   ");
                    Console.WriteLine($"	 {celdas[3]} | {celdas[4]} | {celdas[5]} ");
                    Console.WriteLine($"	___|___|___");
                    Console.WriteLine($"	   |   |   ");
                    Console.WriteLine($"	 {celdas[6]} | {celdas[7]} | {celdas[8]} ");
                    Console.WriteLine($"	   |   |   ");


                    do
                    {
                        Console.Write($"\nSeleccione Casilla: ");
                        if (!int.TryParse(Console.ReadLine(), out int c) || c < 1 || c > 9)
                        {
                            Console.WriteLine("\nSELECCIONE UNA CASILLA VALIDA\n");
                            Console.ReadKey();
                            continue;
                        }

                        if (celdas[c - 1] != " ")
                        {
                            Console.WriteLine($"\nLA CASILLA {c} YA ESTA OCUPADA\nESCOJA OTRA\n");
                            Console.ReadKey();
                            continue;
                        }

                        celdas[c - 1] = turno;

                        //VERIFICACIÓN DE GANADOR
                        int[,] comb = new int[,] //TODAS LAS COMBINACIONES POSIBLES EN LAS QUE CADA JUGADOR PUEDE GANAR
                        {
                            //Horizontales
                            {0,1,2},
                            {3,4,5},
                            {6,7,8},
                            //verticales
                            {0,3,6},
                            {1,4,7},
                            {2,5,8},
                            //Diagonales
                            {0,4,8},
                            {2,4,6}
                        };

                        for (int i = 0; i < comb.GetLength(0); i++)
                        {
                            int c1 = comb[i,0];
                            int c2 = comb[i,1];
                            int c3 = comb[i,2];

                            if(celdas[c1] != " " && celdas[c1] == celdas[c2] && celdas[c1]==celdas[c3])
                            {
                                ganador = celdas[c1];
                                break;
                            }
                        }

                        bool vacios = false;
                        if(ganador == "")
                        {
                            foreach(string celda in celdas)
                            {
                                if(celda == " ") vacios = true;
                            }

                            if(!vacios) ganador = "EMPATE";
                        }


                        turno = (turno == "X" ? "O" : "X");

                        Console.Clear();
                        Console.WriteLine($"Juego de Gato (Tic-Tac-Toe) \n----------------------------------------\nTURNO DE {turno}\n\n");

                        Console.WriteLine($"	   |   |   ");
                        Console.WriteLine($"	 {celdas[0]} | {celdas[1]} | {celdas[2]} ");
                        Console.WriteLine($"	___|___|___");
                        Console.WriteLine($"	   |   |   ");
                        Console.WriteLine($"	 {celdas[3]} | {celdas[4]} | {celdas[5]} ");
                        Console.WriteLine($"	___|___|___");
                        Console.WriteLine($"	   |   |   ");
                        Console.WriteLine($"	 {celdas[6]} | {celdas[7]} | {celdas[8]} ");
                        Console.WriteLine($"	   |   |   ");

                    } while (ganador == "");

                    if(ganador == "EMPATE") Console.Write("\nJUEGO EMPATADO\n");
                    else Console.Write($"\nEL GANADOR ES: {ganador}\n");

                    Console.Write("\nPresione Cualquier Tecla para Reiniciar\n");
                    Console.Write("Salir (Esc)\n");
                    tecla = Console.ReadKey();

                    if (tecla.Key == ConsoleKey.Escape)
                    {
                        fin = true;
                        Console.WriteLine("SSaliendo...");
                        continue;
                    }
                }
            } while (!fin);
        }
    }
}