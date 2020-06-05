using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz_1
{
    class Program
    {
        static int mat = 3;
        static string[,] matriz = new string[mat, mat];

        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE SUS CARACTERES\n");

            for (int e = 0; e < mat; e++)
            {
                for (int m = 0; m < mat; m++)
                {
                    Console.WriteLine("\nE: " + e + "M: " + m + "\n");

                    Console.Write("caracter: ");
                    matriz[m, e] = Console.ReadLine();
                }
            }

            Console.WriteLine("....................................\n");
            for (int e = 0; e < mat; e++)
            {
                for (int m = 0; m < mat; m++)
                {
                    Console.WriteLine("valor; " + matriz[m, e]);
                }
            }

            Console.ReadKey();

        }
    }
}
