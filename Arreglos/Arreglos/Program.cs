using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] variable1 = { 1, 2, 3 }; //tiene mas de un valor el int[],es multidimensional
            string[] variable2 = { "hola" };

            int[] variable3 = {10, 20, 30};
            int[] variable4 = { 15, 25, 35 };
            int[] variable5 = { 13, 23, 33 };
            int[] variable6 = { 27, 37, 47 };
            int[] variable7 = { 99, 100, 101 };

            string[] variable8 = { "Salud", "Enfermo", "Medicina" };
            string[] variable9 = { "Alan", "Rodriguez", "Navarro" };
            string[] variable10 = { "W", "S", "D" };
            string[] variable11 = { "g", "T", "sal" };
            string[] variable12 = { "Iphone", "Samsung", "Xiomi" };

            Console.WriteLine(variable10[2]); //length enseña la cantidad de caracteres que almacena LA CASILLA
            
            Console.ReadKey();
           

        }
    }
}
