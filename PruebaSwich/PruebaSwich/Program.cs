using System;

namespace PruebasSwitch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elije una opcion del Menu 1-6: \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8" + "4.- Salchipapa $15 \n" + "5.- Torta de pierna $20 \n" + "6.- Burrito $25 \n");
            int op = Convert.ToInt32(Console.ReadLine());

            Console.Clear();// Limpia lo que haya en la consola

            while (op < 0 || op > 6) // | | para hacer una comparacion tipo OR mientras que && es AND
            {
                Console.WriteLine("Elije una opcion del Menu (Digitando el numero de Opcion): \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8" + "4.- Salchipapa $15 \n" + "5.- Torta de pierna $20 \n" + "6.- Burrito $25 \n");
                op = Convert.ToInt32(Console.ReadLine());// Condicion cuando se elije una de las 6 opciones

                Console.Clear();
            }


            Console.WriteLine("Elije una cantidad:");
            int cantidad = Convert.ToInt32(Console.ReadLine());//Pregunta la cantidad a querer y lee la respuesta dada

            Console.WriteLine("Desea llevar algo mas? TRUE OR FALSE");
            bool masPedido = Convert.ToBoolean(Console.ReadLine());//Pregunta si se quiere agregar algo mas al pedido con una operacion booleana

            Console.Clear();

            int cuenta = (Opcion(op) * cantidad); //se multiplica el precio de cada producto con la cantidad solicitada


            while (masPedido)//bucle que se da cuando la operacion booleana es true, dando de nuevo un menu
            {
                Console.WriteLine("Elije una opcion del Menu 1-6: \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8" + "4.- Salchipapa $15 \n" + "5.- Torta de pierna $20 \n" + "6.- Burrito $25 \n");
                op = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                while (op < 0 || op > 6)
                {
                    Console.WriteLine("Elije una opcion del Menu (Digitando el numero de Opcion): \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8" + "4.- Salchipapa $15 \n" + "5.- Torta de pierna $20 \n" + "6.- Burrito $25 \n");
                    op = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                }

                Console.WriteLine("Elije una cantidad:");//se elije una cantidad para la variable Mas pedido
                cantidad = Convert.ToInt32(Console.ReadLine());

                cuenta += (Opcion(op) * cantidad); //se hace la multiplicacion del precio por la cantidad

                Console.WriteLine("Desea llevar algo mas? TRUE OR FALSE");//Se vuelve a preguntar si quiere agregar mas
                masPedido = Convert.ToBoolean(Console.ReadLine());

                Console.Clear();
            }
            Console.WriteLine("El total de su cuenta seria de $" + cuenta.ToString()); //Se da el resultado total de las multiplicacionbes 

            Console.ReadKey();
        }

        public static int Opcion(int op)
        {
            switch (op)//se relaciona con el menu del inicio y cada opcion regresa su respectivo precio
            {
                case 1: return 3;
                case 2: return 4;
                case 3: return 8;
                case 4: return 15;
                case 5: return 20;
                case 6: return 25;
                case 0: return 0;
                default: return 0;
            }
        }
    }
}