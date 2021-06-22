using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_02_Viernes
{

    public enum EMateria
    {
        Matematica = 1,
        Fisica,
        Quimica,
        Biologia,
        Estructurada,
        BaseDeDatos,
        CsSociales
    }

    class Program
    {

        static void Main(string[] args)
        {

            string usuario, password;

            Console.ForegroundColor = ConsoleColor.Magenta;



            string[,] matrizUsuario = new string[5, 3]
           {//usuario   //apellido   //contraseña
              {"Lucas"   ,"Rodriguez" ,"asd123" },
              {"Juana"   ,"Martinez"  ,"adsasd" },
              {"Martin"  , "Gomez"    ,"pepe123" },
              {"Rodolfa" , "Lucios"   ,"laoalo"},
              {"Maria"   , "Becerra"  ,"ooop" }
           };

            string[,] matrizMateriasCursadas = new string[5, 4]
            {
              {"Matematica" ,"ProgLogica" ,"Quimica","Educacion Fisica"},
              {"Matematicas" ,"ProgLogica" ,"Quimica","Educacion Fisica"},
              {"Cs Sociales" ,"Cs Naturales" ,"Quimica","Educacion Fisica"},
              {"Lengua" ,"ProgLogica" ,"Quimica","Educacion Fisica"},
              {"Ciencias Sociales" ,"ProgLogica" ,"Quimica","Educacion Fisica"}

            };

            usuario = "Martin";
            password = "pepe123";

            int posEncontrada = -1;

            for (int fila = 0; fila < matrizUsuario.GetLength(0); fila++)
            {
                if (matrizUsuario[fila, 0] == usuario) //usuario ya encontrado
                {
                    if (matrizUsuario[fila, 2] == password)
                    {
                        Console.WriteLine("Usuario Logueado");
                        posEncontrada = fila;
                    }
                }
            }


            if (posEncontrada != -1)
            {


                for (int c = 0; c < matrizMateriasCursadas.GetLength(1); c++)
                {

                    Console.WriteLine($"Materia actual:{matrizMateriasCursadas[posEncontrada, c]}");

                    Console.WriteLine("Queres modificarla? S/N");

                    if (Console.ReadKey(true).Key == ConsoleKey.S)
                    {
                        Console.WriteLine($"Ingresar materia:");
                        matrizMateriasCursadas[posEncontrada, c] = Console.ReadLine();
                    }
                }

                Console.Clear();

                Console.WriteLine($"ALUMNO:{matrizUsuario[posEncontrada, 1]},{matrizUsuario[posEncontrada, 0]}");
                Console.WriteLine();

                for (int c = 0; c < matrizMateriasCursadas.GetLength(1); c++)
                {
                    Console.WriteLine($"{matrizMateriasCursadas[posEncontrada, c]}");
                }



            }


            Console.ReadKey();

        }
    }
}
