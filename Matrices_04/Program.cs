using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_04
{
    class Program
    {

        static Random misNumRandom = new Random();

        static void CargarMatriz(int[,] auxMatriz)
        {

            for (int f = 0; f < auxMatriz.GetLength(0); f++)
            {
                for (int c = 0; c < auxMatriz.GetLength(1); c++)
                {
                    auxMatriz[f, c] = misNumRandom.Next(1, 500);
                }
            }

        }

       
        static void MostrarMatriz(int[,] auxMatriz,string[] auxConductores)
        {

            Console.WriteLine($"{"Conductor",-10}{"Lunes",-15}{"Martes",-15}{"Miercoles",-15}{"Jueves",-15}{"Viernes",-15}");

            for (int f = 0; f < auxMatriz.GetLength(0); f++)
            {
                Console.Write($"{auxConductores[f],-10}"); //mueestro el conductor

                for (int c = 0; c < auxMatriz.GetLength(1); c++)// necesito iterar las columnas de KM
                {
                    Console.Write($"{auxMatriz[f, c],-15}");
                }


                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string[] arrayConductores = new string[7] 
                                                    { 
                                                    "pepe1",
                                                    "pepe2",
                                                    "pepe3",
                                                    "pepe4",
                                                    "pepe5",
                                                    "pepe6",
                                                    "pepe7"
            
                                                    };


            int[,] matrizNumeros = new int[7, 5];

            do
            {
                CargarMatriz(matrizNumeros);
                MostrarMatriz(matrizNumeros,arrayConductores);
                Console.WriteLine("\n---------------\n");
            } while (Console.ReadKey(true).Key == ConsoleKey.Spacebar);

            Console.ReadKey();
        }
    }
}
