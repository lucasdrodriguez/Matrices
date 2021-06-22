using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_03_viernes
{

    public enum EMateria
    {
        SinIncripcion = 1,
        Matematica,
        Fisica,
        Quimica,
        Biologia,
        Estructurada,
        BaseDeDatos,
        CsSociales
    }


    class Program
    {

        static void MostrarEnumerados()
        {
            foreach (EMateria item in Enum.GetValues(typeof(EMateria)))
            {
                Console.WriteLine($"{(int)item} . {item} ");
            }
        }

        static void Main(string[] args)
        {
            EMateria materia;
            string usuario, password;
            int opcion;

            string[,] matrizUsuario = new string[5, 3]
             {
              {"Lucas"   ,"Rodriguez" ,"asd123" },
              {"Juana"   ,"Martinez"  ,"adsasd" },

              {"Martin"  , "Gomez"    ,"pepe123" },

              {"Rodolfa" , "Lucios"   ,"laoalo"},
              {"Maria"   , "Becerra"  ,"ooop" }
            };

            EMateria[,] matrizMateriasCursadas = new EMateria[5, 4]
            {
              {EMateria.Matematica ,EMateria.Quimica ,EMateria.Biologia,EMateria.CsSociales},
              {EMateria.SinIncripcion ,EMateria.SinIncripcion ,EMateria.SinIncripcion,EMateria.SinIncripcion},
              {EMateria.CsSociales ,EMateria.SinIncripcion ,EMateria.Matematica,EMateria.CsSociales},
              {EMateria.Fisica ,EMateria.Matematica ,EMateria.Biologia,EMateria.CsSociales},
              {EMateria.Matematica ,EMateria.Quimica ,EMateria.CsSociales,EMateria.Biologia}

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
                        materia = EMateria.SinIncripcion;
                        Console.WriteLine($"Seleccionar materia:");

                        Console.WriteLine("0. Sin Inscripcion");
                        Console.WriteLine("1. Matematica");
                        Console.WriteLine("2. Fisica");
                        Console.WriteLine("3. Quimica");
                        Console.WriteLine("4. Biologia");
                        Console.WriteLine("5. Estructurada");
                        Console.WriteLine("6. BaseDeDatos");
                        Console.WriteLine("7. CsSociales");

                        opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {

                            case 0:
                                materia = EMateria.SinIncripcion;
                                break;
                            case 1:
                                materia = EMateria.Matematica;
                                break;
                            case 2:
                                materia = EMateria.Fisica;
                                break;
                            case 3:
                                materia = EMateria.Quimica;
                                break;
                            case 4:
                                materia = EMateria.Biologia;
                                break;
                            case 5:
                                materia = EMateria.Estructurada;
                                break;
                            case 6:
                                materia = EMateria.BaseDeDatos;
                                break;
                            case 7:
                                materia = EMateria.CsSociales;
                                break;
                        }

                        matrizMateriasCursadas[posEncontrada, c] = materia;

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
            else
            {
                Console.WriteLine("Usuario no logueado");
            }


            /// mostrar toda la info de todos los usuarios

            for (int f = 0; f < matrizUsuario.GetLength(0); f++) // cambia de fila
            {
                Console.Write("|");

                for (int c = 0; c < matrizUsuario.GetLength(1); c++) //cambia de columna
                {
                    Console.Write($"{matrizUsuario[f, c],-15}|");

                }

                for (int c = 0; c < matrizMateriasCursadas.GetLength(1); c++) //cambia de columna
                {
                    Console.Write($"{matrizMateriasCursadas[f, c],-15}|");
                }

                Console.WriteLine();
            }



            Console.ReadKey();

        }
    }
}
