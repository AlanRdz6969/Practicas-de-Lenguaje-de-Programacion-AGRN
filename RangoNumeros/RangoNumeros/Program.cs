using System;

namespace RangoNumeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el valor para x: ");
            int x = Convert.ToInt32(Console.ReadLine()); //Almacena una entrada de datos

            Console.WriteLine("Ingresa el valor de y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                Console.Write("{0} ",i);//Se llama al nombre del archivo despues el metodo
            }

            
            Console.ReadKey();
        }
    }
}
