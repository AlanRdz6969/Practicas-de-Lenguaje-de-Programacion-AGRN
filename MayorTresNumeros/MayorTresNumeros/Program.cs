using System;

namespace MayorTresNumeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor para X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Ingrese un valor para y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Introduzca un valor para z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int mayor = x;
            if (y > mayor) mayor = y;
            if (z > mayor) mayor = z;


            switch (mayor)
            {
                case int n when (n == x && x > y && x > z):
                    Console.WriteLine("El numero Mayor es: " + x);
                    break;
                case int n when (n == y && y > x && y > z):
                    Console.WriteLine("El numero Mayor es: " + y);
                    break;
                case int n when (n == z && z > x && z > y):
                    Console.WriteLine("El numero Mayor es: " + z);
                    break;
                default:
                    Console.WriteLine("Hay dos o más números iguales o algo inesperado.");
                    break;

            }
            Console.ReadKey();
        }

    }
}