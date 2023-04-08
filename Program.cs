using System;

namespace EjerciciosSesion05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cómo te llamas?");
            string nombre = Console.ReadLine();
            Console.WriteLine("¿Cuál es tu correo electrónico?");
            string email = Console.ReadLine();
            Console.WriteLine("¿Tienes un cupón de descuento? Si/No");
            string cupón = Console.ReadLine();

            if(cupón == "Si")
            {
                Console.WriteLine("El precio de la entrada es 4,5 euros");
            }

            else if (cupón == "No")
            {
                Console.WriteLine("El precio de la entrada es 8 euros");
            }

            else 
            {
                Console.WriteLine("Tienes que decir Si o No. Capullo");
                cupón = null;
                Console.WriteLine("¿Tienes un cupón de descuento? Si/No");
                cupón = Console.ReadLine();

                if (cupón == "Si")
                {
                    Console.WriteLine("El precio de la entrada es 4,5 euros");
                }

                else if (cupón == "No")
                {
                    Console.WriteLine("El precio de la entrada es 8 euros");
                }

                else
                {
                    Console.WriteLine("No has introducido una respuesta válida. Adiós.");
                }
            }

            Console.WriteLine("Elije un lenguaje de programación:");
            Console.WriteLine("a) C#");
            Console.WriteLine("b) Java");
            Console.WriteLine("c) C++");
            string lenguaje = Console.ReadLine();
            switch (lenguaje)
            {
                case "a":
                    Console.WriteLine("Has elegido C#");
                    break;
                case "b":
                    Console.WriteLine("Has elegido Java");
                    break;
                case "c":
                    Console.WriteLine("Has elegido C++");
                    break;

            }

            Console.ReadKey();

        }
    }
}
