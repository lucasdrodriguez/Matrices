using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_Viernes
{
    class Program
    {
        static void Main(string[] args)
        {

            string usuario,password;
                                             //  0,1
            string[,] matrizUsuario = new string[5,3]
            {//usuario   //apellido   //contraseña
              {"Lucas"   ,"Rodriguez" ,"asd123" },
              {"Juana"   ,"Martinez"  ,"adsasd" },
              {"Martin"  , "Gomez"    ,"pepe123" },
              {"Rodolfa" , "Lucios"   ,"laoalo"},
              {"Maria"   , "Becerra"  ,"ooop" }
            };

            usuario = "Martin";
            password = "pepe123";



            for (int i = 0; i < matrizUsuario.GetLength(0); i++)
            {
                if(matrizUsuario[i,0] == usuario) //usuario ya encontrado
                {
                   if(matrizUsuario[i,2] ==password)
                    {
                        Console.WriteLine("Usuario Logueado");
                    }

                }
            }






            Console.ReadKey();

        }
    }
}
